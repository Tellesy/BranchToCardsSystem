﻿using MPBS.Database.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace MPBS.Database
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
                   ,@v9);SELECT SCOPE_IDENTITY();";

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
                    cmd.Parameters.AddWithValue("@v7", appRecord.DevicePlanCode1);
                    cmd.Parameters.AddWithValue("@v8", appRecord.BranchCode);
                    cmd.Parameters.AddWithValue("@v9", appRecord.Inputter);

                    int modified = Convert.ToInt32(cmd.ExecuteScalar());

                    //cmd.ExecuteNonQuery();
                    
                    conn.Close();
                    status.status = true;
                    status.message = modified.ToString();
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
                conn.Close();
                status.status = false;
                status.message = Errors.ErrorsString.Error001;
                return status;
            }
        }


        //If branch flag = true, get only request for the user's branch
        public static Status<List<Objects.PTSAppRecord>> getBranchUnAuthAppRecords(bool branchFlag)
        {
            string branch_code = "";
            Status<List<Objects.PTSAppRecord>> statusObject = new Status<List<Objects.PTSAppRecord>>();
            statusObject.Object = new List<Objects.PTSAppRecord>();
            statusObject.status = false;


            SqlConnection conn = DBConnection.Connection();

            if (branchFlag)
            {
               var bstatus = PTSBranchController.getBranch(int.Parse(Database.Login.branch));
                if(bstatus.status)
                {
                    branch_code = bstatus.Object.Code;
                }else
                {
                    branch_code = "0003";
                    branchFlag = false;
                }
              
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
                            conn.Close();
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
                                request.DevicePlanCode1 = reader[7].ToString();

                            if (!string.IsNullOrEmpty(reader[8].ToString()))
                                request.BranchCode = reader[8].ToString();

                            if (!string.IsNullOrEmpty(reader[9].ToString()))
                                request.Inputter = reader[9].ToString();

                            if (!string.IsNullOrEmpty(reader[10].ToString()))
                                request.InputTime = DateTime.Parse(reader[10].ToString());

                            statusObject.Object.Add(request);
                        }
                        conn.Close();
                        statusObject.status = true;
                        return statusObject;
                    }


                }
                catch (Exception e)
                {
                    conn.Close();
                    statusObject.status = false;
                    statusObject.message = "Get Unauth Recharge requests \n" + Errors.ErrorsString.Error002 + "\n" + e;
                    return statusObject;
                }
            }
            else
            {
                conn.Close();
                statusObject.status = false;
                statusObject.message = Errors.ErrorsString.Error001;

                return statusObject;
            }
        }

        public static Status<List<Objects.PTSAppRecord>> getHQUnAuthAppRecords()
        {
            string branch_code = "";
            Status<List<Objects.PTSAppRecord>> statusObject = new Status<List<Objects.PTSAppRecord>>();
            statusObject.Object = new List<Objects.PTSAppRecord>();
            statusObject.status = false;


            SqlConnection conn = DBConnection.Connection();



            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {


                try
                {
                   
                    string query = @"SELECT [record_id],[customer_id] ,[bank_code] ,[application_type] ,[application_sub_type],[program_code],[device_number] ,[device_plan_code_1],[branch_code],[inputter] ,[input_time] FROM [CTS].[dbo].[PTS_AppRecord] where branch_authorizer is not NULL AND HQ_authorizer is NULL AND generated = 0";
                    


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
                            if (!string.IsNullOrEmpty(reader[0].ToString()))
                                request.RecordID = int.Parse(reader[0].ToString());

                            if (!string.IsNullOrEmpty(reader[1].ToString()))
                                request.CustomerID = reader[1].ToString();

                            if (!string.IsNullOrEmpty(reader[2].ToString()))
                                request.BankCode = reader[2].ToString();

                            if (!string.IsNullOrEmpty(reader[3].ToString()))
                                request.ApplicationType = reader[3].ToString().ToCharArray()[0];

                            if (!string.IsNullOrEmpty(reader[4].ToString()))
                                request.ApplicationSubType = reader[4].ToString().ToCharArray()[0];

                            if (!string.IsNullOrEmpty(reader[5].ToString()))
                                request.ProgramCode = reader[5].ToString();

                            if (!string.IsNullOrEmpty(reader[6].ToString()))
                                request.DeviceNumber = reader[6].ToString();

                            if (!string.IsNullOrEmpty(reader[7].ToString()))
                                request.DevicePlanCode1 = reader[7].ToString();

                            if (!string.IsNullOrEmpty(reader[8].ToString()))
                                request.BranchCode = reader[8].ToString();

                            if (!string.IsNullOrEmpty(reader[9].ToString()))
                                request.Inputter = reader[9].ToString();

                            if (!string.IsNullOrEmpty(reader[10].ToString()))
                                request.InputTime = DateTime.Parse(reader[10].ToString());

                            statusObject.Object.Add(request);
                        }
                        conn.Close();
                        statusObject.status = true;
                        return statusObject;
                    }


                }
                catch (Exception e)
                {
                    conn.Close();
                    statusObject.status = false;
                    statusObject.message = "Get Unauth Recharge requests \n" + Errors.ErrorsString.Error002 + "\n" + e;
                    return statusObject;
                }
            }
            else
            {
                conn.Close();
                statusObject.status = false;
                statusObject.message = Errors.ErrorsString.Error001;

                return statusObject;
            }
        }

        public static Status authBranchAppRecord(int recordID)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "UPDATE [CTS].[dbo].[PTS_AppRecord] SET [branch_authorizer] = @v1 , [branch_auth_time] = @v2 WHERE [record_id] = @v3";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    cmd.Parameters.AddWithValue("@v1", Database.Login.id);
                    cmd.Parameters.AddWithValue("@v2", DateTime.Now);
                    cmd.Parameters.AddWithValue("@v3", recordID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch
                {
                    conn.Close();
                    status.status = false;
                    status.message = "App Record Branch Auth (Update Auth)\n" + Errors.ErrorsString.Error002;
                    return status;
                }

            }
            else
            {
                status.status = false;
                status.message = Errors.ErrorsString.Error001;
                conn.Close();
                return status;
            }

        }

        public static Status deleteAppRecord(int recordID)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "DELETE FROM [CTS].[dbo].[PTS_AppRecord]  WHERE [record_id] = @v1";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {

                    cmd.Parameters.AddWithValue("@v1", recordID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch
                {
                    conn.Close();
                    status.status = false;
                    status.message = "Delete AppRecord (Update Auth)\n" + Errors.ErrorsString.Error002;
                    return status;
                }

            }
            else
            {
                status.status = false;
                status.message = Errors.ErrorsString.Error001;
                conn.Close();
                return status;
            }

        }

        public static Status authHQAppRecord(int recordID)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "UPDATE [CTS].[dbo].[PTS_AppRecord] SET [HQ_authorizer] = @v1 , [HQ_auth_time] = @v2 WHERE [record_id] = @v3";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    cmd.Parameters.AddWithValue("@v1", Database.Login.id);
                    cmd.Parameters.AddWithValue("@v2", DateTime.Now);
                    cmd.Parameters.AddWithValue("@v3", recordID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch
                {
                    conn.Close();
                    status.status = false;
                    status.message = "App Record HQ Auth (Update Auth)\n" + Errors.ErrorsString.Error002;
                    return status;
                }

            }
            else
            {
                status.status = false;
                status.message = Errors.ErrorsString.Error001;
                conn.Close();
                return status;
            }

        }

        public static Status<List<Objects.PTSAppRecord>> getFullyAuthorizedAppRecords()
        {
          
            Status<List<Objects.PTSAppRecord>> statusObject = new Status<List<Objects.PTSAppRecord>>();
            statusObject.Object = new List<Objects.PTSAppRecord>();
            statusObject.status = false;


            SqlConnection conn = DBConnection.Connection();



            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {


                try
                {

                    string query = @"SELECT [record_id],[customer_id] ,[bank_code] ,[application_type] ,[application_sub_type],[program_code],[device_number] ,[device_plan_code_1],[branch_code],[inputter] ,[input_time] FROM [CTS].[dbo].[PTS_AppRecord] where branch_authorizer is not NULL AND HQ_authorizer is not NULL AND generated = 0 and MFlag = 0";



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
                            if (!string.IsNullOrEmpty(reader[0].ToString()))
                                request.RecordID = int.Parse(reader[0].ToString());

                            if (!string.IsNullOrEmpty(reader[1].ToString()))
                                request.CustomerID = reader[1].ToString();

                            if (!string.IsNullOrEmpty(reader[2].ToString()))
                                request.BankCode = reader[2].ToString();

                            if (!string.IsNullOrEmpty(reader[3].ToString()))
                                request.ApplicationType = reader[3].ToString().ToCharArray()[0];

                            if (!string.IsNullOrEmpty(reader[4].ToString()))
                                request.ApplicationSubType = reader[4].ToString().ToCharArray()[0];

                            if (!string.IsNullOrEmpty(reader[5].ToString()))
                                request.ProgramCode = reader[5].ToString();

                            if (!string.IsNullOrEmpty(reader[6].ToString()))
                                request.DeviceNumber = reader[6].ToString();

                            if (!string.IsNullOrEmpty(reader[7].ToString()))
                                request.DevicePlanCode1 = reader[7].ToString();

                            if (!string.IsNullOrEmpty(reader[8].ToString()))
                                request.BranchCode = reader[8].ToString();

                            if (!string.IsNullOrEmpty(reader[9].ToString()))
                                request.Inputter = reader[9].ToString();

                            if (!string.IsNullOrEmpty(reader[10].ToString()))
                                request.InputTime = DateTime.Parse(reader[10].ToString());

                            statusObject.Object.Add(request);
                        }
                        conn.Close();
                        statusObject.status = true;
                        return statusObject;
                    }


                }
                catch (Exception e)
                {
                    conn.Close();
                    statusObject.status = false;
                    statusObject.message = "Get Unauth Recharge requests \n" + Errors.ErrorsString.Error002 + "\n" + e;
                    return statusObject;
                }
            }
            else
            {
                statusObject.status = false;
                statusObject.message = Errors.ErrorsString.Error001;
                conn.Close();
                return statusObject;
            }
        }
        public static Status genAppRecord(int recordID)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "UPDATE [CTS].[dbo].[PTS_AppRecord] SET [generated] = @v1 , [gen_time] = @v2 WHERE [record_id] = @v3";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    cmd.Parameters.AddWithValue("@v1", 1);
                    cmd.Parameters.AddWithValue("@v2", DateTime.Now);
                    cmd.Parameters.AddWithValue("@v3", recordID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch
                {
                    conn.Close();
                    status.status = false;
                    status.message = "App Record Generator(Update Auth)\n" + Errors.ErrorsString.Error002;
                    return status;
                }

            }
            else
            {
                status.status = false;
                status.message = Errors.ErrorsString.Error001;
                conn.Close();
                return status;
            }

        }


    }
}
