using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CTS.Database
{
    public static class Login
    {
        public static string username;
        public static string name;
        public static string branch;
        public static string role;
        public static string id;

        public static Status login(string username, string password)
        {
            Status status = new Status();
            status.status = false;
            string active = "False";

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
            if (conn.State == System.Data.ConnectionState.Open)
            {
            
                string query = String.Format(@"SELECT 
                               [Username]
                              ,[Employee]
                              ,[Active]
                              ,[LIB_ID]
                              ,[Role]
                              ,[Branch]
                          FROM [Users] WHERE Username = '{0}' AND Password = '{1}'",username,password);

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(!reader.HasRows)
                        {
                            status.status = false;
                            status.message = "اسم المستخدم او الرقم السري غير صحيح, الرجاء التأكد";

                            return status;

                        }
                        while (reader.Read())
                        {

                            Login.username = reader.GetValue(0).ToString();
                            Login.name = reader.GetValue(1).ToString();
                            active = reader.GetValue(2).ToString();
                            Login.id = reader[3].ToString();
                            role = reader[4].ToString();
                            branch = reader[5].ToString();
                            
                        }

                        if(active != "True")
                        {
                            status.status = false;
                            status.message = "هذا المستخدم غير مفعل, الرجاء الاستفسار من مديرك";

                            return status;
                        }
                    }

                    
                    status.status = true;
                    return status;
                }
                catch
                {
                    status.status = false;
                    status.message = Errors.ErrorsString.Error002;
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

        public static Status changePassowrd(string newPassword,string oldPassword)
        {
            Status status = new Status();
            status.status = false;

            //First Chick Password
            SqlConnection conn = Database.DBConnection.Connection();
            try
            {
                conn.Open();

            }
            catch (Exception e)
            {
                status.status = false;
                status.message = "لا يمكن الوصول بقاعدة البيانات, الرجاء التأكد من الإتصال" + "\n" + e;
                return status;
            }
            if(conn.State == System.Data.ConnectionState.Open)
            {
                string query = String.Format(@"SELECT *
                          FROM [Users] WHERE Username = '{0}' AND Password = '{1}'", username, oldPassword);

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            status.status = false;
                            status.message = "الرقم السري القديم غير صحيح, الرجاء التأكد";

                            return status;

                        }
                        else
                        {
                            query = String.Format(@"Update [Users] 
                            SET [Password] ={0} WHERE Username = '{1}' ", newPassword,username);

                            SqlCommand cmd2 = new SqlCommand(query, conn);
                            cmd2.ExecuteNonQuery();

                            status.status = true;
                            return status;

                        }
                    }
                }
                catch(Exception e)
                {
                    status.status = false;
                    status.message = e.ToString();
                    return status;
                }
            }
            return status;
        }
    }
}
