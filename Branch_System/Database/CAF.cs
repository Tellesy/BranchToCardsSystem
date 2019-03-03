using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CTS.Database.Objects;

namespace CTS.Database
{
   public static class CAF
    {
        public static Status addCAF(string Card_Number, string Card_Account, string EXP_Date, string Product)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = DBConnection.Connection();

            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = @"INSERT INTO [CAF]   
                    ([Card_Number],[Card_Account],[EXP_Date],[Product],[Inputter])
                     VALUES (@v1, @v2, @v3, @v4, @v5)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@v1", Card_Number);
                    cmd.Parameters.AddWithValue("@v2", Card_Account);
                    cmd.Parameters.AddWithValue("@v3", EXP_Date);
                    cmd.Parameters.AddWithValue("@v4", Product);
                    cmd.Parameters.AddWithValue("@v5", Database.Login.id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch (Exception e)
                {
                    status.status = false;
                    status.status = false;
                    status.message = "Add to CAF\n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status<List<CAFObject>> getUnauthCAF()
        {
            Status<List<CAFObject>> statusObject = new Status<List<CAFObject>>();
            statusObject.Object = new List<CAFObject>();
            statusObject.status = false;


            SqlConnection conn = DBConnection.Connection();

            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = @"SELECT [ID],[Card_Number],[Card_Account],[EXP_Date],[Product],[Inputter], convert(varchar,[Time], 103) FROM [CAF] WHERE Authorized = 0 AND Processed = 0";



                    SqlCommand cmd = new SqlCommand(query, conn);

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
                            CAFObject request = new CAFObject();
                            request.ID = Convert.ToInt32(reader[0].ToString());
                            request.Card_Number = reader[1].ToString();
                            request.Card_Account = reader[2].ToString();
                            request.EXP_Date = reader[3].ToString();
                            request.Product = reader[4].ToString();
                            request.Inputter = Convert.ToInt32(reader[5].ToString());
                            request.Time = reader[6].ToString();
                            statusObject.Object.Add(request);
                        }
                        statusObject.status = true;
                        return statusObject;
                    }


                }
                catch (Exception e)
                {
                    statusObject.status = false;
                    statusObject.message = "Get Unauth CAF records \n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status<List<CAFObject>> getAuthCAF()
        {
            Status<List<CAFObject>> statusObject = new Status<List<CAFObject>>();
            statusObject.Object = new List<CAFObject>();
            statusObject.status = false;


            SqlConnection conn = DBConnection.Connection();

            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = @"SELECT [ID],[Card_Number],[Card_Account],[EXP_Date],[Product],[Inputter], convert(varchar,[Time], 103) FROM [CAF] WHERE Authorized = 1 AND Processed = 0";



                    SqlCommand cmd = new SqlCommand(query, conn);

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
                            CAFObject request = new CAFObject();
                            request.ID = Convert.ToInt32(reader[0].ToString());
                            request.Card_Number = reader[1].ToString();
                            request.Card_Account = reader[2].ToString();
                            request.EXP_Date = reader[3].ToString();
                            request.Product = reader[4].ToString();
                            request.Inputter = Convert.ToInt32(reader[5].ToString());
                            request.Time = reader[6].ToString();
                            statusObject.Object.Add(request);
                        }
                        statusObject.status = true;
                        return statusObject;
                    }


                }
                catch (Exception e)
                {
                    statusObject.status = false;
                    statusObject.message = "Get Auth CAF records \n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status deleteCAF(int id)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "DELETE FROM [CAF] WHERE ID = @v1";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    cmd.Parameters.AddWithValue("@v1", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch (Exception e)
                {
                    status.status = false;
                    status.message = "CAF Record Delete" + Errors.ErrorsString.Error002 + "\n" + e;

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

        public static Status authCAF(int id)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "UPDATE [CAF] SET Authorizer = @v1 , Authorized = 1 WHERE ID = @v2";
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
                catch (Exception e)
                {
                    status.status = false;
                    status.message = "CAF Auth (Update CAF)\n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status processCAF(int id)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "UPDATE [CAF] SET [Processed] = 1 WHERE ID = @v1";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    cmd.Parameters.AddWithValue("@v1", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch (Exception e)
                {
                    status.status = false;
                    status.message = "CAF Process (Update CAF)\n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status<Product> getLimit(string Product)
        {
            Status<Product> statusObject = new Status<Product>();
            statusObject.status = false;

            SqlConnection conn = DBConnection.Connection();

            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = @"SELECT [Code],[Name],[Cash_Limit],[Cash_Transactions_Limit] ,[POS_Limit],[POS_Transactions_Limit] FROM [Products] WHERE Code = @v1";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@v1", Product);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        if (!reader.HasRows)
                        {
                            statusObject.status = false;
                            statusObject.message = "هذا المنتج غير موجود في قاعدة البيانات";
                            return statusObject;

                        }

                        while (reader.Read())
                        {
                            Product request = new Product();
                            request.Code = reader[0].ToString();
                            request.Name = reader[1].ToString();
                            request.Cash_Limit = Convert.ToInt32(reader[2].ToString());
                            request.Cash_Transactions_Limit = Convert.ToInt32(reader[3].ToString());
                            request.POS_Limit = Convert.ToInt32(reader[4].ToString());
                            request.POS_Transactions_Limit = Convert.ToInt32(reader[5].ToString());
                            statusObject.Object = request;
                        }
                        statusObject.status = true;
                        return statusObject;
                    }


                }
                catch (Exception e)
                {
                    statusObject.status = false;
                    statusObject.message = "Get Limit for CAF record \n" + Errors.ErrorsString.Error002 + "\n" +e;
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
    }
}
