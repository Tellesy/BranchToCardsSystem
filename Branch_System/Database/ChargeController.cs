using MPBS.Database.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPBS.Database
{
    public static class ChargeController
    {
        public static Status addCharges(Charge charge)
        {
            Status status = new Status();
            status.status = false;

            SqlConnection conn = DBConnection.Connection();

            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    string query = @"INSERT INTO [dbo].[Charge]
           (
            [Charge_Type]
           ,[Customer_ID]
           ,[Program_Code]
           ,[Branch_Code])
            VALUES
           (@v1
           ,@v2
           ,@v3
           ,@v4)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@v1", charge.ChargeType);
                    cmd.Parameters.AddWithValue("@v2", charge.CustomerID);
                    cmd.Parameters.AddWithValue("@v3", charge.ProgramCode);
                    cmd.Parameters.AddWithValue("@v4", charge.BranchCode);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    status.status = true;
                    return status;
                }
                catch (Exception e)
                {
                    status.status = false;
                    status.status = false;
                    status.message = "Add to Charge\n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        public static Status<List<Charge>> getUngenCharges(string branch_code)
        {
            Status<List<Charge>> statusObject = new Status<List<Charge>>();
            statusObject.status = false;
            List<Charge> charges = new List<Charge>();

            SqlConnection conn = Database.DBConnection.Connection();


            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = @"SELECT [ID],[Charge_Type],[Customer_ID],[Program_Code],[Gen_Flag] ,[Input_Date],[Gen_Date],[Exe_Flag],[Exe_Date],[Branch_Code] FROM [CTS].[dbo].[Charge] where [Gen_Flag] = 0 and Branch_Code = '" + branch_code+"'";

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
                                Charge c = new Charge();
                                c.ID = int.Parse(reader[0].ToString());
                                c.ChargeType = int.Parse(reader[1].ToString());
                                c.CustomerID = int.Parse(reader[2].ToString());
                                c.ProgramCode = reader[3].ToString();
                                c.BranchCode = reader[9].ToString();

                                charges.Add(c);


                            }

                            statusObject.status = true;
                            statusObject.Object = charges;
                            return statusObject;

                        }
                    }
                    catch (Exception e)
                    {
                        statusObject.status = false;
                        statusObject.message = "Get Ungen Charges Info\n" + Errors.ErrorsString.Error002 + "\n" + e;
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

        //public static Status<List<Charge>> getUngenCharges(string customer_id, string program_code)
        //{
        //    Status<List<Charge>> statusObject = new Status<List<Charge>>();
        //    statusObject.status = false;
        //    List<Charge> charges = new List<Charge>();

        //    SqlConnection conn = Database.DBConnection.Connection();


        //    conn.Open();

        //    if (conn.State == System.Data.ConnectionState.Open)
        //    {

        //        string query = @"SELECT [ID],[Charge_Type],[Customer_ID],[Program_Code],[Gen_Flag] ,[Input_Date],[Gen_Date],[Exe_Flag],[Exe_Date],[Branch_Code] FROM [CTS].[dbo].[Charge] where [Gen_Flag] = 0 and Branch_Code = '" + branch_code + "'";

        //        SqlCommand cmd = new SqlCommand(query, conn);

        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            try
        //            {
        //                if (!reader.HasRows)
        //                {
        //                    statusObject.status = false;
        //                    statusObject.message = Errors.ErrorsString.Error012;

        //                    return statusObject;

        //                }
        //                else
        //                {
        //                    while (reader.Read())
        //                    {
        //                        Charge c = new Charge();
        //                        c.ID = int.Parse(reader[0].ToString());
        //                        c.ChargeType = int.Parse(reader[1].ToString());
        //                        c.CustomerID = int.Parse(reader[2].ToString());
        //                        c.ProgramCode = reader[3].ToString();
        //                        c.BranchCode = int.Parse(reader[9].ToString());

        //                        charges.Add(c);


        //                    }

        //                    statusObject.status = true;
        //                    statusObject.Object = charges;
        //                    return statusObject;

        //                }
        //            }
        //            catch (Exception e)
        //            {
        //                statusObject.status = false;
        //                statusObject.message = "Get Ungen Charges Info\n" + Errors.ErrorsString.Error002 + "\n" + e;
        //                return statusObject;
        //            }


        //        }

        //    }
        //    else
        //    {
        //        statusObject.status = false;
        //        statusObject.message = Errors.ErrorsString.Error001;

        //        return statusObject;
        //    }
        //}


    }
}
