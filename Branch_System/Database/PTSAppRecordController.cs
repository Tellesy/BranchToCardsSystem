using CTS.Database.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace CTS.Database
{
   public static class PTSAppRecordController
    {
        public static Status addAppRecord(PTSAppRecord appRecord)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = DBConnection.Connection();

            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = @"INSERT INTO [dbo].[PTS_AppRecord]
                   ([customer_id]
                   ,[bank_code]
                   ,[application_type]
                   ,[application_sub_type]
                   ,[program_code]
                   ,[device_number]
                   ,[device_plan_code_1]
                   ,[branch_code]
                   ,[inputter])
                    VALUES
                   (@v1
                   ,@v2
                   ,@v3
                   ,@v4
                   ,@v5
                   ,@v6
                   ,@v7
                   ,@v8
                   ,@v9)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@v1", appRecord.CustomerID);
                    cmd.Parameters.AddWithValue("@v2", "020354");
                    cmd.Parameters.AddWithValue("@v3", appRecord.ApplicationType);
                    cmd.Parameters.AddWithValue("@v4", appRecord.ApplicationSubType);
                    cmd.Parameters.AddWithValue("@v5", appRecord.ProgramCode);
                    if(string.IsNullOrEmpty(appRecord.DeviceNumber))
                    {
                        appRecord.DeviceNumber = "";
                    }
                    cmd.Parameters.AddWithValue("@v6", appRecord.DeviceNumber);
                    cmd.Parameters.AddWithValue("@v7", appRecord.DevicePlanCode);
                    cmd.Parameters.AddWithValue("@v8", appRecord.BranchCode);
                    cmd.Parameters.AddWithValue("@v9", appRecord.Inputter);


                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch (Exception e)
                {
                    conn.Close();
                    status.status = false;
                    status.status = false;
                    status.message = "Add to PTS Account\n" + Errors.ErrorsString.Error002 + "\n" + e;
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
