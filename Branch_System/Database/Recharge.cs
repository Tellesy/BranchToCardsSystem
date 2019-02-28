using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CTS.Database.Objects;

namespace CTS.Database
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
                string query = @"SELECT * FROM [Year]";
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

        public static Status<int> checkRechargeAmountThisYear(string NID, string Product)
        {
            Status<int> statusObject = new Status<int>();
            statusObject.status = false;
            statusObject.Object = 0;

            SqlConnection conn = DBConnection.Connection();

            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = @"SELECT SUM(AMOUNT) FROM [Recharge]  where [NID] = @value1 AND [Authorized] = 1 AND [Product] = @value2 AND [R_Year] = @value3";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@value1", Int64.Parse(NID));
                cmd.Parameters.AddWithValue("@value2", int.Parse(Product));
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
                string query = @"SELECT SUM(AMOUNT) FROM [Recharge]  where [NID] = @value1 AND [Authorized] = 1 AND [Product] = @value2";
                SqlCommand cmd = new SqlCommand(query, conn);
                if(NID == "")
                {
                    NID = "0";
                }
                if(Product == "")
                {
                    Product = "0";
                }
                cmd.Parameters.AddWithValue("@value1", Convert.ToInt64(NID));
                cmd.Parameters.AddWithValue("@value2", Convert.ToInt32(Product));

                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    try
                    {
                        while (reader.Read())
                        {
                            if (reader[0].ToString() != "")
                                statusObject.Object = Convert.ToInt32(reader[0].ToString());
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
                string query = @"SELECT TOP 1 * from Card_Accounts Where Card_Account = '" + CardAccount + "'";

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

        public static Status recharge(string Customer_ID, string NID, int Recharge_Amount, string Product, string CardAccount,int Type)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = DBConnection.Connection();

            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = @"INSERT INTO Recharge (Customer_ID, NID, Amount, Product, R_Year,Inputter,Branch,CardAccount,Type) " +
                                    "VALUES (@value1, @value2, @value3, @value4, @value5,@value6,@value7,@value8,@value9)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@value1", Customer_ID);
                    cmd.Parameters.AddWithValue("@value2", NID);
                    cmd.Parameters.AddWithValue("@value3", Recharge_Amount);
                    cmd.Parameters.AddWithValue("@value4", Product);
                    cmd.Parameters.AddWithValue("@value5", year);
                    cmd.Parameters.AddWithValue("@value6", int.Parse(Login.id));
                    cmd.Parameters.AddWithValue("@value7", int.Parse(Login.branch));
                    cmd.Parameters.AddWithValue("@value8", CardAccount);
                    cmd.Parameters.AddWithValue("@value9", Convert.ToInt32(Type));


                    cmd.ExecuteNonQuery();
                    conn.Close();

                    status.status = true;
                    return status;
                }
                catch (Exception e)
                {
                    status.status = false;
                    status.status = false;
                    status.message = "Recharge Function\n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        //If branch flag = true, get only request for the user's branch
        public static Status<List<Objects.Recharge>> getUnAuthRecharge(bool branchFlag)
        {
            Status<List<Objects.Recharge>> statusObject = new Status<List<Objects.Recharge>>();
            statusObject.Object = new List<Objects.Recharge>();
            statusObject.status = false;


            SqlConnection conn = DBConnection.Connection();

            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = "";

                    if(branchFlag)
                    {
                        query = @"SELECT [ID],[Customer_ID],[R_Year],[Product],[Amount],[Time] ,[NID] ,[Inputter] ,[Branch], [CardAccount], [Type] FROM [Recharge] WHERE  [Authorized] = 0 AND [Branch] = @value1";
                    }
                    else
                    {
                        query = @"SELECT [ID],[Customer_ID],[R_Year],[Product],[Amount],[Time] ,[NID] ,[Inputter] ,[Branch], [CardAccount], [Type] FROM [Recharge] WHERE  [Authorized] = 0";
                    }


                    SqlCommand cmd = new SqlCommand(query, conn);

                    if(branchFlag)
                    cmd.Parameters.AddWithValue("@value1", int.Parse(Database.Login.branch));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        if (!reader.HasRows)
                        {
                            statusObject.status = false;
                            statusObject.message = "لا يوجد سجلات تحتاج الى تخويل";
                            return statusObject;

                        }

                        while (reader.Read())
                        {
                           Objects.Recharge request = new Objects.Recharge();
                            if (reader[0].ToString() != "" && reader[0] != null)
                                request.ID = int.Parse(reader[0].ToString());
                            request.Customer_ID = reader[1].ToString();
                            if (reader[2].ToString() != "" && reader[2] != null)
                                request.R_year = int.Parse(reader[2].ToString());
                            request.Product = reader[3].ToString();
                            if (reader[4].ToString() != "" && reader[4] != null)
                                request.Amount = int.Parse(reader[4].ToString());
                            request.Time = reader[5].ToString();
                            request.NID = reader[6].ToString();
                            if (reader[7].ToString() != "" && reader[7] != null)
                                request.Inputter = int.Parse(reader[7].ToString());
                            if (reader[8].ToString() != "" && reader[8] != null)
                                request.Branch = int.Parse(reader[8].ToString());
                            request.CardAccount = reader[9].ToString();
                            if(reader[10].ToString() != "" && reader[10] != null)
                                request.Type = Convert.ToInt32(reader[10].ToString());

                            statusObject.Object.Add(request);
                        }
                        statusObject.status = true;
                        return statusObject;
                    }


                }
                catch (Exception e)
                {
                    statusObject.status = false;
                    statusObject.message = "Get Unauth Recharge requests \n" + Errors.ErrorsString.Error002 + "\n" + e ;
                    return statusObject;
                }
            }
            else
            {
                statusObject.status = false;
                statusObject.message = Errors.ErrorsString.Error001;

                return statusObject;
            }
        }

        public static Status deleteRecharge(int id)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "DELETE FROM [Recharge] WHERE ID = @v1";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    cmd.Parameters.AddWithValue("@v1", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch
                {
                    status.status = false;
                    status.message = "Recharge Record Delete" + Errors.ErrorsString.Error002;
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

        public static Status authRecharge(int id)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "UPDATE [Recharge] SET Authorizer = @v1 , Authorized = 1 WHERE ID = @v2";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    cmd.Parameters.AddWithValue("@v1", Database.Login.id);
                    cmd.Parameters.AddWithValue("@v2", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch
                {
                    status.status = false;
                    status.message = "Rechage Auth (Update Auth)\n" + Errors.ErrorsString.Error002;
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

        public static Status<List<DataObjects.Recharge>> getRegarches(string from,string to,string prodouct,int customer_ID)
        {
            //is searching using Customer ID or Product ID
            bool isCustomer = false;
            bool isBranch = false;
            Status<List<DataObjects.Recharge>> status = new Status<List<DataObjects.Recharge>>();
            status.status = false;
            status.Object = new List<DataObjects.Recharge>();
           

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                string query = @"SELECT r.[ID]
                                      ,r.[Customer_ID]
	                                  , c.Name
                                      ,[R_Year]
                                      ,[Product]
                                      ,[Amount]
                                      ,[Time]
                                      ,r.[NID]
                                      ,[Inputter]
                                      ,[Branch]
                                      ,[Authorizer]
                                      ,[Authorized]
                                      ,[CardAccount]
                                      ,[Type]
                                  FROM  [Recharge] as r join Customer as c on c.Customer_ID = r.Customer_ID
                                  Where r.Time >= @v1 And r.Time <= @v2 AND r.Product = @v3";

                if(Database.Login.role != "0")
                {
                    isBranch = true;
                    query = query + " AND Branch = @v4";
                }
                if(customer_ID > 0)
                {
                    isCustomer = true;
                    query = query + " AND r.[Customer_ID] = @v5";

                }


                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (from == "" || from == null)
                    {
                        from = "01/01/2018";
                    }
                    if (to == "" || to == null)
                    {
                        to = "12/31/2090";
                    }

                    cmd.Parameters.AddWithValue("@v1",from);
                    cmd.Parameters.AddWithValue("@v2",to);
                    cmd.Parameters.AddWithValue("@v3", prodouct);
                    if(isBranch)
                    {
                        cmd.Parameters.AddWithValue("@v4", Database.Login.branch);
                    }
                    if(isCustomer)
                    {
                        cmd.Parameters.AddWithValue("@v5", customer_ID);
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        if (!reader.HasRows)
                        {
                            status.status = false;
                            status.message = " لا يوجد عمليات شحن في الفترة المحددة";
                            conn.Close();
                            return status;

                        }
                        else
                        {
                            int i = 1;
                            while (reader.Read())
                            {
                                
                                DataObjects.Recharge recharge = new DataObjects.Recharge();

                                if (reader[0].ToString() != "" && reader[0] != null)
                                    recharge.ID =Convert.ToInt32(reader[0].ToString());

                                if (reader[1].ToString() != "" && reader[1] != null)                            
                                    recharge.Customer_ID = reader[1].ToString();

                                recharge.Name = reader[2].ToString();

                                if (reader[3].ToString() != "" && reader[3] != null)
                                    recharge.R_Year = Convert.ToInt32(reader[3].ToString());

                                recharge.Product = reader[4].ToString();

                                if (reader[5].ToString() != "" && reader[5] != null)
                                    recharge.Amount = Convert.ToInt32(reader[5].ToString());

                                if (reader[6].ToString() != "" && reader[6] != null)
                                    recharge.Time = reader[6].ToString();

                                if (reader[7].ToString() != "" && reader[7] != null)
                                    recharge.NID = reader[7].ToString();

                                if (reader[8].ToString() != "" && reader[8] != null)
                                    recharge.Inputter = Convert.ToInt32(reader[8].ToString());

                                if(reader[9].ToString() != "" && reader[9] != null)
                                    recharge.Branch = Convert.ToInt32(reader[9].ToString());

                                var x = reader[10].ToString();
                                if(reader[10].ToString() != "" && reader[10] != null)
                                    recharge.Authorizer = Convert.ToInt16(reader[10].ToString());

                                var y = reader[11].ToString();
                                if (reader[11].ToString() != "" && reader[11] != null)
                                    if (reader[11].ToString() == "False")
                                        recharge.Authorized = 0;
                                    if(reader[11].ToString() == "True")
                                        recharge.Authorized = 1;

                                if (reader[12].ToString() != "" && reader[12] != null)
                                    recharge.CardAccount = reader[12].ToString();

                                if (reader[13].ToString() != "" && reader[13] != null)
                                    recharge.Type = reader[13].ToString();
                                i++;
                                Console.WriteLine(i);
                                status.Object.Add(recharge);
                            }
                            conn.Close();
                            status.status = true;
                            return status;

                        }


                    }
                }
                catch(Exception e)
                {
                    conn.Close();
                    status.status = false;
                    status.message = Errors.ErrorsString.Error002 + "\n" + e.Message;
                    return status;
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