﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MPBS.Database
{
    public static class DBConnection
    {
       
        //Local DB Laptop (Dev)
        private static string ConnectionStringDev = @"Data Source=.\SQLEXPRESS;Initial Catalog=CTS;Integrated Security=True";
        //Production
        private static string ConnectionStringProduction =  @"Server=10.128.130.119,8888; Database=CTS; User Id= sa; Password = TellesyM1195; ";

        //UAT
        private static string ConnectionStringUAT = @"Server=10.128.130.119,8888; Database=CTS_UAT; User Id= sa; Password = TellesyM1195; ";


        private static string connString = ConnectionStringProduction;
        //private static string connString = ConnectionStringDev;



        public static void SwitchConnectionType(ConnectionType type)
        {
            switch (type)
            {
                case ConnectionType.Dev:
                    connString = ConnectionStringDev;
                    break;
                case ConnectionType.UAT:
                    connString = ConnectionStringUAT;
                    break;
                case ConnectionType.Prod:
                default:
                    connString = ConnectionStringProduction;
                    break;
            }
        }
        public static SqlConnection Connection()
        {
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }

        public enum ConnectionType
        {
            Dev, UAT, Prod
        }
    }
}
