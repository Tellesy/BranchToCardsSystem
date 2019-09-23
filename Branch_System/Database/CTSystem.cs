using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Database
{
    public static class CTSystem
    {

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
    }
}
