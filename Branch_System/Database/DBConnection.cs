using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MPBS.Database
{
    public static class DBConnection
    {
        //Local DB Laptop
        //private static string ConnectionString = @"Data Source=DESKTOP-9T6FOLM\SQLEXPRESS;Initial Catalog=CTS;Integrated Security=True";

        //Local DB Desktop
        private static string ConnectionString = @"Server=localhost\SQLEXPRESS01;Database=CTS;Trusted_Connection=True;";

        //All local Enviroment :: Should enable port first
        //private static string ConnectionString = @"Server=127.0.0.1,8888; Database=newDB; User Id= sa; Password = TellesyM1195;";

        // Production DB
        //private static string ConnectionString =  @"Server=10.128.130.119,8888; Database=CTS; User Id= sa; Password = TellesyM1195; ";
        // Test DB
        //   private static string ConnectionString = @"Server=10.128.130.119,8888; Database=CTS_UAT; User Id= sa; Password = TellesyM1195; ";

        //Macdows DB
        //DESKTOP-6AAHS4C\SQLEXPRESS
        //private static string ConnectionString = @"Data Source=DESKTOP-6AAHS4C\SQLEXPRESS;Initial Catalog=CTS;Integrated Security=True";

        public static SqlConnection Connection()
        {
             SqlConnection conn = new SqlConnection(ConnectionString);

            return conn;
        }
    }
}
