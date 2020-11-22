using MPBS.Database;
using MPBS.Database.Objects;
using MPBS.FilesCreator;
using MPBS.SpreadSheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPBS.Screens.PTS.Generate_File
{
    
    public partial class GenLoadFile : MaterialSkin.Controls.MaterialForm
    {
        public GenLoadFile()
        {
            InitializeComponent();
        }
        private ErrorLog WalletNumber_logs;
        private ErrorLog DeviceNumber_logs;
        private ErrorLog GenLoadRecordinDB_logs;
        private ErrorLog GenLoadRecordFile_logs;


        private void GenLoadFile_Load(object sender, EventArgs e)
        {

        }

        private void GenAllLoadFiles_BTN_Click(object sender, EventArgs e)
        {
            CreateErrorLogs();
            Status<List<PTSLoad>> recordsStatus = PTSLoadController.getFullyAuthorizedLoadRequests();

            List<PTSLoad> records = new List<PTSLoad>();
            List<PTSTransactionRecord> transactions = new List<PTSTransactionRecord>();

          

            if (recordsStatus.status)
            {

                //Convert Load to Transaction record
                foreach (PTSLoad record in recordsStatus.Object)
                {
                  
                    string programCode = String.Concat(record.ProgramCode.Where(c => !Char.IsWhiteSpace(c)));

                    //Get wallet Number
                    var sAccount = PTSAccountController.getAccount(record.CustomerID, programCode);
                    if(!sAccount.status)
                    {
                        WalletNumber_logs.col_1.Add(record.ID.ToString());
                        WalletNumber_logs.col_2.Add(record.CustomerID);
                        WalletNumber_logs.col_3.Add(record.ProgramCode);
                        WalletNumber_logs.col_4.Add("No Account data in Database");
                        records.Remove(record);
                        continue;
                    }

                    string walletNumber = string.Concat(sAccount.Object.WalletNumber.Where(c => !Char.IsWhiteSpace(c)));

                    if (string.IsNullOrWhiteSpace(walletNumber))
                    {
                        WalletNumber_logs.col_1.Add(record.ID.ToString());
                        WalletNumber_logs.col_2.Add(record.CustomerID);
                        WalletNumber_logs.col_3.Add(record.ProgramCode);
                        WalletNumber_logs.col_4.Add("No Wallet Number in Database");
                        records.Remove(record);

                        continue;
                    }

                    //get Device Number
                    var sDevice = PTSDeviceController.getDevice(walletNumber);
                    if(!sDevice.status)
                    {
                        DeviceNumber_logs.col_1.Add(record.ID.ToString());
                        DeviceNumber_logs.col_2.Add(record.CustomerID);
                        DeviceNumber_logs.col_3.Add(record.ProgramCode);
                        DeviceNumber_logs.col_4.Add("No Device Number in Database");
                        records.Remove(record);

                        continue;
                    }
                    string deviceNumber = sDevice.Object.DeviceNumber;
                    if (string.IsNullOrWhiteSpace(deviceNumber))
                    {
                        DeviceNumber_logs.col_1.Add(record.ID.ToString());
                        DeviceNumber_logs.col_2.Add(record.CustomerID);
                        DeviceNumber_logs.col_3.Add(record.ProgramCode);
                        DeviceNumber_logs.col_4.Add("No Device Number in Database");
                        records.Remove(record);

                        continue;
                    }

                    PTSTransactionRecord t = new PTSTransactionRecord();
                    t.DeviceNumber = deviceNumber;
                    t.WalletNumber = walletNumber;
                    t.Indicator = "0";
                    t.TransactionDate = record.InputTime.ToString("ddMMyyyy");
                    t.TransactionCode = "U1";
                    t.FeesReason = "";
                    t.TransactionAmount = (record.Amount * 100).ToString().PadLeft(15,'0');
                    t.TransactionCurrency = "840";
                    t.ConversionRate = "";
                    t.ConversionRateDate = "";
                    t.BillingAmount = t.TransactionAmount;
                    t.BillingCurrency = t.TransactionCurrency;
                    t.Narration = "Load done By user:" + record.Inputter;
                    t.OrgTxnArn = "";
                    t.OrgTxnArnDate = "";
                    t.Source = 7;
                    t.Checksum = "";
             

                    transactions.Add(t);


                }


                var status = PTSTransactionUploadFileCreator.GenerateTransactionsRecordsFile(transactions);

                

                if (status.status)
                {
                    foreach (var record in records)
                    {
                        var sObject = PTSLoadController.genLoad(record.ID);
                        if (!sObject.status)
                        {
                            MessageBox.Show("The Record has been generated in file but failed to update (generated Var in DB)", "Error in Reocrd " + record.ID);
                            //add to logs
                            GenLoadRecordinDB_logs.col_1.Add(record.ID.ToString());
                            GenLoadRecordinDB_logs.col_2.Add(record.CustomerID);
                            GenLoadRecordinDB_logs.col_3.Add(record.ProgramCode);
                            GenLoadRecordinDB_logs.col_4.Add("The Record has been generated in file but failed to update (generated Var in DB)");
                            records.Remove(record);


                        }
                    }

                    MessageBox.Show("Done");
                }
                else
                {
                    MessageBox.Show(status.message);
                }

                GenerateTransactionsErrorReport(WalletNumber_logs, "Wallet_Number_Error_logs");
                GenerateTransactionsErrorReport(DeviceNumber_logs, "Device_Number_Error_logs");
                GenerateTransactionsErrorReport(GenLoadRecordinDB_logs, "Generate_Load_Records_in_DB_Error_logs");
                GenerateTransactionsErrorReport(GenLoadRecordFile_logs, "Generate_Load_Records_File_Error_logs");


            }
            else
            {
                MessageBox.Show(recordsStatus.message);
                return;
            }



        }

        private void GenerateTransactionsErrorReport(ErrorLog errorLogs, string FileName)
        {
            List<List<string>> dataTable = new List<List<string>>();

            //Create headers
            List<string> headers = new List<string>();
            headers.Add(errorLogs.header_1);
            headers.Add(errorLogs.header_2);
            headers.Add(errorLogs.header_3);
            headers.Add(errorLogs.header_4);

            dataTable.Add(headers);

            for(int i=0; i<errorLogs.col_1.Count;i++)
            {
                List<string> cell = new List<string>();
                cell.Add(errorLogs.col_1[i]);
                cell.Add(errorLogs.col_2[i]);
                cell.Add(errorLogs.col_3[i]);
                cell.Add(errorLogs.col_4[i]);
                dataTable.Add(cell);
            }
         

            string fileName =FileName+ DateTime.Parse(DateTime.Now.ToString()).ToString("ddMMyyyyhhmmss");
            SettlementsFiles.GenerateTemplateSpreadsheet(fileName, dataTable);
        }
        
        private void CreateErrorLogs()
        {
            WalletNumber_logs = new ErrorLog();
            WalletNumber_logs.header_1 = "Record ID";
            WalletNumber_logs.header_2 = "Customer ID";
            WalletNumber_logs.header_3 = "Program Code";
            WalletNumber_logs.header_4 = "Error";
            WalletNumber_logs.col_1 = new List<string>();
            WalletNumber_logs.col_2 = new List<string>();
            WalletNumber_logs.col_3 = new List<string>();
            WalletNumber_logs.col_4 = new List<string>();


            DeviceNumber_logs = new ErrorLog();
            DeviceNumber_logs.header_1 = "Record ID";
            DeviceNumber_logs.header_2 = "Customer ID";
            DeviceNumber_logs.header_3 = "Program Code";
            DeviceNumber_logs.header_4 = "Error";
            DeviceNumber_logs.col_1 = new List<string>();
            DeviceNumber_logs.col_2 = new List<string>();
            DeviceNumber_logs.col_3 = new List<string>();
            DeviceNumber_logs.col_4 = new List<string>();

            GenLoadRecordinDB_logs = new ErrorLog();
            GenLoadRecordinDB_logs.header_1 = "Record ID";
            GenLoadRecordinDB_logs.header_2 = "Customer ID";
            GenLoadRecordinDB_logs.header_3 = "Program Code";
            GenLoadRecordinDB_logs.header_4 = "Error";
            GenLoadRecordinDB_logs.col_1 = new List<string>();
            GenLoadRecordinDB_logs.col_2 = new List<string>();
            GenLoadRecordinDB_logs.col_3 = new List<string>();
            GenLoadRecordinDB_logs.col_4 = new List<string>();

            GenLoadRecordFile_logs = new ErrorLog();
            GenLoadRecordFile_logs.header_1 = "Record ID";
            GenLoadRecordFile_logs.header_2 = "Customer ID";
            GenLoadRecordFile_logs.header_3 = "Program Code";
            GenLoadRecordFile_logs.header_4 = "Error";
            GenLoadRecordFile_logs.col_1 = new List<string>();
            GenLoadRecordFile_logs.col_2 = new List<string>();
            GenLoadRecordFile_logs.col_3 = new List<string>();
            GenLoadRecordFile_logs.col_4 = new List<string>();
        }

        private class ErrorLog
        {
            public string header_1 { get; set; }
            public string header_2 { get; set; }
            public string header_3 { get; set; }
            public string header_4 { get; set; }


            public List<string> col_1 { get; set; }
            public List<string> col_2 { get; set; }
            public List<string> col_3 { get; set; }
            public List<string> col_4 { get; set; }

        }

        private void Exit_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
