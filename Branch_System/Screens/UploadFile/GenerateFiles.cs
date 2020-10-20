using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPBS.SpreadSheet;
using MPBS.SpreadSheet.Structure;



namespace MPBS.Screens.UploadFile
{
    public partial class GenerateT24Files : MaterialSkin.Controls.MaterialForm
    {
        public GenerateT24Files()
        {
            InitializeComponent();
        }

        private void UploadFile_Load(object sender, EventArgs e)
        {

        }

        private void UploadSMTTransactionReport_BTN_Click(object sender, EventArgs e)
        {

            OpenFileDialog deviceDialog = new OpenFileDialog();
            deviceDialog.InitialDirectory = @"C:\";
            deviceDialog.RestoreDirectory = true;
            deviceDialog.DefaultExt = "xlsx";
            deviceDialog.Filter = "xlsx files (*.xlsx)|*.xlsx";
            deviceDialog.AddExtension = true;

            DialogResult dr = deviceDialog.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                dr.ToString();
                Console.WriteLine(deviceDialog.FileName);


               var SMTTransactions = this.ReadSMTTransactionSpreadSheet(deviceDialog.FileName);

                var transactionsWithAccountNumber = new List<TransactionSettlements>();

                if(SMTTransactions!=null)
                {

                   transactionsWithAccountNumber = GetAccountNumberForTransaction(SMTTransactions);

                    GenerateSettlementsSpreadSheets(transactionsWithAccountNumber);
                }

            }



        }

        private List<TransactionSettlements> ReadSMTTransactionSpreadSheet(string fileName)
        {
            var statusObj = FileReader.SMT_TransactionsFileReader(fileName);
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

        private void GenerateSettlementsSpreadSheets(List<TransactionSettlements> transactions)
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
                var so = FileReader.TransactionsSettelmentsFileCreator(result.Transactions, result.Branch);
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

        private void GenerateTransactionsErrorReport(List<TransactionSettlements> transactions,string ErrorType,string ErrorMessage)
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
                cell.Add(ErrorType);
                dataTable.Add(cell);
            }

            string fileName = ErrorType + "Report" + DateTime.Parse(DateTime.Now.ToString()).ToString("ddMMyyyyhhmmss");
            FileReader.GenerateTemplateSpreadsheet(fileName, dataTable);
        }

        private void Back_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
