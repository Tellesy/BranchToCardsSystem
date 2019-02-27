using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Database
{
   static class Branch
    {
        public static string getBranch(int code)
        {
            string Branch = code.ToString();

            SqlConnection conn = DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = @"SELECT TOP 1 [Branch]
                                  FROM [Branches] WHERE [Branch_code] = @v1 ";

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@v1", code);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            conn.Close();
                            return Branch;

                        }
                        while (reader.Read())
                        {
                            Branch = reader[0].ToString();
                            conn.Close();
                            return Branch;

                        }
                    }
                }
                catch (Exception e)
                {
                    conn.Close();
                    return code.ToString();
                }


            }
            conn.Close();
            return Branch;
        }
    }
}
