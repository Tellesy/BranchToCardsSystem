using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CTS.Database.Objects;

namespace CTS.Database
{
    public static class PBF
    {
        public static Status addPBF( string Card_Account,int Balance, string NID, string Product)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = DBConnection.Connection();

            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = @"INSERT INTO [PBF] ([Card_Account],[Balance] ,[Inputter],[NID],[Product])
                     VALUES (@v1, @v2, @v3,@v4,@v5)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@v1", Card_Account);
                    cmd.Parameters.AddWithValue("@v2", Balance);
                    cmd.Parameters.AddWithValue("@v3", Database.Login.id);
                    cmd.Parameters.AddWithValue("@v4", NID);
                    cmd.Parameters.AddWithValue("@v5", Product);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch (Exception e)
                {
                    status.status = false;
                    status.status = false;
                    status.message = "Add to PBF\n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status<List<PBFObject>> getUnauthPBF()
        {
            Status<List<PBFObject>> statusObject = new Status<List<PBFObject>>();
            statusObject.Object = new List<PBFObject>();
            statusObject.status = false;


            SqlConnection conn = DBConnection.Connection();

            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = @"SELECT [ID],[Card_Account],[Balance] ,[Inputter], convert(varchar,[Time], 103),[NID],[Product] FROM [PBF] WHERE Authorized = 0 AND Processed = 0";



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
                            PBFObject request = new PBFObject();
                            request.ID = int.Parse(reader[0].ToString());
                            request.Card_Account = reader[1].ToString();
                            request.Balance = int.Parse(reader[2].ToString());
                            request.Inputter = int.Parse(reader[3].ToString());
                            request.Time = reader[4].ToString();
                            request.NID = reader[5].ToString();
                            request.Product = reader[6].ToString();
                            statusObject.Object.Add(request);
                        }
                        statusObject.status = true;
                        return statusObject;
                    }


                }
                catch (Exception e)
                {
                    statusObject.status = false;
                    statusObject.message = "Get Unauth PBF records \n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status<List<PBFObject>> getAuthPBF()
        {
            Status<List<PBFObject>> statusObject = new Status<List<PBFObject>>();
            statusObject.Object = new List<PBFObject>();
            statusObject.status = false;


            SqlConnection conn = DBConnection.Connection();

            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {      
                    string query = @"SELECT [ID],[Card_Account],[Balance] ,[Inputter], convert(varchar,[Time], 103),[NID],[Product] FROM [PBF] WHERE Authorized = 1 AND Processed = 0";



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
                            PBFObject request = new PBFObject();
                            request.ID = int.Parse(reader[0].ToString());
                            request.Card_Account = reader[1].ToString();
                            request.Balance = int.Parse(reader[2].ToString());
                            request.Inputter = int.Parse(reader[3].ToString());
                            request.Time = reader[4].ToString();
                            request.NID = reader[5].ToString();
                            request.Product = reader[6].ToString();
                            statusObject.Object.Add(request);
                        }
                        statusObject.status = true;
                        return statusObject;
                    }


                }
                catch
                {
                    statusObject.status = false;
                    statusObject.message = "Get Auth PBF records \n" + Errors.ErrorsString.Error002;
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

        public static Status deletePBF(int id)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "DELETE FROM [PBF] WHERE ID = @v1";
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
                    status.message = "PBF Record Delete" + Errors.ErrorsString.Error002;
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

        public static Status authPBF(int id)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "UPDATE [PBF] SET Authorizer = @v1 , Authorized = 1 WHERE ID = @v2";
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
                    status.message = "PBF Auth (Update Auth)\n" + Errors.ErrorsString.Error002;
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

        public static Status processPBF(int id)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "UPDATE [PBF] SET [Processed] = 1 WHERE ID = @v1";
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
                    status.message = "PBF Auth (Update Auth)\n" + Errors.ErrorsString.Error002;
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
