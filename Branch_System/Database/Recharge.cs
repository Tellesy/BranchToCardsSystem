using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Branch_System.Database.Objects;

namespace Branch_System.Database
{
    public static class Recharge
    {
        public static string year;
        public static int amount;
        public static string active;


        public static Status checkYear()
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();


            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = @"SELECT * FROM [newDB].[dbo].[Year]";
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {

                        if (!reader.HasRows)
                        {
                            status.status = false;
                            status.message = Errors.ErrorsString.Error010;

                            return status;

                        }
                        else
                        {
                            while (reader.Read())
                            { 
                                year = reader[0].ToString();
                                amount = int.Parse(reader[1].ToString());
                                active = reader[2].ToString();

                                if (active != "True")
                                {
                                    status.status = false;
                                    status.message = Errors.ErrorsString.Error011;
                                    return status;
                                }

                                status.status = true;
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

              
                
            }
            else
            {
                status.status = false;
                status.message = Errors.ErrorsString.Error001;

                return status;
            }

            return status;
        }

        public static Status<int> checkRechargeAmountThisYear( string NID, string Product)
        {
            Status<int> statusObject = new Status<int>();
            statusObject.status = false;
            statusObject.Object = 0;

            SqlConnection conn = DBConnection.Connection();

            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = @"SELECT SUM(AMOUNT) FROM [newDB].[dbo].[Recharge]  where [NID] = @value1 AND [Product] = @value2 AND [R_Year] = @value3";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@value1",Int64.Parse(NID));
                cmd.Parameters.AddWithValue("@value2",int.Parse(Product));
                cmd.Parameters.AddWithValue("@value3", int.Parse(year));

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    
                    try
                    {
                        while (reader.Read())
                        {
                            if (reader[0].ToString() != "")
                                statusObject.Object = int.Parse(reader[0].ToString());
                            else
                                statusObject.Object = 0;
                        }
                        statusObject.status = true;
                        return statusObject;
                    }
                    catch
                    {
                        statusObject.status = false;
                        statusObject.message = "Check Recharge amount this year\n" + Errors.ErrorsString.Error002;
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

        public static Status<int> checkRechargeAmount(string NID, string Product)
        {
            Status<int> statusObject = new Status<int>();
            statusObject.status = false;
            statusObject.Object = 0;

            SqlConnection conn = DBConnection.Connection();

            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = @"SELECT SUM(AMOUNT) FROM [newDB].[dbo].[Recharge]  where [NID] = @value1 AND [Product] = @value2";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@value1", Int64.Parse(NID));
                cmd.Parameters.AddWithValue("@value2", int.Parse(Product));

                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    try
                    {
                        while (reader.Read())
                        {
                            if (reader[0].ToString() != "")
                                statusObject.Object = int.Parse(reader[0].ToString());
                            else
                                statusObject.Object = 0;
                        }
                        statusObject.status = true;
                        return statusObject;
                    }
                    catch
                    {
                        statusObject.status = false;
                        statusObject.message = "Check Recharge amount (Totat)\n" + Errors.ErrorsString.Error002;
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

        public static Status checkCardAccount(string CardAccount)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = @"SELECT TOP 1 * from Card_Accounts Where Card_Account = '"+CardAccount+"'";

                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {
                        if (!reader.HasRows)
                        {
                            status.status = false;
                            status.message = " لا يوجد حساب بطاقة بهذا الرقم الرجاء التحقق او ارسال رقم الحساب الى مدير النظام";
                            return status;

                        }
                        else
                        {
                            while (reader.Read())
                            {
                                status.status = true;

                            }
                            return status;

                        }
                    }
                    catch
                    {
                        status.status = false;
                        status.message = Errors.ErrorsString.Error002;
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

        public static Status recharge(string Customer_ID, string NID, int Recharge_Amount, string Product)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = DBConnection.Connection();

            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = @"INSERT INTO Recharge (Customer_ID, NID, Amount, Product, R_Year,Inputter,Branch) " +
                 "VALUES (@value1, @value2, @value3, @value4, @value5,@value6,@value7)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@value1", Customer_ID);
                    cmd.Parameters.AddWithValue("@value2", NID);
                    cmd.Parameters.AddWithValue("@value3", Recharge_Amount);
                    cmd.Parameters.AddWithValue("@value4", Product);
                    cmd.Parameters.AddWithValue("@value5", year);
                    cmd.Parameters.AddWithValue("@value6", int.Parse(Login.id));
                    cmd.Parameters.AddWithValue("@value7", int.Parse(Login.branch));

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    status.status = true;
                    return status;
                }
                catch
                {
                    status.status = false;
                    status.status = false;
                    status.message = "Recharge Function\n" + Errors.ErrorsString.Error002;
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