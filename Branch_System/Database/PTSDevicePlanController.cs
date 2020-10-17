using MPBS.Database.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MPBS.Database
{
    public static class PTSDevicePlanController
    {
        public static Status<List<PTSDevicePlan>> getDevicePlan(string programCode)
        {
            Status<List<PTSDevicePlan>> statusObject = new Status<List<PTSDevicePlan>>();
            statusObject.status = false;
            List<PTSDevicePlan> devicePlan = new List<PTSDevicePlan>();

            SqlConnection conn = Database.DBConnection.Connection();


            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = @"
                  SELECT [plan_code] FROM [CTS].[dbo].[PTS_Device_Plan] where program_code = '" + programCode + "'";

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
                                PTSDevicePlan dp = new PTSDevicePlan();
                                
                                dp.PlanCode = reader[0].ToString();
                                dp.ProgramCode = programCode;

                                devicePlan.Add(dp);

                      
                            }
                            statusObject.status = true;
                            statusObject.Object = devicePlan;
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
