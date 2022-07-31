using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem
{
    public class ClientDetailRepo : DbConnection, IClientDetailRepo
    {
        public int Add(ClientDetailModel client)
        {
            int identity = 0;
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "spAddClient";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pName", client.ClientName);
                    cmd.Parameters.AddWithValue("@pTypeId", client.ClientTypeId);
                    cmd.Parameters.AddWithValue("@pMobile", client.ClientPhone);
                    cmd.Parameters.AddWithValue("@pEmail", client.ClientEmail);
                    cmd.Parameters.AddWithValue("@pAddress", client.ClientAddress);
                    cmd.Parameters.AddWithValue("@pNote", client.Note);

                    conn.Open();
                    identity = int.Parse(cmd.ExecuteScalar().ToString());
                }
            }

            return identity;
        }
    }
}
