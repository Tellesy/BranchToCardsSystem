using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace MPBS.Database
{
    public static class MPBSystem
    {

        public static async Task CheckIfSystemActiveAsync()
        {
            //Define your baseUrl
            string baseUrl = "https://firestore.googleapis.com/v1/projects/cardstrackingsystem/databases/(default)/documents/System/State/";
            //Have your using statements within a try/catch blokc that will catch any exceptions.
            try
            {
                //We will now define your HttpClient with your first using statement which will use a IDisposable.
                using (HttpClient client = new HttpClient())
                {
                    //In the next using statement you will initiate the Get Request, use the await keyword so it will execute the using statement in order.
                    //The HttpResponseMessage which contains status code, and data from response.
                    using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                    {
                        //Then get the data or content from the response in the next using statement, then within it you will get the data, and convert it to a c# object.
                        using (HttpContent content = res.Content)
                        {
                            //Now assign your content to your data variable, by converting into a string using the await keyword.
                             var data = await content.ReadAsStringAsync();
                            //If the data isn't null return log convert the data using newtonsoft JObject Parse class method on the data.

                          
                            if (data != null)
                            {
                                //Parse your data into a object.
                                var dataObj = JObject.Parse(data);
                                //Then create a new instance of PokeItem, and string interpolate your name property to your JSON object.
                                //Which will convert it to a string, since each property value is a instance of JToken.
                                //dataObj["name"];
                                //Log your pokeItem's name to the Console.
                                Console.WriteLine("Is it Active: {0}",(bool) dataObj["fields"]["isActive"]["booleanValue"]);
                                //Get Current Status 
                                Status status = GetActiveStatus();
                                if(status.status != (bool)dataObj["fields"]["isActive"]["booleanValue"])
                                {
                                    UpdateActiveStatus((bool)dataObj["fields"]["isActive"]["booleanValue"]);
                                }
                         
                            }
                            else
                            {
                                Console.WriteLine("NO Data----------");
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception Hit------------");
                Console.WriteLine(exception);
            }

        }

        public static Status CheckVersion(string version)
        {
            Status status = new Status();
            status.status = false;


            SqlConnection conn = Database.DBConnection.Connection();
            try
            {
                conn.Open();

            }
            catch
            {
                status.status = false;
                status.message = "لا يمكن الوصول بقاعدة البيانات, الرجاء التأكد من الإتصال";

                return status;
            }
            if (conn.State == global::System.Data.ConnectionState.Open)
            {

                string query = string.Format(@"SELECT [Version]
                                                      ,[Active]
                                                FROM [CTS].[dbo].[Version] where Version = '{0}' and Active = 1", version);

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            status.status = false;
                            status.message = "عذراً, هذه النسخة غير مدعومة الرجاء تحديث النظام";

                            return status;

                        }
                    }


                    status.status = true;
                    conn.Close();
                    return status;
                }
                catch (Exception e)
                {
                    status.status = false;
                    status.message = Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status GetActiveStatus()
        {
            Status status = new Status();
            status.status = false;


            SqlConnection conn = Database.DBConnection.Connection();
            try
            {
                conn.Open();

            }
            catch
            {
                status.status = false;
                status.message = "لا يمكن الوصول بقاعدة البيانات, الرجاء التأكد من الإتصال";

                return status;
            }
            if (conn.State == global::System.Data.ConnectionState.Open)
            {

                string query = string.Format(@"SELECT TOP 1 [isActive] FROM [CTS].[dbo].[CTSystem]");

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            status.status = false;
                            status.message = "عذراً, النظام غير مفعل, الرجاء التواصل مع مسؤول المنظومة";

                            return status;

                        }
                        while (reader.Read())
                        {

                            status.status = bool.Parse(reader.GetValue(0).ToString());
                            if(!status.status)
                                status.message = "عذراً, النظام غير مفعل, الرجاء التواصل مع مسؤول المنظومة";

                        }
                    }


                  
                    conn.Close();
                    return status;
                }
                catch (Exception e)
                {
                    status.status = false;
                    status.message = Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status UpdateActiveStatus(bool activeStatus)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "UPDATE [dbo].[CTSystem] SET [isActive] = @v1";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    cmd.Parameters.AddWithValue("@v1", activeStatus);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch
                {
                    status.status = false;
                    status.message = "usActive Update \n" + Errors.ErrorsString.Error002;
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
