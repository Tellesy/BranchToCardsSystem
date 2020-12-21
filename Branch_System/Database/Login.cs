using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

namespace MPBS.Database
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
            //Login.role = null;
            //Login.branch = null;
            //Login.id = null;
            //Login.username = null;
            //Login.name = null;


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
                            Login.role = reader[4].ToString();
                            Login.branch = reader[5].ToString();
                            
                        }

                        if(active != "True")
                        {
                            status.status = false;
                            status.message = "هذا المستخدم غير مفعل, الرجاء الاستفسار من مديرك";

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
                            conn.Close();
                            conn.Open();
                            query = String.Format(@"Update [Users] 
                            SET [Password] ={0} WHERE Username = '{1}' ", newPassword,username);

                            SqlCommand cmd2 = new SqlCommand(query, conn);
                            cmd2.ExecuteNonQuery();

                            status.status = true;
                            conn.Close();
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

        /// <summary>
        /// Check if the username is Active directory Enabled
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static Status isADEnabled(string username)
        {


            Status status = new Status();
            status.status = false;
            string active = "False";
            string enabled = "False";

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
                              ,[AD_enabled]
                          FROM [Users] WHERE Username = '{0}", username);

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            status.status = false;
                            status.message = "اسم المستخدم غير صحيح, الرجاء التأكد";

                            return status;

                        }
                        while (reader.Read())
                        {
                            enabled = reader[6].ToString();

                        }

                        if (active != "True")
                        {
                            status.status = false;
                            status.message = "هذا المستخدم غير مفعل, الرجاء الاستفسار من مديرك";

                            return status;
                        }
                        if(enabled != "True")
                        {
                            status.status = false;
                            status.message = "هذا المستخدم غير مفعل, الرجاء الاستفسار من مديرك";

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
        public static Status domainLogin(string username, string password)
        {

            Status result = new Status();

            result.status = false;
            using (DirectoryEntry _entry = new DirectoryEntry())
            {
               // username = @"lib\" + username;
                _entry.Username = username;
                _entry.Password = password;
                DirectorySearcher _searcher = new DirectorySearcher(_entry);
                _searcher.Filter = "(objectclass=user)";

                //try
                //{
                //    PrincipalContext pc = new PrincipalContext(ContextType.Domain, "lib");
                //    bool Valid = pc.ValidateCredentials(username, password);
                //}
                //catch (Exception e)
                //{
                //    string error = e.Message;
                //}
               
                try
                {
                    SearchResult _sr = _searcher.FindOne();
                    string _name = _sr.Properties["displayname"][0].ToString();
                    result.status = true;
                }
                catch(Exception e)
                {
                    result.status = false;
                    result.message = e.Message;
                }
            }

            return result; //true = user authenticated!
        }
    }
}
