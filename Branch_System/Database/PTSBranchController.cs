using MPBS.Database.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MPBS.Database
{
    public static class PTSBranchController
    {
        public static Status<List<PTSBranch>> getBranches()
        {
            Status<List<PTSBranch>> statusObject = new Status<List<PTSBranch>>();
            statusObject.status = false;
            List<PTSBranch> branches = new List<PTSBranch>();

            SqlConnection conn = Database.DBConnection.Connection();


            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = @"SELECT [Code],[Name],[old_branch_code] FROM [CTS].[dbo].[PTS_Branch]";

                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {
                        if (!reader.HasRows)
                        {
                            statusObject.status = false;
                            statusObject.message = Errors.ErrorsString.Error012;
                            conn.Close();
                            return statusObject;

                        }
                        else
                        {
                            while (reader.Read())
                            {
                                PTSBranch b = new PTSBranch();
                                
                                b.Code = reader[0].ToString();
                                b.Name = reader[1].ToString();
                                b.Branch_code = int.Parse(reader[2].ToString());
                             

                                branches.Add(b);

                      
                            }
                            conn.Close();
                            statusObject.status = true;
                            statusObject.Object = branches;
                            return statusObject;

                        }
                    }
                    catch (Exception e)
                    {
                        conn.Close();
                        statusObject.status = false;
                        statusObject.message = "Get PTS Branches Info\n" + Errors.ErrorsString.Error002 + "\n" + e;
                        return statusObject;
                    }


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

        public static Status<PTSBranch> getBranch(int branch_code)
        {
            Status<PTSBranch> statusObject = new Status<PTSBranch>();
            statusObject.status = false;
            PTSBranch branch = new PTSBranch();

            SqlConnection conn = Database.DBConnection.Connection();


            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = @"SELECT TOP 1 [Code],[Name],[old_branch_code] FROM [CTS].[dbo].[PTS_Branch] where [old_branch_code] = '"+branch_code+"'";

                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {
                        if (!reader.HasRows)
                        {
                            statusObject.status = false;
                            statusObject.message = Errors.ErrorsString.Error012;
                            conn.Close();
                            return statusObject;

                        }
                        else
                        {
                            while (reader.Read())
                            {
                                

                                branch.Code = reader[0].ToString();
                                branch.Name = reader[1].ToString();
                                branch.Branch_code = branch_code;


                            }
                            conn.Close();
                            statusObject.status = true;
                            statusObject.Object = branch;
                            return statusObject;

                        }
                    }
                    catch (Exception e)
                    {
                        conn.Close();
                        statusObject.status = false;
                        statusObject.message = "Get PTS Branches Info\n" + Errors.ErrorsString.Error002 + "\n" + e;
                        return statusObject;
                    }


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
    }
}
