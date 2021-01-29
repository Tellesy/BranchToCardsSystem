using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MPBS.Database.Objects;

namespace MPBS.Database
{
    public static class YearController
    {
        public static string year;
        public static int amount;
        public static string active;


        public static Status checkYear()
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();


            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = @"SELECT * FROM [Year]";
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {

                        if (!reader.HasRows)
                        {
                            status.status = false;
                            status.message = Errors.ErrorsString.Error010;
                            conn.Close();
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

                                conn.Close();
                                status.status = true;
                                return status;
                            }

                        }
                    }
                    catch
                    {
                        conn.Close();
                        status.status = false;
                        status.message = Errors.ErrorsString.Error002;
                        return status;
                    }

                }



            }
            else
            {
                conn.Close();
                status.status = false;
                status.message = Errors.ErrorsString.Error001;

                return status;
            }
            conn.Close();
            return status;
        }

  
    }
}