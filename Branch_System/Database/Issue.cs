using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MPBS.Database.Objects;

namespace MPBS.Database
{
    public static class SMTController
    {
        //IF True it will return the Number in status.message
   


        public static Status<string> getCardAccount(string Customer_ID, string Product)
        {
            Status<string> status = new Status<string>();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = @"SELECT TOP 1 [Card_Account] from Card_Accounts Where Product_Code = '" + Product + "' AND Customer_ID = " + int.Parse(Customer_ID) + " ";

                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {
                        if (!reader.HasRows)
                        {
                            status.status = false;
                            return status;

                        }
                        else
                        {
                            while (reader.Read())
                            {
                                status.Object = reader[0].ToString();
                                status.status = true;
                              //  status.message = "هذا الزبون لديه بطاقة, الرجاء التأكد او الذهاب الى خيار اعادة الاصدار";
                            }
                            return status;

                        }
                    }
                    catch (Exception e)
                    {
                        status.status = false;
                        status.message = Errors.ErrorsString.Error002 +"\n" + e;
                        return status;
                    }
                }

            }
            else
            {
                status.status = false;
                status.message = Errors.ErrorsString.Error001;

                return status;
            }

        }

        public static Status<CardAccount> getCardAccount(string Card_Account)
        {
            Status<CardAccount> status = new Status<CardAccount>();
            status.Object = new CardAccount();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = @"SELECT TOP 1 [Customer_ID],[Product_Code],[Customer_Account] from Card_Accounts Where [Card_Account] = '" + Card_Account +"'";

                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {
                        if (!reader.HasRows)
                        {
                            status.status = false;
                            return status;

                        }
                        else
                        {
                            while (reader.Read())
                            {
                                status.Object.Customer_ID = reader[0].ToString();
                                status.Object.Product = reader[1].ToString();
                                status.Object.Account = reader[2].ToString();
                                status.Object.Card_Account = Card_Account;
                                status.status = true;
                                //  status.message = "هذا الزبون لديه بطاقة, الرجاء التأكد او الذهاب الى خيار اعادة الاصدار";
                            }
                            return status;

                        }
                    }
                    catch (Exception e)
                    {
                        status.status = false;
                        status.message = Errors.ErrorsString.Error002 + "\n" + e;
                        return status;
                    }
                }

            }
            else
            {
                status.status = false;
                status.message = Errors.ErrorsString.Error001;

                return status;
            }

        }

        public static Status<string> getCardAccountFromCardNumber(string Card_Number)
        {
            Status<string> status = new Status<string>();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = @"SELECT TOP 1 [Card_Account] FROM [CTS].[dbo].[Cards] where Card_Number = '" + Card_Number+"'";

                SqlCommand cmd = new SqlCommand(query, conn);
               
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {
                        if (!reader.HasRows)
                        {
                            conn.Close();
                            status.status = false;
                            return status;
                        }
                        else
                        {
                            while (reader.Read())
                            {
                                status.Object = reader[0].ToString();
                                status.status = true;
                                //  status.message = "هذا الزبون لديه بطاقة, الرجاء التأكد او الذهاب الى خيار اعادة الاصدار";
                            }
                            conn.Close();
                            return status;

                        }
                    }
                    catch (Exception e)
                    {
                        conn.Close();
                        status.status = false;
                        status.message = Errors.ErrorsString.Error002 + "\n" + e;
                        return status;
                    }
                }

            }
            else
            {
                conn.Close();
                status.status = false;
                status.message = Errors.ErrorsString.Error001;

                return status;
            }
        }



        public static Status updateCustomerAccountForCardAccount(string cardAccount, string customerAccount)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = @"UPDATE [dbo].[Card_Accounts] SET [Customer_Account] = '"+customerAccount+"' WHERE Card_Account = '"+cardAccount+"'";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch (Exception e)
                {
                    status.status = false;
                    status.message = "Card Account Update\n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status<string> getAccountNumberFromCardAccount(string Card_Account)
        {
            Status<string> status = new Status<string>();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Close();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = @"SELECT TOP 1 [Customer_Account] FROM [CTS].[dbo].[Card_Accounts] where [Card_Account] = '" + Card_Account + "'";

                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {
                        if (!reader.HasRows)
                        {
                            status.status = false;
                            conn.Close();
                            return status;
                        }
                        else
                        {
                            while (reader.Read())
                            {
                                status.Object = reader[0].ToString();
                                status.status = true;
                                //  status.message = "هذا الزبون لديه بطاقة, الرجاء التأكد او الذهاب الى خيار اعادة الاصدار";
                            }
                            conn.Close();
                            return status;

                        }
                    }
                    catch (Exception e)
                    {
                        status.status = false;
                        status.message = Errors.ErrorsString.Error002 + "\n" + e;
                        conn.Close();
                        return status;
                        
                    }
                }

            }
            else
            {
                conn.Close();
                status.status = false;
                status.message = Errors.ErrorsString.Error001;

                return status;
            }
        }

    }
}
