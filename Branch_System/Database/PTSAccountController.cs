using CTS.Database.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CTS.Database
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
                    where program_code =" + programCode + " and customer_ID =" + customerID;

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

    }
}
