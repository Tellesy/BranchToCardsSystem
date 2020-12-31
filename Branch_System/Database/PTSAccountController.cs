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


        public static Status addWalletNumber(string customerID, string programCode, string walletNumber)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "UPDATE [CTS].[dbo].[PTS_Account] SET [wallet_number] = @v1 WHERE [customer_ID] = @v2 AND [program_code] = @v3";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    cmd.Parameters.AddWithValue("@v1", walletNumber);
                    cmd.Parameters.AddWithValue("@v2", customerID);
                    cmd.Parameters.AddWithValue("@v3", programCode);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch
                {
                    conn.Close();
                    status.status = false;
                    status.message = "PTS Account (Add wallet Number)\n" + Errors.ErrorsString.Error002;
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


        public static Status updateAccount(string customerID, string programCode, string lydAccount, string programAccount)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "UPDATE [CTS].[dbo].[PTS_Account] SET [account_number_lyd]= @v1,[account_number_currency] = @v2 WHERE [customer_ID] = @v3 AND [program_code] = @v4";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    cmd.Parameters.AddWithValue("@v1", lydAccount);
                    cmd.Parameters.AddWithValue("@v2", programAccount);
                    cmd.Parameters.AddWithValue("@v3", customerID);
                    cmd.Parameters.AddWithValue("@v4", programCode);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch
                {
                    conn.Close();
                    status.status = false;
                    status.message = "PTS Account (update account)\n" + Errors.ErrorsString.Error002;
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
