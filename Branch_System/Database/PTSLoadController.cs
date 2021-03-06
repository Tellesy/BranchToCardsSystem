﻿using MPBS.Database.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace MPBS.Database
{
    public static class PTSLoadController
    {
        public static Status<List<Objects.PTSLoad>> getBranchUnAuthLoad(bool branchFlag)
        {
            string branch_code = "";
            Status<List<Objects.PTSLoad>> statusObject = new Status<List<Objects.PTSLoad>>();
            statusObject.Object = new List<Objects.PTSLoad>();
            statusObject.status = false;


            SqlConnection conn = DBConnection.Connection();

            if (branchFlag)
            {
                var bstatus = PTSBranchController.getBranch(int.Parse(Database.Login.branch));
                if (bstatus.status)
                {
                    branch_code = bstatus.Object.Code;
                }
                else
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
                        query = @"SELECT [ID]
                                          ,[customer_ID]
                                          ,[program_code]
                                          
                                          ,[branch_code]
                                          ,[year]
                                          ,[amount]
                                          ,[inputter]
                                          ,[input_time]
                                          ,[branch_authorizer]
                                          ,[branch_auth_time]
                                          ,[HQ_authorizer]
                                          ,[HQ_auth_time]
                                          ,[generated]
                                          ,[gen_time]
                                          ,[cbs_file_gen]
                                          ,[cbs_file_gen_date]
                                          ,[from_cbl_flag]
                                          ,[exchange_rate]
                                          ,[MFlag]
                                      FROM [CTS].[dbo].[PTS_Load] where [branch_code] = '" + branch_code + "' AND branch_authorizer is NULL AND HQ_authorizer is NULL AND generated = 0";
                    }
                    else
                    {
                        query = @"SELECT [ID]
                                          ,[customer_ID]
                                          ,[program_code]
                                          
                                          ,[branch_code]
                                          ,[year]
                                          ,[amount]
                                          ,[inputter]
                                          ,[input_time]
                                          ,[branch_authorizer]
                                          ,[branch_auth_time]
                                          ,[HQ_authorizer]
                                          ,[HQ_auth_time]
                                          ,[generated]
                                          ,[gen_time]
                                          ,[cbs_file_gen]
                                          ,[cbs_file_gen_date]
                                          ,[from_cbl_flag]
                                          ,[exchange_rate]
                                          ,[MFlag]
                                      FROM [CTS].[dbo].[PTS_Load] where branch_authorizer is NULL AND HQ_authorizer is NULL AND generated = 0";
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
                            Objects.PTSLoad request = new Objects.PTSLoad();
                            if (!string.IsNullOrEmpty(reader[0].ToString()))
                                request.ID = int.Parse(reader[0].ToString());

                            if (!string.IsNullOrEmpty(reader[1].ToString()))
                                request.CustomerID = reader[1].ToString();

                            if (!string.IsNullOrEmpty(reader[2].ToString()))
                                request.ProgramCode = reader[2].ToString();

                         

                            if (!string.IsNullOrEmpty(reader[3].ToString()))
                                request.BranchCode = reader[3].ToString();

                            if (!string.IsNullOrEmpty(reader[4].ToString()))
                                request.Year = reader[4].ToString();

                            if (!string.IsNullOrEmpty(reader[5].ToString()))
                                request.Amount = int.Parse(reader[5].ToString());

                            if (!string.IsNullOrEmpty(reader[6].ToString()))
                                request.Inputter = reader[6].ToString();

                            if (!string.IsNullOrEmpty(reader[7].ToString()))
                                request.InputTime = DateTime.Parse(reader[7].ToString());

                            if (!string.IsNullOrEmpty(reader[8].ToString()))
                                request.BranchAuthorizer = reader[8].ToString();

                            if (!string.IsNullOrEmpty(reader[9].ToString()))
                                request.BranchAuthorizeTime = DateTime.Parse(reader[9].ToString());

                            if (!string.IsNullOrEmpty(reader[10].ToString()))
                                request.HQAuthorizer = reader[10].ToString();

                            if (!string.IsNullOrEmpty(reader[11].ToString()))
                                request.HQAuthorizeTime = DateTime.Parse(reader[11].ToString());

                            if (!string.IsNullOrEmpty(reader[12].ToString()))
                                request.Generated = Boolean.Parse(reader[12].ToString());

                            if (!string.IsNullOrEmpty(reader[13].ToString()))
                                request.GenTime = DateTime.Parse(reader[13].ToString());

                            if (!string.IsNullOrEmpty(reader[14].ToString()))
                                request.CBSFileGen = Boolean.Parse(reader[14].ToString());

                            if (!string.IsNullOrEmpty(reader[15].ToString()))
                                request.CBSFileGenTime = DateTime.Parse(reader[15].ToString());



                            if (!string.IsNullOrEmpty(reader[16].ToString()))
                                request.FromCBLFlag = Boolean.Parse(reader[16].ToString());

                            if (!string.IsNullOrEmpty(reader[17].ToString()))
                                request.ExchangeRate = decimal.Parse(reader[17].ToString());

                            //if (!string.IsNullOrEmpty(reader[18].ToString()))
                            //    request.f = DateTime.Parse(reader[18].ToString());


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
                    statusObject.message = "Get Unauth PTS Load requests \n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status<List<Objects.PTSLoad>> getAllLoadPerBranchAndDate(bool branchFlag, string fromDate, string toDate)
        {
            string branch_code = "";
            Status<List<Objects.PTSLoad>> statusObject = new Status<List<Objects.PTSLoad>>();
            statusObject.Object = new List<Objects.PTSLoad>();
            statusObject.status = false;


            SqlConnection conn = DBConnection.Connection();

            if (branchFlag)
            {
                var bstatus = PTSBranchController.getBranch(int.Parse(Database.Login.branch));
                if (bstatus.status)
                {
                    branch_code = bstatus.Object.Code;
                }
                else
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
                        query = string.Format(@"SELECT [ID]
                                          ,[customer_ID]
                                          ,[program_code]
                                          
                                          ,[branch_code]
                                          ,[year]
                                          ,[amount]
                                          ,[inputter]
                                          ,[input_time]
                                          ,[branch_authorizer]
                                          ,[branch_auth_time]
                                          ,[HQ_authorizer]
                                          ,[HQ_auth_time]
                                          ,[generated]
                                          ,[gen_time]
                                          ,[cbs_file_gen]
                                          ,[cbs_file_gen_date]
                                          ,[from_cbl_flag]
                                          ,[exchange_rate]
                                          ,[MFlag]
                                      FROM [CTS].[dbo].[PTS_Load] where [branch_code] = '{0}' AND [input_time] > '{1} 00:00:00' AND [input_time]  <= '{2} 23:59:59'", branch_code,fromDate,toDate);
                    }
                    else
                    {
                         query = string.Format(@"SELECT [ID]
                                          ,[customer_ID]
                                          ,[program_code]
                                          
                                          ,[branch_code]
                                          ,[year]
                                          ,[amount]
                                          ,[inputter]
                                          ,[input_time]
                                          ,[branch_authorizer]
                                          ,[branch_auth_time]
                                          ,[HQ_authorizer]
                                          ,[HQ_auth_time]
                                          ,[generated]
                                          ,[gen_time]
                                          ,[cbs_file_gen]
                                          ,[cbs_file_gen_date]
                                          ,[from_cbl_flag]
                                          ,[exchange_rate]
                                          ,[MFlag]
                                      FROM [CTS].[dbo].[PTS_Load] where [input_time] > '{0} 00:00:00' AND [input_time]  <= '{1} 23:59:59'", fromDate, toDate);
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
                            Objects.PTSLoad request = new Objects.PTSLoad();
                            if (!string.IsNullOrEmpty(reader[0].ToString()))
                                request.ID = int.Parse(reader[0].ToString());

                            if (!string.IsNullOrEmpty(reader[1].ToString()))
                                request.CustomerID = reader[1].ToString();

                            if (!string.IsNullOrEmpty(reader[2].ToString()))
                                request.ProgramCode = reader[2].ToString();



                            if (!string.IsNullOrEmpty(reader[3].ToString()))
                                request.BranchCode = reader[3].ToString();

                            if (!string.IsNullOrEmpty(reader[4].ToString()))
                                request.Year = reader[4].ToString();

                            if (!string.IsNullOrEmpty(reader[5].ToString()))
                                request.Amount = int.Parse(reader[5].ToString());

                            if (!string.IsNullOrEmpty(reader[6].ToString()))
                                request.Inputter = reader[6].ToString();

                            if (!string.IsNullOrEmpty(reader[7].ToString()))
                                request.InputTime = DateTime.Parse(reader[7].ToString());

                            if (!string.IsNullOrEmpty(reader[8].ToString()))
                                request.BranchAuthorizer = reader[8].ToString();

                            if (!string.IsNullOrEmpty(reader[9].ToString()))
                                request.BranchAuthorizeTime = DateTime.Parse(reader[9].ToString());

                            if (!string.IsNullOrEmpty(reader[10].ToString()))
                                request.HQAuthorizer = reader[10].ToString();

                            if (!string.IsNullOrEmpty(reader[11].ToString()))
                                request.HQAuthorizeTime = DateTime.Parse(reader[11].ToString());

                            if (!string.IsNullOrEmpty(reader[12].ToString()))
                                request.Generated = Boolean.Parse(reader[12].ToString());

                            if (!string.IsNullOrEmpty(reader[13].ToString()))
                                request.GenTime = DateTime.Parse(reader[13].ToString());

                            if (!string.IsNullOrEmpty(reader[14].ToString()))
                                request.CBSFileGen = Boolean.Parse(reader[14].ToString());

                            if (!string.IsNullOrEmpty(reader[15].ToString()))
                                request.CBSFileGenTime = DateTime.Parse(reader[15].ToString());



                            if (!string.IsNullOrEmpty(reader[16].ToString()))
                                request.FromCBLFlag = Boolean.Parse(reader[16].ToString());

                            if (!string.IsNullOrEmpty(reader[17].ToString()))
                                request.ExchangeRate = decimal.Parse(reader[17].ToString());

                            //if (!string.IsNullOrEmpty(reader[18].ToString()))
                            //    request.f = DateTime.Parse(reader[18].ToString());


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
                    statusObject.message = "Get Unauth PTS Load requests \n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status deleteLoadRecord(int record_id)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = DBConnection.Connection();

            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = @"Delete [dbo].[PTS_Load] where [ID] = @v1";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@v1", record_id);


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
                    status.message = @"Delete to PTS Load " + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status<List<Objects.PTSLoad>> getBranchUnAuthLoad(string customerID, string programCode)
        {
           
            Status<List<Objects.PTSLoad>> statusObject = new Status<List<Objects.PTSLoad>>();
            statusObject.Object = new List<Objects.PTSLoad>();
            statusObject.status = false;


            SqlConnection conn = DBConnection.Connection();

          

            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {


                try
                {
                 

                    string query = @"SELECT [ID]
                                        ,[customer_ID]
                                        ,[program_code]
                            
                                        ,[branch_code]
                                        ,[year]
                                        ,[amount]
                                        ,[inputter]
                                        ,[input_time]
                                        ,[branch_authorizer]
                                        ,[branch_auth_time]
                                        ,[HQ_authorizer]
                                        ,[HQ_auth_time]
                                        ,[generated]
                                        ,[gen_time]
                                    FROM [CTS].[dbo].[PTS_Load] where branch_authorizer is NULL AND HQ_authorizer is NULL AND generated = 0  AND [customer_ID] = '"+customerID+ "' AND [program_code] ='"+programCode+"'";
                    


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
                            Objects.PTSLoad request = new Objects.PTSLoad();
                            if (!string.IsNullOrEmpty(reader[0].ToString()))
                                request.ID = int.Parse(reader[0].ToString());

                            if (!string.IsNullOrEmpty(reader[1].ToString()))
                                request.CustomerID = reader[1].ToString();

                            if (!string.IsNullOrEmpty(reader[2].ToString()))
                                request.ProgramCode = reader[2].ToString();

                           

                            if (!string.IsNullOrEmpty(reader[3].ToString()))
                                request.BranchCode = reader[3].ToString();

                            if (!string.IsNullOrEmpty(reader[4].ToString()))
                                request.Year = reader[4].ToString();

                            if (!string.IsNullOrEmpty(reader[5].ToString()))
                                request.Amount = int.Parse(reader[5].ToString());

                            if (!string.IsNullOrEmpty(reader[6].ToString()))
                                request.Inputter = reader[6].ToString();

                            if (!string.IsNullOrEmpty(reader[7].ToString()))
                                request.InputTime = DateTime.Parse(reader[7].ToString());

                            if (!string.IsNullOrEmpty(reader[8].ToString()))
                                request.BranchAuthorizer = reader[8].ToString();

                            if (!string.IsNullOrEmpty(reader[9].ToString()))
                                request.BranchAuthorizeTime = DateTime.Parse(reader[9].ToString());

                            if (!string.IsNullOrEmpty(reader[10].ToString()))
                                request.HQAuthorizer = reader[10].ToString();

                            if (!string.IsNullOrEmpty(reader[11].ToString()))
                                request.HQAuthorizeTime = DateTime.Parse(reader[11].ToString());

                            if (!string.IsNullOrEmpty(reader[12].ToString()))
                                request.Generated = Boolean.Parse(reader[12].ToString());

                            if (!string.IsNullOrEmpty(reader[13].ToString()))
                                request.GenTime = DateTime.Parse(reader[13].ToString());

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
                    statusObject.message = "Get Unauth PTS Load requests \n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status addLoadRecord(PTSLoad loadRecord)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = DBConnection.Connection();

            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = @"INSERT INTO [dbo].[PTS_Load]
                               ([customer_ID]
                               ,[program_code]
           
                               ,[branch_code]
                               ,[year]
                               ,[amount]
                               ,[inputter])
                    VALUES
                   (@v1
                   ,@v2

                   ,@v4
                   ,@v5
                   ,@v6
                   ,@v7)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@v1", loadRecord.CustomerID);
                    cmd.Parameters.AddWithValue("@v2", loadRecord.ProgramCode);

                    cmd.Parameters.AddWithValue("@v4", loadRecord.BranchCode);
                    cmd.Parameters.AddWithValue("@v5", loadRecord.Year);
               
                    cmd.Parameters.AddWithValue("@v6", loadRecord.Amount);
                    cmd.Parameters.AddWithValue("@v7", loadRecord.Inputter);


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
                    status.message = "Add to PTS Load\n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status<List<Objects.PTSLoad>> getTotalLoadAuthorizedRecordsForClient(string customerID, string programCode, string year)
        {
            
            Status<List<Objects.PTSLoad>> statusObject = new Status<List<Objects.PTSLoad>>();
            statusObject.Object = new List<Objects.PTSLoad>();
            statusObject.status = false;


            SqlConnection conn = DBConnection.Connection();



            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {


                try
                {


                    string query = @"SELECT [ID]
                                        ,[customer_ID]
                                        ,[program_code]
                            
                                        ,[branch_code]
                                        ,[year]
                                        ,[amount]
                                        ,[inputter]
                                        ,[input_time]
                                        ,[branch_authorizer]
                                        ,[branch_auth_time]
                                        ,[HQ_authorizer]
                                        ,[HQ_auth_time]
                                        ,[generated]
                                        ,[gen_time]
                                    FROM [CTS].[dbo].[PTS_Load] where branch_authorizer is not NULL AND HQ_authorizer is not NULL AND [customer_ID] = '" + customerID + "' AND [program_code] ='" + programCode + "' AND [year] = '" + year +"'";



                    SqlCommand cmd = new SqlCommand(query, conn);



                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        if (!reader.HasRows)
                        {
                            statusObject.status = true;
                            statusObject.message = "لا يوجد سجلات تحتاج الى تخويل";
                            return statusObject;

                        }

                        while (reader.Read())
                        {
                            Objects.PTSLoad request = new Objects.PTSLoad();
                            if (!string.IsNullOrEmpty(reader[0].ToString()))
                                request.ID = int.Parse(reader[0].ToString());

                            if (!string.IsNullOrEmpty(reader[1].ToString()))
                                request.CustomerID = reader[1].ToString();

                            if (!string.IsNullOrEmpty(reader[2].ToString()))
                                request.ProgramCode = reader[2].ToString();



                            if (!string.IsNullOrEmpty(reader[3].ToString()))
                                request.BranchCode = reader[3].ToString();

                            if (!string.IsNullOrEmpty(reader[4].ToString()))
                                request.Year = reader[4].ToString();

                            if (!string.IsNullOrEmpty(reader[5].ToString()))
                                request.Amount = int.Parse(reader[5].ToString());

                            if (!string.IsNullOrEmpty(reader[6].ToString()))
                                request.Inputter = reader[6].ToString();

                            if (!string.IsNullOrEmpty(reader[7].ToString()))
                                request.InputTime = DateTime.Parse(reader[7].ToString());

                            if (!string.IsNullOrEmpty(reader[8].ToString()))
                                request.BranchAuthorizer = reader[8].ToString();

                            if (!string.IsNullOrEmpty(reader[9].ToString()))
                                request.BranchAuthorizeTime = DateTime.Parse(reader[9].ToString());

                            if (!string.IsNullOrEmpty(reader[10].ToString()))
                                request.HQAuthorizer = reader[10].ToString();

                            if (!string.IsNullOrEmpty(reader[11].ToString()))
                                request.HQAuthorizeTime = DateTime.Parse(reader[11].ToString());

                            if (!string.IsNullOrEmpty(reader[12].ToString()))
                                request.Generated = Boolean.Parse(reader[12].ToString());

                            if (!string.IsNullOrEmpty(reader[13].ToString()))
                                request.GenTime = DateTime.Parse(reader[13].ToString());

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
                    statusObject.message = "Get Total Load Authorized Records For Client \n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status<List<Objects.PTSLoad>> getTotalLoadAuthorizedRecordsForClientPerBranchAuth(string customerID, string programCode, string year)
        {

            Status<List<Objects.PTSLoad>> statusObject = new Status<List<Objects.PTSLoad>>();
            statusObject.Object = new List<Objects.PTSLoad>();
            statusObject.status = false;


            SqlConnection conn = DBConnection.Connection();



            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {


                try
                {


                    string query = @"SELECT [ID]
                                        ,[customer_ID]
                                        ,[program_code]
                            
                                        ,[branch_code]
                                        ,[year]
                                        ,[amount]
                                        ,[inputter]
                                        ,[input_time]
                                        ,[branch_authorizer]
                                        ,[branch_auth_time]
                                        ,[HQ_authorizer]
                                        ,[HQ_auth_time]
                                        ,[generated]
                                        ,[gen_time]
                                    FROM [CTS].[dbo].[PTS_Load] where branch_authorizer is not NULL AND [customer_ID] = '" + customerID + "' AND [program_code] ='" + programCode + "' AND [year] = '" + year + "'";



                    SqlCommand cmd = new SqlCommand(query, conn);



                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        if (!reader.HasRows)
                        {
                            statusObject.status = true;
                            statusObject.message = "لا يوجد سجلات تحتاج الى تخويل";
                            return statusObject;

                        }

                        while (reader.Read())
                        {
                            Objects.PTSLoad request = new Objects.PTSLoad();
                            if (!string.IsNullOrEmpty(reader[0].ToString()))
                                request.ID = int.Parse(reader[0].ToString());

                            if (!string.IsNullOrEmpty(reader[1].ToString()))
                                request.CustomerID = reader[1].ToString();

                            if (!string.IsNullOrEmpty(reader[2].ToString()))
                                request.ProgramCode = reader[2].ToString();



                            if (!string.IsNullOrEmpty(reader[3].ToString()))
                                request.BranchCode = reader[3].ToString();

                            if (!string.IsNullOrEmpty(reader[4].ToString()))
                                request.Year = reader[4].ToString();

                            if (!string.IsNullOrEmpty(reader[5].ToString()))
                                request.Amount = int.Parse(reader[5].ToString());

                            if (!string.IsNullOrEmpty(reader[6].ToString()))
                                request.Inputter = reader[6].ToString();

                            if (!string.IsNullOrEmpty(reader[7].ToString()))
                                request.InputTime = DateTime.Parse(reader[7].ToString());

                            if (!string.IsNullOrEmpty(reader[8].ToString()))
                                request.BranchAuthorizer = reader[8].ToString();

                            if (!string.IsNullOrEmpty(reader[9].ToString()))
                                request.BranchAuthorizeTime = DateTime.Parse(reader[9].ToString());

                            if (!string.IsNullOrEmpty(reader[10].ToString()))
                                request.HQAuthorizer = reader[10].ToString();

                            if (!string.IsNullOrEmpty(reader[11].ToString()))
                                request.HQAuthorizeTime = DateTime.Parse(reader[11].ToString());

                            if (!string.IsNullOrEmpty(reader[12].ToString()))
                                request.Generated = Boolean.Parse(reader[12].ToString());

                            if (!string.IsNullOrEmpty(reader[13].ToString()))
                                request.GenTime = DateTime.Parse(reader[13].ToString());

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
                    statusObject.message = "Get Total Load Authorized Records For Client \n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status<List<Objects.PTSLoad>> getTotalLoadRequestByYear(string customerID, string programCode, string year)
        {

            Status<List<Objects.PTSLoad>> statusObject = new Status<List<Objects.PTSLoad>>();
            statusObject.Object = new List<Objects.PTSLoad>();
            statusObject.status = false;


            SqlConnection conn = DBConnection.Connection();



            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {


                try
                {


                    string query = @"SELECT [ID]
                                        ,[customer_ID]
                                        ,[program_code]
                            
                                        ,[branch_code]
                                        ,[year]
                                        ,[amount]
                                        ,[inputter]
                                        ,[input_time]
                                        ,[branch_authorizer]
                                        ,[branch_auth_time]
                                        ,[HQ_authorizer]
                                        ,[HQ_auth_time]
                                        ,[generated]
                                        ,[gen_time]
                                    FROM [CTS].[dbo].[PTS_Load] where   [customer_ID] = '" + customerID + "' AND [program_code] ='" + programCode + "' AND [year] = '" + year + "'";



                    SqlCommand cmd = new SqlCommand(query, conn);



                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        if (!reader.HasRows)
                        {
                            statusObject.status = true;
                            statusObject.message = "لا يوجد سجلات تحتاج الى تخويل";
                            return statusObject;

                        }

                        while (reader.Read())
                        {
                            Objects.PTSLoad request = new Objects.PTSLoad();
                            if (!string.IsNullOrEmpty(reader[0].ToString()))
                                request.ID = int.Parse(reader[0].ToString());

                            if (!string.IsNullOrEmpty(reader[1].ToString()))
                                request.CustomerID = reader[1].ToString();

                            if (!string.IsNullOrEmpty(reader[2].ToString()))
                                request.ProgramCode = reader[2].ToString();



                            if (!string.IsNullOrEmpty(reader[3].ToString()))
                                request.BranchCode = reader[3].ToString();

                            if (!string.IsNullOrEmpty(reader[4].ToString()))
                                request.Year = reader[4].ToString();

                            if (!string.IsNullOrEmpty(reader[5].ToString()))
                                request.Amount = int.Parse(reader[5].ToString());

                            if (!string.IsNullOrEmpty(reader[6].ToString()))
                                request.Inputter = reader[6].ToString();

                            if (!string.IsNullOrEmpty(reader[7].ToString()))
                                request.InputTime = DateTime.Parse(reader[7].ToString());

                            if (!string.IsNullOrEmpty(reader[8].ToString()))
                                request.BranchAuthorizer = reader[8].ToString();

                            if (!string.IsNullOrEmpty(reader[9].ToString()))
                                request.BranchAuthorizeTime = DateTime.Parse(reader[9].ToString());

                            if (!string.IsNullOrEmpty(reader[10].ToString()))
                                request.HQAuthorizer = reader[10].ToString();

                            if (!string.IsNullOrEmpty(reader[11].ToString()))
                                request.HQAuthorizeTime = DateTime.Parse(reader[11].ToString());

                            if (!string.IsNullOrEmpty(reader[12].ToString()))
                                request.Generated = Boolean.Parse(reader[12].ToString());

                            if (!string.IsNullOrEmpty(reader[13].ToString()))
                                request.GenTime = DateTime.Parse(reader[13].ToString());

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
                    statusObject.message = "Get Total Load Authorized Records For Client \n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status<List<Objects.PTSLoad>> getFullyAuthorizedLoadRequests()
        {

            Status<List<Objects.PTSLoad>> statusObject = new Status<List<Objects.PTSLoad>>();
            statusObject.Object = new List<Objects.PTSLoad>();
            statusObject.status = false;


            SqlConnection conn = DBConnection.Connection();



            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {


                try
                {

                    string query = @"SELECT  [ID],[customer_ID] ,[program_code],[branch_code],[year],[amount],[inputter],[input_time] ,[branch_authorizer],[branch_auth_time] ,[HQ_authorizer] ,[HQ_auth_time] ,[generated] ,[gen_time] FROM [CTS].[dbo].[PTS_Load] where branch_authorizer is not NULL AND HQ_authorizer is not NULL AND generated = 0 AND MFlag = 0";



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
                            Objects.PTSLoad request = new Objects.PTSLoad();
                            if (!string.IsNullOrEmpty(reader[0].ToString()))
                                request.ID = int.Parse(reader[0].ToString());

                            if (!string.IsNullOrEmpty(reader[1].ToString()))
                                request.CustomerID = reader[1].ToString();

                            if (!string.IsNullOrEmpty(reader[2].ToString()))
                                request.ProgramCode = reader[2].ToString();

                            if (!string.IsNullOrEmpty(reader[3].ToString()))
                                request.BranchCode = reader[3].ToString();

                            if (!string.IsNullOrEmpty(reader[4].ToString()))
                                request.Year = reader[4].ToString();

                            if (!string.IsNullOrEmpty(reader[5].ToString()))
                                request.Amount = int.Parse(reader[5].ToString());

                            if (!string.IsNullOrEmpty(reader[6].ToString()))
                                request.Inputter = reader[6].ToString();

                            if (!string.IsNullOrEmpty(reader[7].ToString()))
                                request.InputTime = DateTime.Parse(reader[7].ToString());

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
        public static Status authBranchLoadRequest(int recordID)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "UPDATE [CTS].[dbo].[PTS_Load] SET [branch_authorizer] = @v1 , [branch_auth_time] = @v2 WHERE [Id] = @v3";
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
                catch(Exception e)
                {
                    conn.Close();
                    status.status = false;
                    status.message = "Load Record Branch Auth (Update Auth)\n" + Errors.ErrorsString.Error002 + "\n" + e.Message.ToString();
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

        public static Status authHQLoadRequest(int recordID)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "UPDATE [CTS].[dbo].[PTS_Load] SET [HQ_authorizer] = @v1 , [HQ_auth_time] = @v2 WHERE [Id] = @v3";
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
                    status.message = "Load Record HQ Auth (Update Auth)\n" + Errors.ErrorsString.Error002;
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

        public static Status<List<Objects.PTSLoad>> getHQUnAuthLoad()
        {
            
            Status<List<Objects.PTSLoad>> statusObject = new Status<List<Objects.PTSLoad>>();
            statusObject.Object = new List<Objects.PTSLoad>();
            statusObject.status = false;


            SqlConnection conn = DBConnection.Connection();

         

            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {


                try
                {
                
                    string query = @"SELECT [ID]
                                        ,[customer_ID]
                                        ,[program_code]
                                          
                                        ,[branch_code]
                                        ,[year]
                                        ,[amount]
                                        ,[inputter]
                                        ,[input_time]
                                        ,[branch_authorizer]
                                        ,[branch_auth_time]
                                        ,[HQ_authorizer]
                                        ,[HQ_auth_time]
                                        ,[generated]
                                        ,[gen_time]
                                    FROM [CTS].[dbo].[PTS_Load] where branch_authorizer is not NULL AND HQ_authorizer is NULL AND generated = 0";
                    


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
                            Objects.PTSLoad request = new Objects.PTSLoad();
                            if (!string.IsNullOrEmpty(reader[0].ToString()))
                                request.ID = int.Parse(reader[0].ToString());

                            if (!string.IsNullOrEmpty(reader[1].ToString()))
                                request.CustomerID = reader[1].ToString();

                            if (!string.IsNullOrEmpty(reader[2].ToString()))
                                request.ProgramCode = reader[2].ToString();



                            if (!string.IsNullOrEmpty(reader[3].ToString()))
                                request.BranchCode = reader[3].ToString();

                            if (!string.IsNullOrEmpty(reader[4].ToString()))
                                request.Year = reader[4].ToString();

                            if (!string.IsNullOrEmpty(reader[5].ToString()))
                                request.Amount = int.Parse(reader[5].ToString());

                            if (!string.IsNullOrEmpty(reader[6].ToString()))
                                request.Inputter = reader[6].ToString();

                            if (!string.IsNullOrEmpty(reader[7].ToString()))
                                request.InputTime = DateTime.Parse(reader[7].ToString());

                            if (!string.IsNullOrEmpty(reader[8].ToString()))
                                request.BranchAuthorizer = reader[8].ToString();

                            if (!string.IsNullOrEmpty(reader[9].ToString()))
                                request.BranchAuthorizeTime = DateTime.Parse(reader[9].ToString());

                            if (!string.IsNullOrEmpty(reader[10].ToString()))
                                request.HQAuthorizer = reader[10].ToString();

                            if (!string.IsNullOrEmpty(reader[11].ToString()))
                                request.HQAuthorizeTime = DateTime.Parse(reader[11].ToString());

                            if (!string.IsNullOrEmpty(reader[12].ToString()))
                                request.Generated = Boolean.Parse(reader[12].ToString());

                            if (!string.IsNullOrEmpty(reader[13].ToString()))
                                request.GenTime = DateTime.Parse(reader[13].ToString());

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
                    statusObject.message = "Get Unauth PTS Load requests \n" + Errors.ErrorsString.Error002 + "\n" + e;
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


        public static Status addLoadRecordFromCBLReport(PTSLoad loadRecord)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = DBConnection.Connection();

            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = @"INSERT INTO [dbo].[PTS_Load]
                               ([customer_ID]
                               ,[program_code]
                               ,[branch_code]
                               ,[year]
                               ,[amount]
                               ,[inputter]
                               ,[input_time]
                               ,[from_cbl_flag]
                               ,[exchange_rate])
                    VALUES
                   (@v1
                   ,@v2
                   ,@v4
                   ,@v5
                   ,@v6
                   ,@v7
                   ,@v8
                   ,@v9
                   ,@v10)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@v1", loadRecord.CustomerID);
                    cmd.Parameters.AddWithValue("@v2", loadRecord.ProgramCode);

                    cmd.Parameters.AddWithValue("@v4", loadRecord.BranchCode);
                    cmd.Parameters.AddWithValue("@v5", loadRecord.Year);

                    cmd.Parameters.AddWithValue("@v6", loadRecord.Amount);
                    cmd.Parameters.AddWithValue("@v7", loadRecord.Inputter);
                    cmd.Parameters.AddWithValue("@v8", loadRecord.InputTime);
                    cmd.Parameters.AddWithValue("@v9", 1);
                    cmd.Parameters.AddWithValue("@v10", loadRecord.ExchangeRate.ToString());


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
                    status.message = "Add to PTS Load\n" + Errors.ErrorsString.Error002 + "\n" + e;
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
        public static Status<List<Objects.PTSLoad>> getCBSLoadRecordByCustomerIDAndDate(string customerID,string date, int amount)
        {

            Status<List<Objects.PTSLoad>> statusObject = new Status<List<Objects.PTSLoad>>();
            statusObject.Object = new List<Objects.PTSLoad>();
            statusObject.status = false;


            SqlConnection conn = DBConnection.Connection();



            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {


                try
                {

                    string query = @"SELECT [ID]
                                        ,[customer_ID]
                                        ,[program_code]
                                        ,[branch_code]
                                        ,[year]
                                        ,[amount]
                                        ,[inputter]
                                        ,[input_time]
                                        ,[branch_authorizer]
                                        ,[branch_auth_time]
                                        ,[HQ_authorizer]
                                        ,[HQ_auth_time]
                                        ,[generated]
                                        ,[gen_time]
                                        ,[cbs_file_gen]
                                        ,[cbs_file_gen_date]
                                        ,[from_cbl_flag]
                                        ,[exchange_rate]
                                    FROM [CTS].[dbo].[PTS_Load] where [customer_ID] = '" + customerID + "' AND  CAST([input_time] AS DATE) = '" + date + "' AND [amount] = "+amount;



                    SqlCommand cmd = new SqlCommand(query, conn);



                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        if (!reader.HasRows)
                        {
                            statusObject.status = false;
                            statusObject.message = "لا يوجد سجلات جديدة";
                            return statusObject;

                        }

                        while (reader.Read())
                        {
                            Objects.PTSLoad request = new Objects.PTSLoad();
                            if (!string.IsNullOrEmpty(reader[0].ToString()))
                                request.ID = int.Parse(reader[0].ToString());

                            if (!string.IsNullOrEmpty(reader[1].ToString()))
                                request.CustomerID = reader[1].ToString();

                            if (!string.IsNullOrEmpty(reader[2].ToString()))
                                request.ProgramCode = reader[2].ToString();



                            if (!string.IsNullOrEmpty(reader[3].ToString()))
                                request.BranchCode = reader[3].ToString();

                            if (!string.IsNullOrEmpty(reader[4].ToString()))
                                request.Year = reader[4].ToString();

                            if (!string.IsNullOrEmpty(reader[5].ToString()))
                                request.Amount = int.Parse(reader[5].ToString());

                            if (!string.IsNullOrEmpty(reader[6].ToString()))
                                request.Inputter = reader[6].ToString();

                            if (!string.IsNullOrEmpty(reader[7].ToString()))
                                request.InputTime = DateTime.Parse(reader[7].ToString());

                            if (!string.IsNullOrEmpty(reader[8].ToString()))
                                request.BranchAuthorizer = reader[8].ToString();

                            if (!string.IsNullOrEmpty(reader[9].ToString()))
                                request.BranchAuthorizeTime = DateTime.Parse(reader[9].ToString());

                            if (!string.IsNullOrEmpty(reader[10].ToString()))
                                request.HQAuthorizer = reader[10].ToString();

                            if (!string.IsNullOrEmpty(reader[11].ToString()))
                                request.HQAuthorizeTime = DateTime.Parse(reader[11].ToString());

                            if (!string.IsNullOrEmpty(reader[12].ToString()))
                                request.Generated = Boolean.Parse(reader[12].ToString());

                            if (!string.IsNullOrEmpty(reader[13].ToString()))
                                request.GenTime = DateTime.Parse(reader[13].ToString());

                            if (!string.IsNullOrEmpty(reader[14].ToString()))
                                request.CBSFileGen = Boolean.Parse(reader[14].ToString());

                            if (!string.IsNullOrEmpty(reader[15].ToString()))
                                request.CBSFileGenTime = DateTime.Parse(reader[15].ToString());

                            if (!string.IsNullOrEmpty(reader[16].ToString()))
                                request.FromCBLFlag = Boolean.Parse(reader[16].ToString());

                            if (!string.IsNullOrEmpty(reader[17].ToString()))
                                request.ExchangeRate = decimal.Parse(reader[17].ToString());

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
                    statusObject.message = "Get Unauth PTS Load requests \n" + Errors.ErrorsString.Error002 + "\n" + e;
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
        /// <summary>
        /// Get all the Load Reocrds to upload to CBS
        /// </summary>
        /// <returns></returns>
        public static Status<List<Objects.PTSLoad>> getCBSLoadRecords(string branch_code)
        {

            Status<List<Objects.PTSLoad>> statusObject = new Status<List<Objects.PTSLoad>>();
            statusObject.Object = new List<Objects.PTSLoad>();
            statusObject.status = false;


            SqlConnection conn = DBConnection.Connection();



            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {


                try
                {

                    string query = @"SELECT [ID]
                                        ,[customer_ID]
                                        ,[program_code]
                                        ,[branch_code]
                                        ,[year]
                                        ,[amount]
                                        ,[inputter]
                                        ,[input_time]
                                        ,[branch_authorizer]
                                        ,[branch_auth_time]
                                        ,[HQ_authorizer]
                                        ,[HQ_auth_time]
                                        ,[generated]
                                        ,[gen_time]
                                        ,[cbs_file_gen]
                                        ,[cbs_file_gen_date]
                                        ,[from_cbl_flag]
                                        ,[exchange_rate]
                                    FROM [CTS].[dbo].[PTS_Load] where from_cbl_flag = 1 AND cbs_file_gen = 0 AND [branch_code] = '" + branch_code +"'";



                    SqlCommand cmd = new SqlCommand(query, conn);



                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        if (!reader.HasRows)
                        {
                            statusObject.status = false;
                            statusObject.message = "لا يوجد سجلات جديدة";
                            return statusObject;

                        }

                        while (reader.Read())
                        {
                            Objects.PTSLoad request = new Objects.PTSLoad();
                            if (!string.IsNullOrEmpty(reader[0].ToString()))
                                request.ID = int.Parse(reader[0].ToString());

                            if (!string.IsNullOrEmpty(reader[1].ToString()))
                                request.CustomerID = reader[1].ToString();

                            if (!string.IsNullOrEmpty(reader[2].ToString()))
                                request.ProgramCode = reader[2].ToString();



                            if (!string.IsNullOrEmpty(reader[3].ToString()))
                                request.BranchCode = reader[3].ToString();

                            if (!string.IsNullOrEmpty(reader[4].ToString()))
                                request.Year = reader[4].ToString();

                            if (!string.IsNullOrEmpty(reader[5].ToString()))
                                request.Amount = int.Parse(reader[5].ToString());

                            if (!string.IsNullOrEmpty(reader[6].ToString()))
                                request.Inputter = reader[6].ToString();

                            if (!string.IsNullOrEmpty(reader[7].ToString()))
                                request.InputTime = DateTime.Parse(reader[7].ToString());

                            if (!string.IsNullOrEmpty(reader[8].ToString()))
                                request.BranchAuthorizer = reader[8].ToString();

                            if (!string.IsNullOrEmpty(reader[9].ToString()))
                                request.BranchAuthorizeTime = DateTime.Parse(reader[9].ToString());

                            if (!string.IsNullOrEmpty(reader[10].ToString()))
                                request.HQAuthorizer = reader[10].ToString();

                            if (!string.IsNullOrEmpty(reader[11].ToString()))
                                request.HQAuthorizeTime = DateTime.Parse(reader[11].ToString());

                            if (!string.IsNullOrEmpty(reader[12].ToString()))
                                request.Generated = Boolean.Parse(reader[12].ToString());

                            if (!string.IsNullOrEmpty(reader[13].ToString()))
                                request.GenTime = DateTime.Parse(reader[13].ToString());

                            if (!string.IsNullOrEmpty(reader[14].ToString()))
                                request.CBSFileGen = Boolean.Parse(reader[14].ToString());

                            if (!string.IsNullOrEmpty(reader[15].ToString()))
                                request.CBSFileGenTime = DateTime.Parse(reader[15].ToString());

                            if (!string.IsNullOrEmpty(reader[16].ToString()))
                                request.FromCBLFlag = Boolean.Parse(reader[16].ToString());

                            if (!string.IsNullOrEmpty(reader[17].ToString()))
                                request.ExchangeRate =decimal.Parse(reader[17].ToString());

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
                    statusObject.message = "Get Unauth PTS Load requests \n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status genCBSLoadRecords(int recordID)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "UPDATE [CTS].[dbo].[PTS_Load] SET [cbs_file_gen] = @v1 , [cbs_file_gen_date] = @v2 WHERE [ID] = @v3";
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
                    status.message = "Load CBS File generator(Update Auth)\n" + Errors.ErrorsString.Error002;
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

        public static Status genLoad(int recordID)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = Database.DBConnection.Connection();
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "UPDATE [CTS].[dbo].[PTS_Load] SET [generated] = @v1 , [gen_time] = @v2 WHERE [ID] = @v3";
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
                    status.message = "Load Generator(Update Auth)\n" + Errors.ErrorsString.Error002;
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
