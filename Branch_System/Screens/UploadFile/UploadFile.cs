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
    public partial class UploadFile : MaterialSkin.Controls.MaterialForm
    {
        public UploadFile()
        {
            InitializeComponent();
        }

        private void UploadFile_Load(object sender, EventArgs e)
        {

        }

        private void ApplicationApproveReport_BTN_Click(object sender, EventArgs e)
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
                

                  
               var status = FileReader.SMT_TransactionsFileReader(deviceDialog.FileName);
                var transactionsWithAccountNumber = new List<TransactionSettlements>();
                foreach(var ts in status.Object)
                {
                    //Look For card account here
                   var cardAccountObj = Database.Issue.getCardAccountFromCardNumber(ts.CardNumber);
                    if(cardAccountObj.status && !String.IsNullOrWhiteSpace(cardAccountObj.Object))
                    {
                        //From card account get account number
                       var customerAccountObj = Database.Issue.getAccountNumberFromCardAccount(cardAccountObj.Object);
                        if (customerAccountObj.status)
                        {
                            var transaction = new TransactionSettlements();
                            transaction.AccountNumber = customerAccountObj.Object;
                            transaction.Description = ts.Description;
                            transaction.Type = ts.Type;
                            transaction.Amount = ts.Amount;
                            transaction.CardNumber = ts.CardNumber;

                            transactionsWithAccountNumber.Add(transaction);
                            //Create Excel

                            // MessageBox.Show(customerAccountObj.Object);
                        }
                    }
                   
                }

                var so =  FileReader.TransactionsSettelmentsFileCreator(transactionsWithAccountNumber);
                MessageBox.Show(so.status.ToString());



            }



        }
    }
}
