using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Branch_System.Database.Objects;
namespace Branch_System.Database
{
    public static class PO
    {
        public static Status addPO(string Card_Number, Customer customer, string Account,int Update_Code, char Indicator)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = DBConnection.Connection();

            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = @"INSERT INTO [dbo].[PO] 
                    ([Card_Number],[Name],[Customer_ID],[Account],[Begin_Date],[End_Date],[Email],[Phone],[Passport],[Update_Code],[Process_Indicator],[Branch_Code]
                    ,[Inputter])
                       VALUES (@v1, @v2, @v3,@v4,@v5,@v6,@v7,@v8,@v9,@v10,@v11,@v12,@v13)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@v1", Card_Number);
                    cmd.Parameters.AddWithValue("@v2", customer.Name);
                    cmd.Parameters.AddWithValue("@v3", customer.Id.ToString());
                    cmd.Parameters.AddWithValue("@v4", Account);
                    cmd.Parameters.AddWithValue("@v5", SheetManager.PO_Begin_Date);
                    cmd.Parameters.AddWithValue("@v6", SheetManager.PO_EXP_Date);
                    cmd.Parameters.AddWithValue("@v7", customer.Email);
                    cmd.Parameters.AddWithValue("@v8", customer.Phone);
                    cmd.Parameters.AddWithValue("@v9", customer.Passport);
                    cmd.Parameters.AddWithValue("@v10", Update_Code);
                    cmd.Parameters.AddWithValue("@v11", Indicator);
                    cmd.Parameters.AddWithValue("@v12", Database.Login.branch);
                    cmd.Parameters.AddWithValue("@v13", Database.Login.id);

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
