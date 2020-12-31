using MPBS.Database;
using MPBS.Database.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MPBS.FilesCreator
{

    public static class PTSTransactionUploadFileCreator
    {
        
      

        public static Status GenerateTransactionsRecordsFile(List<PTSTransactionRecord> records)
        {
            Status status = new Status();
            status.status = false;
            List<string> recordStrings = new List<string>();

            foreach (PTSTransactionRecord record in records)
            {
                recordStrings.Add(extractRecordsString(record));
            }

            string fileName = getFileName();
            string header = getHeader();
            string footer = getFooter(recordStrings.Count);

            status = createAppFile(fileName, header, footer, recordStrings);

            return status;
        }

        //public static Status<int> GenerateAppRecordFilesBasedOnProgramCode(List<PTSAppRecord> records)
        //{
        //    Status<int> statusObject = new Status<int>();
        //    return statusObject;
        //}

        private static string getHeader()
        {
            var today = DateTime.Now;
            string day = today.Day.ToString().PadLeft(2, '0');
            string month = today.Month.ToString().PadLeft(2, '0');
            string year = today.Year.ToString();

            string hour = today.Hour.ToString().PadLeft(2, '0');
            string minutes = today.Minute.ToString().PadLeft(2, '0');
            string seconds = today.Second.ToString().PadLeft(2, '0');
            //string header = "HD" + "|" + MPBSConfig.PTSBankCode + "|" + day + month + year + hour + minutes + seconds + "|" + "2.0";
            string header = "HD" + MPBSConfig.PTSBankCode  + day + month + year + hour + minutes + seconds  + "2.0";


            return header;
        }

        private static string getFooter(int count)
        {
            string recordCount = count.ToString().PadLeft(9, '0');
           //string footer = "FT" + "|" + recordCount;
            string footer = "FT"  + recordCount;

            return footer;
        }

        private static string getFileName()
        {
            string name = "TXU" + MPBSConfig.PTSBankCode;
            int seq = 0;
            var today = DateTime.Now;


            string DD = today.Day.ToString().PadLeft(2, '0');
            string MM = today.Month.ToString().PadLeft(2, '0');
            string YY = today.Year.ToString().Substring(2, 2);
            string hh = today.Hour.ToString().PadLeft(2, '0');
            string mm = today.Minute.ToString().PadLeft(2, '0');
            string ss = today.Second.ToString().PadLeft(2, '0');

            name += DD + MM + YY + hh + mm + ss;

         

            name += ".dat";
            return name;
        }
        private static string extractRecordsString(PTSTransactionRecord record)
        {

            string recordString = "";


           //Device Number
            recordString += record.DeviceNumber + "|";


            //Wallet Number
            recordString += record.WalletNumber + "|";

            //Indicator
            recordString += record.Indicator + "|";

            //Transaction Date
            recordString += record.TransactionDate + "|";


            //Add Transcation Code
            recordString += record.TransactionCode + "|";

            //Fees Reason
            if(string.IsNullOrWhiteSpace(record.FeesReason))
            {
                record.FeesReason = "";
            }
            recordString += record.FeesReason + "|";

            //Transaction Amount 
            recordString += record.TransactionAmount + "|";


            //Transaction Currency  
            recordString += record.TransactionCurrency + "|";

            //Conversion Rate 
            if (string.IsNullOrWhiteSpace(record.ConversionRate))
            {
                record.ConversionRate = "";
            }
            recordString += record.ConversionRate + "|";

            //Conversion Rate Date
            if (string.IsNullOrWhiteSpace(record.ConversionRateDate))
            {
                record.ConversionRateDate = "";
            }
            recordString += record.ConversionRateDate + "|";

            //Billing Amount 
            recordString += record.BillingAmount + "|";

            //Billing Currency 
            recordString += record.BillingCurrency + "|";

            //Narration 
            if (string.IsNullOrWhiteSpace(record.Narration))
            {
                record.Narration = "";
            }

           //record.Narration = String.Concat(record.Narration.Where(c => !Char.IsWhiteSpace(c)));
           if(record.Narration.Count() >38)
            {
                record.Narration = record.Narration.Substring(0, 38);
            }
            recordString += record.Narration + "|";

            //ORG_TXN_ARN
            recordString += record.OrgTxnArn + "|";

            //ORG_TXN_ARN Date
            recordString += record.OrgTxnArnDate + "|";


            //Source
            recordString += "" + "|";

            //Checksum 
            recordString += "".PadLeft(8, '0') + "";

            return recordString;
        }

        private static bool checkFileExist(string fileName)
        {
            string file = String.Format(MPBSConfig.PTSApplicationFiles + @"\" + fileName);

            if (File.Exists(file))
            {
                Console.WriteLine("Exist");
                return true;
            }
            return false;
        }
        private static Status createAppFile(string fileName, string header, string footer, List<string> recordStrings)
        {
            Status status = new Status();
            status.status = false;
            string file = String.Format(MPBSConfig.PTSLoadFiles + @"\" + fileName);

            try
            {
                // Check if file already exists. If yes, delete it.     


                // Create a new file 
                using (StreamWriter fs = File.CreateText(file))
                {
                    //Write header
                    fs.WriteLine(header);
                    foreach (string record in recordStrings)
                    {
                        fs.WriteLine(record);
                    }
                    //Write Footer  
                    fs.WriteLine(footer);

                    status.status = true;

                }
                return status;
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
                status.status = false;
                status.message = Ex.Message;
                return status;
            }
        }


    }
}
