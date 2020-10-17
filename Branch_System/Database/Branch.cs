using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPBS.Database.Objects;

namespace MPBS.Database
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

        public static Status<List<Objects.Branch>> getBranches()
        {
            Status<List<Objects.Branch>> statusObject = new Status<List<Objects.Branch>>();
            statusObject.status = false;
            statusObject.Object = new List<Objects.Branch>();

            SqlConnection conn = DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = @"SELECT Branch_code,[Branch]
                                  FROM [Branches]";

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            conn.Close();
                            statusObject.status = false;
                            return statusObject;

                        }
                        while (reader.Read())
                        {
                            Objects.Branch branch = new Objects.Branch();
                            branch.Branch_code = Convert.ToInt32(reader[0].ToString());
                            branch.Name = reader[1].ToString();

                            statusObject.Object.Add(branch);

                        }
                        statusObject.status = true;
                        conn.Close();
                        return statusObject;
                    }
                }
                catch (Exception e)
                {
                    conn.Close();
                    statusObject.message = e.ToString();
                    return statusObject;
                }


            }
            conn.Close();
            return statusObject;
        }
    }
}
