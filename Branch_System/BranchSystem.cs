using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Branch_System
{
    public static class BranchSystem
    {

       private static readonly OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\BranchToCards\\Database.accdb\";Persist Security Info=False;");
        private static readonly string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =\"C:\\BranchToCards\\Database.accdb\";Persist Security Info=False;";

        //get new card number
        public static string getNewCardNumber(string ProductCode)
        {
            string cardNumber = "";
           using (OleDbConnection connection = new OleDbConnection(connString))
            {
                connection.Open();
                OleDbDataReader reader = null;

                OleDbCommand command = new OleDbCommand();
                if (ProductCode == "30")
                {
                    command = new OleDbCommand("SELECT TOP 1 * from  Sequences Where Used = False", connection);
                }
                else if(ProductCode == "10")
                {
                    command = new OleDbCommand("SELECT TOP 1 * from  Sequences_10 Where Used = False", connection);
                }
                
                //  command.Parameters.AddWithValue("@1", userName)
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cardNumber = reader[0].ToString();
                    
                }
            }

            return cardNumber;
        }

        public static List<string> getCustomerInfo(string customerID)
        {
            List<string> info = new List<string>();
            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                connection.Open();
                OleDbDataReader reader = null;

                OleDbCommand command = new OleDbCommand();

                    command = new OleDbCommand("SELECT TOP 1 * from  Customer Where Customer_ID = " + customerID + " ", connection);


                //  command.Parameters.AddWithValue("@1", userName)
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //Name
                    info.Add(reader[2].ToString());
                    //Birthdate
                    info.Add(reader[3].ToString());
                    //Phone
                    info.Add(reader[4].ToString());
                    //NID
                    info.Add(reader[5].ToString());



                }
            }

            return info;
        }

        public static void UpdateSequences(string cardNumber,string ProductCode)
        {
            string talbe = "Sequences";
            if(ProductCode != "30")
            {
                talbe = talbe + "_" + ProductCode;
            }

            using (OleDbConnection connection = new OleDbConnection(connString))
            {

                connection.Open();

                OleDbCommand cmd1 = new OleDbCommand(String.Format("UPDATE {0} SET Used = True WHERE Card_Number = @value ", talbe), connection);
                cmd1.Parameters.AddWithValue("@value", cardNumber);

                cmd1.ExecuteNonQuery();
                connection.Close();
            }
            //   cmd1.Parameters.AddWithValue("@value1", card[0].ToString());
        }

        public static void updateCustomerNID(string Customer_ID, string NID)
        {
            using (OleDbConnection connection = new OleDbConnection(connString))
            {

                connection.Open();

                OleDbCommand cmd1 = new OleDbCommand("UPDATE Customer SET NID = '"+ NID +"' WHERE Customer_ID = "+Customer_ID+" ", connection);
              //  cmd1.Parameters.AddWithValue("@value1", NID);
                //cmd1.Parameters.AddWithValue("@value2", int.Parse(Customer_ID));


               cmd1.ExecuteNonQuery();
                connection.Close();
            }
        }


        public static bool checkCardAccount(string Customer_ID,string Product_Code)
        {
            bool HasCardAccount = false;
            OleDbCommand command = new OleDbCommand();
            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                connection.Open();
                OleDbDataReader reader = null;

                command = new OleDbCommand("SELECT TOP 1 * from Card_Accounts Where Product_Code = '"+ Product_Code + "' AND Customer_ID = "+int.Parse(Customer_ID)+" ", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    HasCardAccount = true;

                }
            }

            return HasCardAccount;

        }
        public static void createCardAccount(string Card_Account, string Customer_Account, string Customer_ID,string NID,string Product_Code)
        {

            using (OleDbConnection connection = new OleDbConnection(connString))
            {

                connection.Open();

                OleDbCommand cmd1 = new OleDbCommand("INSERT INTO Card_Accounts (Card_Account,Customer_Account, Customer_ID, NID,Product_Code) " +
                                    "VALUES (@value1, @value2, @value3, @value4, @value5)", connection);
                cmd1.Parameters.AddWithValue("@value1", Card_Account);
                cmd1.Parameters.AddWithValue("@value2", Customer_Account);
                cmd1.Parameters.AddWithValue("@value3", Customer_ID);
                cmd1.Parameters.AddWithValue("@value4",NID);
                cmd1.Parameters.AddWithValue("@value5", Product_Code);

                cmd1.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static void createCard(string Card_Number, string Card_Account)
        {
            using (OleDbConnection connection = new OleDbConnection(connString))
            {

                connection.Open();

                if(Card_Account != "")
                {
                    string oldNumber = "";
                    //First see if there is an old card for this account
                    OleDbCommand cmd1 = new OleDbCommand("SELECT TOP 1 Card_Number from  Cards Where Active = True AND Card_Account = '" + Card_Account + "' ", connection);
                    OleDbDataReader reader = cmd1.ExecuteReader();

                    while (reader.Read())
                    {
                        oldNumber = reader[0].ToString();
                    }
                    if (oldNumber != "")
                    {
                        OleDbCommand cmd3 = new OleDbCommand("UPDATE CARDS SET Active = false WHERE Card_Number = @value ", connection);
                        cmd3.Parameters.AddWithValue("@value", oldNumber);
                        cmd3.ExecuteNonQuery();
                    }
                }
                
                OleDbCommand cmd2 = new OleDbCommand("INSERT INTO Cards (Card_Account,Card_Number,Active) " +
                                    "VALUES (@value1, @value2,true)", connection);
                cmd2.Parameters.AddWithValue("@value1", Card_Account);
                cmd2.Parameters.AddWithValue("@value2", Card_Number);

                cmd2.ExecuteNonQuery();
                connection.Close();
            }
        }


        
        public static void recharge(string customerID, string NID, int amount, string ProductCode, int year)   
        {

            using (OleDbConnection connection = new OleDbConnection(connString))
            {

                connection.Open();

                OleDbCommand cmd1 = new OleDbCommand("INSERT INTO Recharge (Customer_ID, NID, Amount, Product, R_Year) " +
                                    "VALUES (@value1, @value2, @value3, @value4, @value5)", connection);
                cmd1.Parameters.AddWithValue("@value1", customerID);
                cmd1.Parameters.AddWithValue("@value2", NID);
                cmd1.Parameters.AddWithValue("@value3", amount);
                cmd1.Parameters.AddWithValue("@value4", ProductCode);
                cmd1.Parameters.AddWithValue("@value5", year);

                cmd1.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static int totalRecharge(string NID, int year)
        {
            int amount = 0;


            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                connection.Open();
                OleDbDataReader reader = null;

                OleDbCommand command = new OleDbCommand();

                command = new OleDbCommand("SELECT Amount from Recharge Where NID" +
                    " = '" + 
                    NID + "' AND R_Year = " + year + " "
                    , connection);


                //  command.Parameters.AddWithValue("@1", userName)
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    amount = amount + int.Parse(reader[0].ToString());
                }
            }


            return amount;
        }

        public static bool isCustomerID(string customerID)
        {
            if (customerID == "") 
            customerID = "1";
            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                connection.Open();
                OleDbDataReader reader = null;

                OleDbCommand command = new OleDbCommand();

                command = new OleDbCommand("SELECT TOP 1 * from  Customer Where Customer_ID = " + customerID + " ", connection);

                //  command.Parameters.AddWithValue("@1", userName)
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return true;
                }
            }

            return false;
        }


    }
}
