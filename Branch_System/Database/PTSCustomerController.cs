using MPBS.Database.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace MPBS.Database
{
    public static class PTSCustomerController
    {
        public static Status<PTSCustomer> getCustomer(string ID)
        {
            Status<PTSCustomer> statusObject = new Status<PTSCustomer>();
            statusObject.status = false;
            PTSCustomer customer = new PTSCustomer();

            SqlConnection conn = Database.DBConnection.Connection();


            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = @"SELECT [first_name] ,[father_name],[last_name] ,[gender] ,[nationality] ,
                                [embossed_name] ,[birthdate] ,[national_id] ,[passport_number] ,[passport_exp] ,[address]
                                ,[phone_ISD]  ,[phone_number]  ,[email] ,client_code FROM [CTS].[dbo].[PTS_Customer] where customer_ID = " + ID;

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
                                customer.FirstName = reader[0].ToString();
                                customer.FatherName = reader[1].ToString();
                                customer.LastName = reader[2].ToString();
                                customer.Gender =  reader[3].ToString();
                                customer.Nationality = reader[4].ToString();
                                customer.EmbossedName = reader[5].ToString();
                                customer.Birthdate = reader[6].ToString();
                                customer.NationalID = reader[7].ToString();
                                customer.PassportNumber = reader[8].ToString();
                                customer.PassportExp = reader[9].ToString();
                                customer.Address = reader[10].ToString();
                                customer.PhoneISD = reader[11].ToString();
                                customer.Phone = reader[12].ToString();
                                customer.Email = reader[13].ToString();
                                customer.ClientCode = reader[14].ToString();

                                customer.CustomerID = ID;
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

        public static Status addCustomer(PTSCustomer customer)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = DBConnection.Connection();

            conn.Open();

            string query = @"INSERT INTO [dbo].[PTS_Customer]
           ([customer_ID]
           ,[first_name]
           ,[father_name]
           ,[last_name]
           ,[gender]
           ,[nationality]
           ,[embossed_name]
           ,[birthdate]
           ,[national_id]
           ,[passport_number]
           ,[passport_exp]
           ,[address]
           ,[phone_ISD]
           ,[phone_number]
           ,[email])
     VALUES
           (@v1
           ,@v2
           ,@v3
           ,@v4
           ,@v5
           ,@v6
           ,@v7
           ,@v8
           ,@v9
           ,@v10
           ,@v11
           ,@v12
           ,@v13
           ,@v14
           ,@v15)";
            if (customer.Email == null)
            {
               query = @"INSERT INTO [dbo].[PTS_Customer]
           ([customer_ID]
           ,[first_name]
           ,[father_name]
           ,[last_name]
           ,[gender]
           ,[nationality]
           ,[embossed_name]
           ,[birthdate]
           ,[national_id]
           ,[passport_number]
           ,[passport_exp]
           ,[address]
           ,[phone_ISD]
           ,[phone_number])
     VALUES
           (@v1
           ,@v2
           ,@v3
           ,@v4
           ,@v5
           ,@v6
           ,@v7
           ,@v8
           ,@v9
           ,@v10
           ,@v11
           ,@v12
           ,@v13
           ,@v14)";
            }

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
          

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@v1", customer.CustomerID);
                    cmd.Parameters.AddWithValue("@v2", customer.FirstName);
                    cmd.Parameters.AddWithValue("@v3", customer.FatherName);
                    cmd.Parameters.AddWithValue("@v4", customer.LastName);
                    cmd.Parameters.AddWithValue("@v5", customer.Gender);
                    cmd.Parameters.AddWithValue("@v6", customer.Nationality);
                    cmd.Parameters.AddWithValue("@v7", customer.EmbossedName);
                    cmd.Parameters.AddWithValue("@v8", customer.Birthdate);
                    cmd.Parameters.AddWithValue("@v9", customer.NationalID);
                    cmd.Parameters.AddWithValue("@v10", customer.PassportNumber);
                    cmd.Parameters.AddWithValue("@v11", customer.PassportExp);
                    cmd.Parameters.AddWithValue("@v12", customer.Address);
                    cmd.Parameters.AddWithValue("@v13", customer.PhoneISD);
                    cmd.Parameters.AddWithValue("@v14", customer.Phone);
                    if(customer.Email != null)
                    cmd.Parameters.AddWithValue("@v15", customer.Email);






                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch (Exception e)
                {
                    status.status = false;
                    status.status = false;
                    status.message = "Add to PTS Customer\n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status AddClientCode(string customerID, string clientCode)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "UPDATE [dbo].[PTS_Customer] SET [client_code] = @v1 WHERE [customer_ID] = @v2";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    cmd.Parameters.AddWithValue("@v1", clientCode);
                    cmd.Parameters.AddWithValue("@v2", customerID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch
                {
                    conn.Close();
                    status.status = false;
                    status.message = "Customer Table (Update with Client Code)\n" + Errors.ErrorsString.Error002;
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
