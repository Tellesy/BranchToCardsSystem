using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Branch_System.Database
{
    public static class Recharge
    {
        public static string year;
        public static int amount;
        public static string active;


        public static Status CheckYear()
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();


            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = @"SELECT * FROM [newDB].[dbo].[Year]";
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {
                        if (!reader.HasRows)
                        {
                            status.status = false;
                            status.message = Errors.ErrorsString.Error010;

                            return status;

                        }
                        else
                        {
                            while (reader.Read())
                            { 
                                year = reader[0].ToString();
                                amount = int.Parse(reader[1].ToString());
                                active = reader[2].ToString();

                                if (active != "True")
                                {
                                    status.status = false;
                                    status.message = Errors.ErrorsString.Error011;
                                    return status;
                                }

                                status.status = true;
                                return status;
                              }

                        }
                    }
                    catch
                    {
                        status.status = false;
                        status.message = Errors.ErrorsString.Error002;
                        return status;
                    }

                }

              
                
            }
            else
            {
                status.status = false;
                status.message = Errors.ErrorsString.Error001;

                return status;
            }

            return status;
        }
    }
}