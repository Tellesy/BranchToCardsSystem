using MPBS.Database.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPBS.Database
{
   public static class ReportsController
    {
        public static Status<List<List<string>>> getPTSCardsIssueReport(string fromDate,string toDate,bool isBranch,string programCode)
        {
            string dateType = "ar.gen_time";
            string joinDeviceTable = @" join PTS_Device as dev on dev.wallet_number = acc.wallet_number";
            string getDeviceNumber = @",SUBSTRING(dev.device_number,1,6) + 'XXXXXX' + SUBSTRING(dev.device_number,13,4) as  'Device Number'";
            string branch = "";
            if (isBranch)
            {
                dateType = "ar.input_time";
                getDeviceNumber = "";
                joinDeviceTable = "";
                var sbranch = PTSBranchController.getBranch(int.Parse(Login.branch));
                if(sbranch.status)
                {
                    branch = "and ar.branch_code = '" + sbranch.Object.Code+"' ";

                }
                
            }
            
            Status<List<List<string>>> statusObject = new Status<List<List<string>>>();
            statusObject.Object = new List<List<string>>();
            statusObject.status = false;


            SqlConnection conn = DBConnection.Connection();

           

            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {


                try
                {
                    string query = string.Format(@"select ar.customer_id, c.embossed_name , acc.account_number_currency, ar.branch_code  ,ar.program_code,
                                                {0} as Date {3} from  PTS_AppRecord as ar join PTS_Customer as c
                                                on ar.customer_id = c.customer_ID  
                                                join PTS_Account as acc on acc.customer_ID = ar.customer_id
                                                {4}
                                                where acc.program_code = ar.program_code 
                                                and {0} > '{1} 00:00:00' AND {0} <= '{2} 23:59:59'
                                                and ar.program_code ='{5}'
                                                {6}", dateType,fromDate,toDate,getDeviceNumber,joinDeviceTable, programCode,branch);

                    SqlCommand cmd = new SqlCommand(query, conn);



                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        if (!reader.HasRows)
                        {
                            statusObject.status = false;
                            statusObject.message = "لا يوجد سجلات";
                            return statusObject;

                        }

                        //Set Header 
                        List<string> header = new List<string>();
                        header.Add("No.");
                        header.Add("Customer ID");
                        header.Add("Name");
                        header.Add("Account Number");
                        header.Add("Branch");
                   
                        header.Add("Program");
                        header.Add("Date");

                        if (!isBranch)
                            header.Add("Device Number");

                        statusObject.Object.Add(header);
                        int counter = 1;

                        while (reader.Read())
                        {
                            List<string> cols = new List<string>();
                            cols.Add(counter++.ToString());

                            if (!string.IsNullOrEmpty(reader[0].ToString()))
                                cols.Add(reader[0].ToString());

                            if (!string.IsNullOrEmpty(reader[1].ToString()))
                                cols.Add(reader[1].ToString());

                            if (!string.IsNullOrEmpty(reader[2].ToString()))
                                cols.Add(reader[2].ToString());

                            if (!string.IsNullOrEmpty(reader[3].ToString()))
                                cols.Add(reader[3].ToString());

                            if (!string.IsNullOrEmpty(reader[4].ToString()))
                                cols.Add(reader[4].ToString());

                            if (!string.IsNullOrEmpty(reader[5].ToString()))
                            {
                                cols.Add(DateTime.Parse(reader[5].ToString()).ToString("yyyy-MM-dd"));
                            }
                            if(!isBranch)
                            if (!string.IsNullOrEmpty(reader[6].ToString()))
                                cols.Add(reader[6].ToString());

                       
                             

                            statusObject.Object.Add(cols);
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
                    statusObject.message = "Get Issuing Card Report\n" + Errors.ErrorsString.Error002 + "\n" + e;
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


    }
}
