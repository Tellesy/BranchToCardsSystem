using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Branch_System.Database
{
    public static class PBF
    {
        public static Status addPBF( string Card_Account,int Balance)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = DBConnection.Connection();

            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = @"INSERT INTO [dbo].[PBF] ([Card_Account],[Balance] ,[Inputter])
                     VALUES (@v1, @v2, @v3)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@v1", Card_Account);
                    cmd.Parameters.AddWithValue("@v2", Balance);
                    cmd.Parameters.AddWithValue("@v3", Database.Login.id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch
                {
                    status.status = false;
                    status.status = false;
                    status.message = "Add to PBF\n" + Errors.ErrorsString.Error002;
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
