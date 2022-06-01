using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem
{
     public class DbConnection
    {
        private readonly string connectionString;
        public DbConnection()
        {
            connectionString = "Server=NABEELS-WORK;Database=ProjectManagementSystem;User Id=PrjMS;Password=Nabeel30;MultipleActiveResultSets=True;";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
