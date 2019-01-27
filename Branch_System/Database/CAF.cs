using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Branch_System.Database
{
   public static class CAF
    {
        public static Status addCAF(string Card_Number, string Card_Account, string EXP_Date, string Product)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = DBConnection.Connection();

            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = @"INSERT INTO [dbo].[CAF]   
                    ([Card_Number],[Card_Account],[EXP_Date],[Product],[Inputter])
                     VALUES (@v1, @v2, @v3, @v4, @v5)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@v1", Card_Number);
                    cmd.Parameters.AddWithValue("@v2", Card_Account);
                    cmd.Parameters.AddWithValue("@v3", EXP_Date);
                    cmd.Parameters.AddWithValue("@v4", Product);
                    cmd.Parameters.AddWithValue("@v5", Database.Login.id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch
                {
                    status.status = false;
                    status.status = false;
                    status.message = "Add to CAF\n" + Errors.ErrorsString.Error002;
                    return status;
                }
            }
            else
            {
                status.status = false;
                status.message = Errors.ErrorsString.Error001;
                return status;
            }
        }
    }
}
