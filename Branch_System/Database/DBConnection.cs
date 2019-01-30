using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CTS.Database
{
    public static class DBConnection
    {
        private static string ConnectionString = @"Data Source=DESKTOP-9T6FOLM\SQLEXPRESS;Initial Catalog=newDB;Integrated Security=True";

        public static SqlConnection Connection()
        {
             SqlConnection conn = new SqlConnection(ConnectionString);

            return conn;
        }
    }
}
