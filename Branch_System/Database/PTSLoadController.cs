using MPBS.Database.Objects;
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
                var bstatus = PTSBranchController.getBranche(int.Parse(Database.Login.branch));
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
                                          ,[wallet_number]
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
                                      FROM [CTS].[dbo].[PTS_Load] where [branch_code] = '" + branch_code + "' AND branch_authorizer is NULL AND HQ_authorizer is NULL AND generated = 0";
                    }
                    else
                    {
                        query = @"SELECT [ID]
                                          ,[customer_ID]
                                          ,[program_code]
                                          ,[wallet_number]
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
                                request.WalletNumber = reader[3].ToString();

                            if (!string.IsNullOrEmpty(reader[4].ToString()))
                                request.BranchCode = reader[4].ToString();

                            if (!string.IsNullOrEmpty(reader[5].ToString()))
                                request.Year = reader[5].ToString();

                            if (!string.IsNullOrEmpty(reader[6].ToString()))
                                request.Amount = int.Parse(reader[6].ToString());

                            if (!string.IsNullOrEmpty(reader[7].ToString()))
                                request.Inputter = reader[7].ToString();

                            if (!string.IsNullOrEmpty(reader[8].ToString()))
                                request.InputTime = DateTime.Parse(reader[8].ToString());

                            if (!string.IsNullOrEmpty(reader[9].ToString()))
                                request.BranchAuthorizer = reader[9].ToString();

                            if (!string.IsNullOrEmpty(reader[10].ToString()))
                                request.BranchAuthorizeTime = DateTime.Parse(reader[10].ToString());

                            if (!string.IsNullOrEmpty(reader[11].ToString()))
                                request.HQAuthorizer = reader[11].ToString();

                            if (!string.IsNullOrEmpty(reader[12].ToString()))
                                request.HQAuthorizeTime = DateTime.Parse(reader[12].ToString());

                            if (!string.IsNullOrEmpty(reader[13].ToString()))
                                request.Generated = Boolean.Parse(reader[13].ToString());

                            if (!string.IsNullOrEmpty(reader[14].ToString()))
                                request.GenTime = DateTime.Parse(reader[14].ToString());

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

        public static Status<List<Objects.PTSLoad>> getBranchUnAuthLoad(string customerID, string programCode)
        {
            string branch_code = "";
            Status<List<Objects.PTSLoad>> statusObject = new Status<List<Objects.PTSLoad>>();
            statusObject.Object = new List<Objects.PTSLoad>();
            statusObject.status = false;


            SqlConnection conn = DBConnection.Connection();

          

            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {


                try
                {
                    string query = "";

                  
                    
                    query = @"SELECT [ID]
                                        ,[customer_ID]
                                        ,[program_code]
                                        ,[wallet_number]
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
                                    FROM [CTS].[dbo].[PTS_Load] where branch_authorizer is NULL AND HQ_authorizer is NULL AND generated = 0 AND [customer_ID] = '"+customerID+ "' AND [program_code] ='"+programCode+"'";
                    


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
                                request.WalletNumber = reader[3].ToString();

                            if (!string.IsNullOrEmpty(reader[4].ToString()))
                                request.BranchCode = reader[4].ToString();

                            if (!string.IsNullOrEmpty(reader[5].ToString()))
                                request.Year = reader[5].ToString();

                            if (!string.IsNullOrEmpty(reader[6].ToString()))
                                request.Amount = int.Parse(reader[6].ToString());

                            if (!string.IsNullOrEmpty(reader[7].ToString()))
                                request.Inputter = reader[7].ToString();

                            if (!string.IsNullOrEmpty(reader[8].ToString()))
                                request.InputTime = DateTime.Parse(reader[8].ToString());

                            if (!string.IsNullOrEmpty(reader[9].ToString()))
                                request.BranchAuthorizer = reader[9].ToString();

                            if (!string.IsNullOrEmpty(reader[10].ToString()))
                                request.BranchAuthorizeTime = DateTime.Parse(reader[10].ToString());

                            if (!string.IsNullOrEmpty(reader[11].ToString()))
                                request.HQAuthorizer = reader[11].ToString();

                            if (!string.IsNullOrEmpty(reader[12].ToString()))
                                request.HQAuthorizeTime = DateTime.Parse(reader[12].ToString());

                            if (!string.IsNullOrEmpty(reader[13].ToString()))
                                request.Generated = Boolean.Parse(reader[13].ToString());

                            if (!string.IsNullOrEmpty(reader[14].ToString()))
                                request.GenTime = DateTime.Parse(reader[14].ToString());

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

    }
}
