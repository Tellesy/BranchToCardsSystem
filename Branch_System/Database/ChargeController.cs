using MPBS.Database.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPBS.Database
{
    public static class ChargeController
    {
        public static Status addCharges(Charge charge)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = DBConnection.Connection();

            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = @"INSERT INTO [dbo].[Charge]
           (
            [Charge_Type]
           ,[Customer_ID]
           ,[Program_Code]
           ,[Branch_Code])
            VALUES
           (@v1
           ,@v2
           ,@v3
           ,@v4)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@v1", charge.ChargeType);
                    cmd.Parameters.AddWithValue("@v2", charge.CustomerID);
                    cmd.Parameters.AddWithValue("@v3", charge.ProgramCode);
                    cmd.Parameters.AddWithValue("@v4", charge.BranchCode);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch (Exception e)
                {
                    status.status = false;
                    status.status = false;
                    status.message = "Add to Charge\n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status<PTSAccount> getAccount(string branch_code)
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
    }
}
