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


        //If branch flag = true, get only request for the user's branch
        public static Status<List<Objects.PTSAppRecord>> getUnAuthAppRecords(bool branchFlag)
        {
            string branch_code = "";
            Status<List<Objects.PTSAppRecord>> statusObject = new Status<List<Objects.PTSAppRecord>>();
            statusObject.Object = new List<Objects.PTSAppRecord>();
            statusObject.status = false;


            SqlConnection conn = DBConnection.Connection();

            if (branchFlag)
            {
               branch_code = Database.Login.branch.PadLeft(6, '0');
               

            }

            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {


                try
                {
                    string query = "";

                    if (branchFlag)
                    {
                        query = @"SELECT [record_id],[customer_id] ,[bank_code] ,[application_type] ,[application_sub_type],[program_code],[device_number] ,[device_plan_code_1],[branch_code],[inputter] ,[input_time] FROM [CTS].[dbo].[PTS_AppRecord] where branch_authorizer is NULL AND HQ_authorizer is NULL AND generated = 0 AND [branch_code] = '" +branch_code+"'";
                    }
                    else
                    {
                        query = @"SELECT [record_id],[customer_id] ,[bank_code] ,[application_type] ,[application_sub_type],[program_code],[device_number] ,[device_plan_code_1],[branch_code],[inputter] ,[input_time] FROM [CTS].[dbo].[PTS_AppRecord] where branch_authorizer is NULL AND HQ_authorizer is NULL AND generated = 0";
                    }


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
                            Objects.PTSAppRecord request = new Objects.PTSAppRecord();
                            if(!string.IsNullOrEmpty(reader[0].ToString()))
                                request.RecordID = int.Parse(reader[0].ToString());

                            if (!string.IsNullOrEmpty(reader[1].ToString()))
                                request.CustomerID = reader[1].ToString();

                            if (!string.IsNullOrEmpty(reader[2].ToString()))
                                request.BankCode = reader[2].ToString();

                            if (!string.IsNullOrEmpty(reader[3].ToString()))
                                request.ApplicationType =  reader[3].ToString().ToCharArray()[0];

                            if (!string.IsNullOrEmpty(reader[4].ToString()))
                                request.ApplicationSubType = reader[4].ToString().ToCharArray()[0];

                            if (!string.IsNullOrEmpty(reader[5].ToString()))
                                request.ProgramCode = reader[5].ToString();

                            if (!string.IsNullOrEmpty(reader[6].ToString()))
                                request.DeviceNumber = reader[6].ToString();

                            if (!string.IsNullOrEmpty(reader[7].ToString()))
                                request.DevicePlanCode = reader[7].ToString();

                            if (!string.IsNullOrEmpty(reader[8].ToString()))
                                request.BranchCode = reader[8].ToString();

                            if (!string.IsNullOrEmpty(reader[9].ToString()))
                                request.Inputter = reader[9].ToString();

                            if (!string.IsNullOrEmpty(reader[10].ToString()))
                                request.InputTime = DateTime.Parse(reader[10].ToString());

                            statusObject.Object.Add(request);
                        }
                        statusObject.status = true;
                        return statusObject;
                    }


                }
                catch (Exception e)
                {
                    statusObject.status = false;
                    statusObject.message = "Get Unauth Recharge requests \n" + Errors.ErrorsString.Error002 + "\n" + e;
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

    }
}
