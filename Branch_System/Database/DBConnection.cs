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
        //WIN-IKQ69RO950I\Administrator
        //10.128.130.119,8888
       // private static string ConnectionString = @"Data Source=DESKTOP-9T6FOLM\SQLEXPRESS;Initial Catalog=newDB;Integrated Security=True";
        private static string ConnectionString = 
            @"Server=10.128.130.119,8888; Database=CTS; User Id= sa; Password = TellesyM1195; ";

        public static SqlConnection Connection()
        {
             SqlConnection conn = new SqlConnection(ConnectionString);

            return conn;
        }
    }
}
