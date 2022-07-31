using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem
{
    public class ProjectDetailsRepo : DbConnection, IProjectDetailsRepo
    {
        public int Add(ProjectDetailsModel project)
        {
            int identity = 0;
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "spAddProject";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pName",project.ProjectName);
                    cmd.Parameters.AddWithValue("@pDescription",project.ProjectDescription);
                    cmd.Parameters.AddWithValue("@pTypeId",project.ProjectTypeId);
                    cmd.Parameters.AddWithValue("@pTools",project.ProjectTools);
                    cmd.Parameters.AddWithValue("@pClientId",project.ClientId);
                    cmd.Parameters.AddWithValue("@pStartDate",project.ProjectStartDateTime);
                    cmd.Parameters.AddWithValue("@pEndDate",project.ProjectEndDateTime);
                    cmd.Parameters.AddWithValue("@pStatusId",project.ProjectStatusId);
                    cmd.Parameters.AddWithValue("@pURL",project.ProjectURL);
                    cmd.Parameters.AddWithValue("@pPrice",project.ProjectPrice);

                    conn.Open();
                    identity = int.Parse(cmd.ExecuteScalar().ToString());
                }
            }

            return identity;
        }

        public ProjectDetailsModel Find(int Id)
        {
            ProjectDetailsModel project = null;
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "spViewProjectById";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pId", Id);

                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    project = new ProjectDetailsModel();

                    dr.Read();
                    project.ProjectName = dr["ProjectName"].ToString();
                    project.ProjectDescription = dr["ProjectDescription"].ToString();
                    project.ProjectTypeId = int.Parse(dr["ProjectTypeId"].ToString());
                    project.ProjectTools = dr["ProjectTools"].ToString();
                    project.ClientId = int.Parse(dr["ProjectClientId"].ToString());
                    project.ProjectStartDateTime = dr["ProjectStartDateTime"].ToString();
                    project.ProjectEndDateTime = dr["ProjectEndDateTime"].ToString();
                    project.ProjectStatusId = int.Parse(dr["ProjectStatusId"].ToString());
                    project.ProjectURL = dr["ProjectURL"].ToString();
                    project.ProjectPrice = double.Parse(dr["ProjectPrice"].ToString());
                }
            }

            return project;
        }

        public int Update(int Id, ProjectDetailsModel project)
        {
            int identity = 0;
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "spUpdateProject";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pId", Id);
                    cmd.Parameters.AddWithValue("@pName", project.ProjectName);
                    cmd.Parameters.AddWithValue("@pDescription", project.ProjectDescription);
                    cmd.Parameters.AddWithValue("@pTypeId", project.ProjectTypeId);
                    cmd.Parameters.AddWithValue("@pTools", project.ProjectTools);
                    cmd.Parameters.AddWithValue("@pClientId", project.ClientId);
                    cmd.Parameters.AddWithValue("@pStartDate", project.ProjectStartDateTime);
                    cmd.Parameters.AddWithValue("@pEndDate", project.ProjectEndDateTime);
                    cmd.Parameters.AddWithValue("@pStatusId", project.ProjectStatusId);
                    cmd.Parameters.AddWithValue("@pURL", project.ProjectURL);
                    cmd.Parameters.AddWithValue("@pPrice", project.ProjectPrice);

                    conn.Open();
                    identity = int.Parse(cmd.ExecuteNonQuery().ToString());
                }
            }

            return identity;
        }
    }
}
