using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Branch_System.Database
{
    public static class Issue
    {
        //IF True it will return the Number in status.message
        public static Status getNewCardNumber(string Product)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = @"SELECT TOP (1) [Card_Number] FROM [newDB].[dbo].[Sequences] where [Used] = 0 AND Branch = " + Login.branch;

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            status.status = false;
                            status.message = "لا يوجد ارقام بطاقات جديدة لهذا الفرع الرجاء التواصل مع مدير النظام";

                            return status;

                        }
                        while (reader.Read())
                        {
                            status.status = true;
                            status.message = reader[0].ToString();
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
            return status;
        }
    }
}
