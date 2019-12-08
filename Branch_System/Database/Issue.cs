﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CTS.Database.Objects;

namespace CTS.Database
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
                string query = @"SELECT TOP (1) [Card_Number] FROM [Sequences] where [Used] = 0 AND Locked = 0 AND [Product] = '"+Product+"' AND Branch = " + Login.branch;

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            status.status = false;
                            status.message = "لا يوجد ارقام بطاقات جديدة لهذا المنتج للفرع الذي تتبعه, الرجاء التواصل مع مدير النظام\n Product Code:" + Product;

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
                catch (Exception e)
                {
                    status.status = false;
                    status.message = Errors.ErrorsString.Error002 + "\n" + e;
                    return status;
                }

                
            }
            return status;
        }

        public static Status lockSequences(string CardNumber)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "UPDATE Sequences SET Locked = 1 WHERE Card_Number = '" + CardNumber + "'";
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
                    status.message = "Seqeuence Lock\n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status unlockSequences(string CardNumber)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "UPDATE Sequences SET Locked = 0 WHERE Card_Number = '" + CardNumber + "'";
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
                    status.message = "Seqeuence Unlock\n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status<Customer> getCustomer(string ID)
        {
            Status<Customer> statusObject = new Status<Customer>();
            statusObject.status = false;
            Customer customer = new Customer();

            SqlConnection conn = Database.DBConnection.Connection();


            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = @"SELECT TOP 1 
                               [Name]
                              ,[Birthdate]
                              ,[Phone]
                              ,[NID]
                          FROM [Customer] where [Customer_ID] = " + ID;

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
                                customer.Name = reader[0].ToString();
                                customer.Birthdate = reader[1].ToString();
                                customer.Phone = reader[2].ToString();
                                customer.NID = Int64.Parse(reader[3].ToString());

                                statusObject.status = true;
                                statusObject.Object = customer;
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

        public static Status<Customer> getCustomerByNID(string NID)
        {
            Status<Customer> statusObject = new Status<Customer>();
            statusObject.status = false;
            Customer customer = new Customer();

            SqlConnection conn = Database.DBConnection.Connection();


            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = @"SELECT TOP 1 
                               [Name]
                              ,[Birthdate]
                              ,[Phone]
                              ,[Customer_ID]
                          FROM [Customer] where [NID] = " + NID;

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
                                customer.Name = reader[0].ToString();
                                customer.Birthdate = reader[1].ToString();
                                customer.Phone = reader[2].ToString();
                                customer.Id = Int32.Parse(reader[3].ToString());

                                statusObject.status = true;
                                statusObject.Object = customer;
                                return statusObject;
                            }
                            conn.Close();
                            return statusObject;

                        }
                    }
                    catch (Exception e)
                    {
                        statusObject.status = false;
                        statusObject.message = "Get Customer Info\n" + Errors.ErrorsString.Error002 +"\n" + e;
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

        public static Status addCustomer(Customer customer)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = "INSERT INTO [Customer] ([Customer_ID],[Name],[Birthdate]"
                                        + ",[Phone],[NID])" +
                                         " VALUES (@value1,@value2,@value3,@value4,@value5)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@value1", customer.Id);
                cmd.Parameters.AddWithValue("@value2", customer.Name);
                cmd.Parameters.AddWithValue("@value3", customer.Birthdate.ToString());
                cmd.Parameters.AddWithValue("@value4", customer.Phone.ToString());
                cmd.Parameters.AddWithValue("@value5", customer.NID.ToString());

                try
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch(Exception e)
                {
                    status.status = false;
                    status.message = "Add Customer Info \n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status hasCardAccount(string Customer_ID, string Product)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = @"SELECT TOP 1 * from Card_Accounts Where Product_Code = '" + Product + "' AND Customer_ID = " + int.Parse(Customer_ID) + " ";

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
                                status.status = true;
                                status.message = "هذا الزبون لديه بطاقة, الرجاء التأكد او الذهاب الى خيار اعادة الاصدار";
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

        public static Status<string> getCardAccountFromCard_Number(string Card_Number)
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

        public static Status updateSequences(string CardNumber)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "UPDATE Sequences SET Used = 1, Locked = 1 WHERE Card_Number = '"+CardNumber+"'" ;
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
                    status.message = "Seqeuence Update\n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status createCardAccount(string Card_Account, string Customer_Account, string Customer_ID, string NID, string Product)
        {
            Status status = new Status();
            status.status = false;


            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = String.Format("INSERT INTO Card_Accounts (Card_Account,Customer_Account, Customer_ID, NID,Product_Code) " +
                                   "VALUES (@value1, @value2, @value3, @value4, @value5)");

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@value1", Card_Account);
                cmd.Parameters.AddWithValue("@value2", Customer_Account);
                cmd.Parameters.AddWithValue("@value3", Customer_ID);
                cmd.Parameters.AddWithValue("@value4", NID);
                cmd.Parameters.AddWithValue("@value5", Product);

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
                    status.message = "Create Card Account\n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status createCard(string Card_Number, string Card_Account, string Product)
        {
            Status status = new Status();
            status.status = false;

        
            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {

                    if (Card_Account != "")
                    {
                        string oldNumber = "";
                        //First see if there is an old card for this account
                        SqlCommand cmd = new SqlCommand("SELECT TOP 1 Card_Number from  Cards Where Active = 1 AND Card_Account = '" + Card_Account + "' ", conn);


                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                oldNumber = reader[0].ToString();
                            }
                            if (oldNumber != "")
                            {
                                conn.Close();
                                conn.Open();
                                SqlCommand cmd2 = new SqlCommand("UPDATE Cards SET Active = 0 WHERE Card_Number = @value ", conn);
                                cmd2.Parameters.AddWithValue("@value", oldNumber); 
                                cmd2.ExecuteNonQuery();
                                conn.Close();
                                // Add to CAF
                                Database.CAF.addCAF(oldNumber, Card_Account, SheetManager.Account_EXP_Date, Product, false);
                                

                            }
                        }


                    }
                    conn.Close();
                    conn.Open();
                    if (Card_Account == "")
                    {
                        Card_Account = Card_Number;
                    }
                    SqlCommand cmd3 = new SqlCommand("INSERT INTO Cards (Card_Account,Card_Number,Active) " +
                                        "VALUES (@value1, @value2,1)", conn);
                    cmd3.Parameters.AddWithValue("@value1", Card_Account);
                    cmd3.Parameters.AddWithValue("@value2", Card_Number);

                    cmd3.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch (Exception e)
                {
                    status.status = false;
                    status.message = "Create Card\n" + Errors.ErrorsString.Error002+ "\n" + e;
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
