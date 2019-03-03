using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CTS.Database.Objects;
using System.Data;

namespace CTS.Database
{
    public static class PO
    {
        public static Status addPO(string Card_Number, Customer customer, string Account,int Update_Code, char Indicator)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = DBConnection.Connection();

            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = @"INSERT INTO [PO] 
                    ([Card_Number],[Name],[Customer_ID],[Account],[Begin_Date],[End_Date],[Email],[Phone],[Passport],[Update_Code],[Process_Indicator],[Branch_Code]
                    ,[Inputter])
                       VALUES (@v1, @v2, @v3,@v4,@v5,@v6,@v7,@v8,@v9,@v10,@v11,@v12,@v13)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@v1", Card_Number);
                    cmd.Parameters.AddWithValue("@v2", customer.Name);
                    cmd.Parameters.AddWithValue("@v3", customer.Id.ToString());
                    cmd.Parameters.AddWithValue("@v4", Account);
                    cmd.Parameters.AddWithValue("@v5", SheetManager.PO_Begin_Date);
                    cmd.Parameters.AddWithValue("@v6", SheetManager.PO_EXP_Date);
                    cmd.Parameters.AddWithValue("@v7", customer.Email);
                    cmd.Parameters.AddWithValue("@v8", customer.Phone);
                    cmd.Parameters.AddWithValue("@v9", customer.Passport);
                    cmd.Parameters.AddWithValue("@v10", Update_Code);
                    cmd.Parameters.AddWithValue("@v11", Indicator);
                    cmd.Parameters.AddWithValue("@v12", Database.Login.branch);
                    cmd.Parameters.AddWithValue("@v13", Database.Login.id);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch (Exception e)
                {
                    status.status = false;
                    status.status = false;
                    status.message = "Add to PO\n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status<List<PObject>> getUnauthPO()
        {
            Status<List<PObject>> statusObject = new Status<List<PObject>>();
            statusObject.Object = new List<PObject>();
            statusObject.status = false;


            SqlConnection conn = DBConnection.Connection();

            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                        string query = @"SELECT [ID],[Card_Number],[Name],[Customer_ID] ,[Account],[Begin_Date],[End_Date],[Email],[Phone],[Passport],[Update_Code],[Process_Indicator],[Branch_Code] ,[Inputter] ,convert(varchar,[Time], 103) FROM [PO] WHERE Authorized = 0 AND Processed = 0";
                    


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
                            PObject request = new PObject();
                            request.ID = int.Parse(reader[0].ToString());
                            request.Card_Number = reader[1].ToString();
                            request.Name = reader[2].ToString();
                            request.Customer_ID = reader[3].ToString();
                            request.Account = reader[4].ToString();
                            request.Begin_Date = reader[5].ToString();
                            request.End_Date = reader[6].ToString();
                            request.Email = reader[7].ToString();
                            request.Phone = reader[8].ToString();
                            request.Passport = reader[9].ToString();
                            request.Update_Code = int.Parse(reader[10].ToString());
                            request.Process_Indicator = char.Parse(reader[11].ToString());
                            request.Branch_Code = reader[12].ToString();
                            request.Inputter = int.Parse(reader[13].ToString());
                            request.Time = reader[14].ToString();
                            statusObject.Object.Add(request);
                        }
                        statusObject.status = true;
                        return statusObject;
                    }


                }
                catch
                {
                    statusObject.status = false;
                    statusObject.message = "Get Unauth PO records \n" + Errors.ErrorsString.Error002;
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

        public static Status<List<PObject>> getAuthPO()
        {
            Status<List<PObject>> statusObject = new Status<List<PObject>>();
            statusObject.Object = new List<PObject>();
            statusObject.status = false;


            SqlConnection conn = DBConnection.Connection();

            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = @"SELECT [ID],[Card_Number],[Name],[Customer_ID] ,[Account],[Begin_Date],[End_Date],[Email],[Phone],[Passport],[Update_Code],[Process_Indicator],[Branch_Code] ,[Inputter] ,convert(varchar,[Time], 103) FROM [PO] WHERE Authorized = 1 AND Processed = 0";

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
                            PObject request = new PObject();
                            request.ID = int.Parse(reader[0].ToString());
                            request.Card_Number = reader[1].ToString();
                            request.Name = reader[2].ToString();
                            request.Customer_ID = reader[3].ToString();
                            request.Account = reader[4].ToString();
                            request.Begin_Date = reader[5].ToString();
                            request.End_Date = reader[6].ToString();
                            request.Email = reader[7].ToString();
                            request.Phone = reader[8].ToString();
                            request.Passport = reader[9].ToString();
                            request.Update_Code = int.Parse(reader[10].ToString());
                            request.Process_Indicator = char.Parse(reader[11].ToString());
                            request.Branch_Code = reader[12].ToString();
                            request.Inputter = int.Parse(reader[13].ToString());
                            request.Time = reader[14].ToString();
                            statusObject.Object.Add(request);
                        }
                        statusObject.status = true;
                        return statusObject;
                    }


                }
                catch
                {
                    statusObject.status = false;
                    statusObject.message = "Get Auth PO records \n" + Errors.ErrorsString.Error002;
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

        public static Status deletePO(int id)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "DELETE FROM [PO] WHERE ID = @v1";
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
                    status.message = "PO Record Delete" + Errors.ErrorsString.Error002;
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
        
        public static Status authPO(int id)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "UPDATE [PO] SET Authorizer = @v1 , Authorized = 1 WHERE ID = @v2";
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
                    status.message = "PO Auth (Update Auth)\n" + Errors.ErrorsString.Error002;
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

        public static Status processPO(int id)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "UPDATE [PO] SET [Processed] = 1 WHERE ID = @v1";
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
                    status.message = "PO Process (Update PO)\n" + Errors.ErrorsString.Error002;
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
