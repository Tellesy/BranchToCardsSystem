using CTS.Database.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace CTS.Database
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
                                ,[phone_ISD]  ,[phone_number]  ,[email] FROM [CTS].[dbo].[PTS_Customer] where customer_ID = "+ ID;

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
    }
}
