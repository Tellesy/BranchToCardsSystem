﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CTS.Database
{
    public static class DBConnection
    {
        //Local DB
       // private static string ConnectionString = @"Data Source=DESKTOP-9T6FOLM\SQLEXPRESS;Initial Catalog=newDB;Integrated Security=True";

         // Production DB
       // private static string ConnectionString =  @"Server=10.128.130.119,8888; Database=CTS; User Id= sa; Password = TellesyM1195; ";
        // Test DB
        private static string ConnectionString = @"Server=10.128.130.119,8888; Database=CTS-Test; User Id= sa; Password = TellesyM1195; ";

        public static SqlConnection Connection()
        {
             SqlConnection conn = new SqlConnection(ConnectionString);

            return conn;
        }
    }
}
