using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MPBS.SpreadSheet;
using MPBS.SpreadSheet.Structure;
using MPBS.Database;
using MPBS.Database.Objects;

namespace MPBS.Screens.UploadFile
{
    public partial class GenerateT24Files : MaterialSkin.Controls.MaterialForm
    {
        private double Rate;
        private string ValueDate;
        public GenerateT24Files()
        {
            InitializeComponent();
        }

        private void UploadFile_Load(object sender, EventArgs e)
        {
           var pstatus = PTSProgramController.getPrograms();   

            if(pstatus.status)
            {
                // foreach(var p in programStatus.Object)
                Programs_CBOX.DataSource = pstatus.Object;
                Programs_CBOX.DisplayMember = "NameEN";
                Programs_CBOX.ValueMember = "Code";
                this.Programs_CBOX.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private OpenFileDialog OpenFileDialog()
        {
            OpenFileDialog deviceDialog = new OpenFileDialog();
            deviceDialog.InitialDirectory = @"C:\";
            deviceDialog.RestoreDirectory = true;
            deviceDialog.DefaultExt = "xlsx";
            deviceDialog.Filter = "xlsx files (*.xlsx)|*.xlsx";
            deviceDialog.AddExtension = true;
           // DialogResult dr = deviceDialog.ShowDialog();

            return deviceDialog;
        }
        private async void UploadSMTTransactionReport_BTN_Click(object sender, EventArgs e)
        {
            UploadSMTTransactionReport_BTN.Enabled = false;
            //Enter Treasury Rate
            if(!EnterTreasuryRate())
            {
                UploadSMTTransactionReport_BTN.Enabled = true;
                return;
            }
            else
            {
                SettlementsFiles.TreasuryRate = this.Rate;
            }

            //Enter Value Date
            if (!EnterValueDate())
            {
                UploadSMTTransactionReport_BTN.Enabled = true;
                return;
            }
            else
            {
                SettlementsFiles.ValueDate = this.ValueDate;
            }


            var deviceDialog = OpenFileDialog();
            DialogResult dr = deviceDialog.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {

               var SMTTransactions = this.ReadSMTTransactionSpreadSheet(deviceDialog.FileName);

                var transactionsWithAccountNumber = new List<TransactionSettlements>();

                if(SMTTransactions!=null)
                {

                   transactionsWithAccountNumber = GetAccountNumberForTransaction(SMTTransactions);

                    GenerateSettlementsSpreadSheets(transactionsWithAccountNumber);
                }

            }



            MessageBox.Show("All Done");
            UploadSMTTransactionReport_BTN.Enabled = true;
        }

        private List<TransactionSettlements> ReadSMTTransactionSpreadSheet(string fileName)
        {
            var statusObj = SettlementsFiles.SMT_TransactionsFileReader(fileName);
            if(statusObj.status)
            {
                return statusObj.Object;
            }
            else
            {
                MessageBox.Show("Couldn't read file! " + statusObj.message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }
        }

        private List<TransactionSettlements> GetAccountNumberForTransaction(List<TransactionSettlements> transactions)
        {
            List<TransactionSettlements> result = new List<TransactionSettlements>();
            List<TransactionSettlements> cardAccountErrors = new List<TransactionSettlements>();
            List<TransactionSettlements> customerAccountErrors = new List<TransactionSettlements>();




            foreach (var ts in transactions)
            {
                //Look For card account here
                var cardAccountObj = Database.Issue.getCardAccountFromCardNumber(ts.CardNumber);
                if (cardAccountObj.status && !String.IsNullOrWhiteSpace(cardAccountObj.Object))
                {
                    //From card account get account number
                    var customerAccountObj = Database.Issue.getAccountNumberFromCardAccount(cardAccountObj.Object);
                    if (customerAccountObj.status && !String.IsNullOrWhiteSpace(customerAccountObj.Object))
                    {
                        var transaction = new TransactionSettlements();
                        transaction.AccountNumber = customerAccountObj.Object;
                        transaction.Description = ts.Description;
                        transaction.Type = ts.Type;
                        transaction.Amount = ts.Amount;
                        transaction.CardNumber = ts.CardNumber;
                        transaction.Branch = ts.CardNumber.Substring(8, 2);
                        result.Add(transaction);
                    }
                    else
                    {
                        customerAccountErrors.Add(ts);
                    }
                }
                else
                {
                    cardAccountErrors.Add(ts);
                }

             

            }

            //Generate Error Reports
            if (customerAccountErrors.Count > 0)
            {
                GenerateTransactionsErrorReport(customerAccountErrors, "Acc", "Could not find Customer Account in Database");

            }
            if (cardAccountErrors.Count > 0)
            {
                GenerateTransactionsErrorReport(cardAccountErrors, "Car", "Could not find Card Account in Database");

            }

            return result;
        }

        private async void GenerateSettlementsSpreadSheets(List<TransactionSettlements> transactions)
        {

            var groupedByBranch = transactions.GroupBy(t => t.Branch,
            (branch, selectResult) => new
            {
                Branch = branch,
                Transactions = selectResult.ToList<TransactionSettlements>(),
            });
            foreach (var result in groupedByBranch)
            {
                Console.WriteLine("\nAge group: " + result.Branch);

                Console.WriteLine(result.Transactions[0].AccountNumber);
                var so = SettlementsFiles.TransactionsSettelmentsFileCreator(result.Transactions, result.Branch);
                if(so.status)
                {
                    MessageBox.Show("File Generated Successfully for Branch: " + result.Branch.ToString(), so.status.ToString());
                }
                else
                {
                    MessageBox.Show("File Did not Generate Successfully for: " + result.Branch.ToString(), so.status.ToString());
                }
               


            }
        }

        private async void GenerateTransactionsErrorReport(List<TransactionSettlements> transactions,string ErrorType,string ErrorMessage)
        {
            List<List<string>> dataTable = new List<List<string>>();

            //Create headers
            List<string> headers = new List<string>();
            headers.Add("Card Number");
            headers.Add("Error");

            dataTable.Add(headers);

            foreach(var ts in transactions)
            {
                List<string> cell = new List<string>();
                cell.Add(ts.CardNumber);
                cell.Add(ErrorMessage);
                dataTable.Add(cell);
            }

            string fileName = ErrorType + "Report" + DateTime.Parse(DateTime.Now.ToString()).ToString("ddMMyyyyhhmmss");
            SettlementsFiles.GenerateTemplateSpreadsheet(fileName, dataTable);
        }

        private bool EnterTreasuryRate()
        {
            string rateString = Interaction.InputBox("Please Enter Treasury Rate?", "Treasury Rate", "0.0");
            if (!string.IsNullOrWhiteSpace(rateString))
            {
               double rate = double.Parse(rateString);

                if(rate > 0)
                {
                    Rate = rate;
                    return true;
                }
                else
                {
                    MessageBox.Show("Rate should be grater than Zero");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Error in Entering Rate");
                return false;
            }
        }

        private bool EnterValueDate()
        {
            var today = DateTime.Today;
            string defaultValueDate = today.Year.ToString() + today.Month.ToString().PadLeft(2,'0') + today.Day.ToString().PadLeft(2,'0') ;

            string valueDate = Interaction.InputBox("Please Enter Value Date?", "Value Date", defaultValueDate);
            if (!string.IsNullOrWhiteSpace(valueDate))
            {

                    ValueDate = valueDate;
                return true;

            }
            else
            {
                MessageBox.Show("Error in Entering Rate");
                return false;
            }
        }
       

        private void UploadPTSApplicationApproveReport_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                var deviceDialog = OpenFileDialog();
                DialogResult dr = deviceDialog.ShowDialog();

                if (dr == System.Windows.Forms.DialogResult.OK)
                {


                    var applications = new List<ApplicationApproveReport>();
                    var rstatus = PTSReports.PTS_ApplicationApproveReportUpload(deviceDialog.FileName);

                    if (rstatus.status)
                    {
                        foreach (var app in rstatus.Object)
                        {

                            //First Add Client Code to Customer
                          var cStatus =  PTSCustomerController.AddClientCode(app.CBSCustomerID, app.ClientCode);
                            if(!cStatus.status)
                            {
                                MessageBox.Show("Error in adding Client Code to " + app.CBSCustomerID, cStatus.message + " " + app.CBSCustomerID);
                            }

                            var program = Programs_CBOX.SelectedValue.ToString().Replace(" ", String.Empty);
                            
                            //st.
                            if (app.DevicePackID.Contains(program))
                            {

                                //Add Wallet Number to PTS Account table
                                var aStatus = PTSAccountController.addWalletNumber(app.CBSCustomerID, program, app.WalletNumber);
                                if (!aStatus.status)
                                {
                                    MessageBox.Show("Error in adding Wallet Number to " + app.CBSCustomerID, aStatus.message + " " + app.CBSCustomerID);
                                }

                                PTSDevice device = new PTSDevice();
                                device.Active = true;
                                device.CardPackID = app.DevicePackID;
                                device.DeviceNumber = app.DeviceNumber;
                                device.WalletNumber = app.WalletNumber;

                                var dStatus = PTSDeviceController.addDevice(device);
                                if (!dStatus.status)
                                {
                                    MessageBox.Show("Error in adding new Device for " + app.CBSCustomerID, dStatus.message + " " + app.DeviceNumber);
                                }

                                Console.WriteLine(app.DevicePackID);
                                MessageBox.Show(app.DevicePackID);
                            }
                        }
                    }



                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
          
        }

        private void Back_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
