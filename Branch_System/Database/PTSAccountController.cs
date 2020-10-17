using MPBS.Database.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MPBS.Database
{
    public static class PTSAccountController
    {


        public static Status<PTSAccount> getAccount(string customerID, string programCode)
        {
            Status<PTSAccount> statusObject = new Status<PTSAccount>();
            statusObject.status = false;
            PTSAccount account = new PTSAccount();

            SqlConnection conn = Database.DBConnection.Connection();


            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = @"
                    SELECT [account_number_lyd],[account_number_currency],[wallet_number],[currency_code]
                    FROM [CTS].[dbo].[PTS_Account]
                    where program_code ='" + programCode + "' and customer_ID =" + customerID;

                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {
                        if (!reader.HasRows)
                        {
                            statusObject.status = false;
                            statusObject.message = Errors.ErrorsString.Error012;

                            return statusObject;

                        }
                        else
                        {
                            while (reader.Read())
                            {
                                account.AccountNumberLYD = reader[0].ToString();
                                account.AccountNumberCurrency = reader[1].ToString();
                                account.WalletNumber = reader[2].ToString();
                                account.CurrencyCode = reader[3].ToString();
                                account.ProgramCode = programCode;
                                account.Customer_ID = customerID;


                                statusObject.status = true;
                                statusObject.Object = account;
                                return statusObject;
                            }
                            return statusObject;

                        }
                    }
                    catch (Exception e)
                    {
                        statusObject.status = false;
                        statusObject.message = "Get Customer Info\n" + Errors.ErrorsString.Error002 + "\n" + e;
                        return statusObject;
                    }


                }

            }
            else
            {
                statusObject.status = false;
                statusObject.message = Errors.ErrorsString.Error001;

                return statusObject;
            }
        }

        public static Status addAccount(PTSAccount account)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = DBConnection.Connection();

            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = @"INSERT INTO [dbo].[PTS_Account]
           ([customer_ID]
           ,[account_number_lyd]
           ,[account_number_currency]
           ,[wallet_number]
           ,[program_code]
           ,[currency_code])
            VALUES
           (@v1
           ,@v2
           ,@v3
           ,@v4
           ,@v5
           ,@v6)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@v1", account.Customer_ID);
                    cmd.Parameters.AddWithValue("@v2", account.AccountNumberLYD);
                    cmd.Parameters.AddWithValue("@v3", account.AccountNumberCurrency);
                    if(String.IsNullOrEmpty(account.WalletNumber))
                    {
                        account.WalletNumber = "";
                    }
                    cmd.Parameters.AddWithValue("@v4", account.WalletNumber);
                    cmd.Parameters.AddWithValue("@v5", account.ProgramCode);
                    cmd.Parameters.AddWithValue("@v6", account.CurrencyCode);






                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch (Exception e)
                {
                    status.status = false;
                    status.status = false;
                    status.message = "Add to PTS Account\n" + Errors.ErrorsString.Error002 + "\n" + e;
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
