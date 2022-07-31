using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem
{
    public class UserAccountsRepo : DbConnection, IUserAccountsRepo
    {
        public UserAccountsModel Authenticate(string pUserName, string pUserPassword)
        {
            UserAccountsModel User;
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "spAuthenticate";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pUserName", pUserName);
                    cmd.Parameters.AddWithValue("@pUserPassword", pUserPassword);

                    conn.Open();
                    User = new UserAccountsModel();

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        User.UserId = (int)dr["UserId"];
                        User.UserName = pUserName;
                        User.UserFullName = dr["UserFullName"].ToString();
                        User.Email = dr["Email"].ToString();
                        User.Mobile = dr["Mobile"].ToString();
                        User.LoginRole = dr["LoginRole"].ToString();
                        User.LoginDateTime = (DateTime)dr["LoginDateTime"];
                    }
                }
            }

            return User;
        }

        public int Update(int Id, UserAccountsModel user)
        {
            int identity = 0;
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "spUpdateUser";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pId", Id);
                    cmd.Parameters.AddWithValue("@pUserFullName", user.UserFullName);
                    cmd.Parameters.AddWithValue("@pMobile", user.Mobile);
                    cmd.Parameters.AddWithValue("@pEmail", user.Email);

                    conn.Open();
                    identity = cmd.ExecuteNonQuery();
                }
            }

            return identity;
        }
    }
}
