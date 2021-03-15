using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPBS.Database;
using MPBS.Settlements;
using MPBS.Settlements.PTS.ReportTemplates;

namespace MPBS.Screens.SettlementsSecreens
{
    public partial class SettlementsManager : MaterialSkin.Controls.MaterialForm
    {
        private string transactionReportFileLocation;
        public SettlementsManager()
        {
            InitializeComponent();
        }

        private void SettlementsManager_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

        }

        private void BrowseReport_BTN_Click(object sender, EventArgs e)
        {
            var deviceDialog = OpenFileDialog();
            DialogResult dr = deviceDialog.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                BrowseTransactionReport_TXT.Text = deviceDialog.FileName;
                transactionReportFileLocation = deviceDialog.FileName;
                //PINFileRecordsReorder.ExtractRecordsFromFiles(deviceDialog.FileName);

            }
        }

        private OpenFileDialog OpenFileDialog()
        {
            OpenFileDialog deviceDialog = new OpenFileDialog();
            deviceDialog.InitialDirectory = @"C:\";
            deviceDialog.RestoreDirectory = true;
            //deviceDialog.DefaultExt = "";
            //deviceDialog.Filter = "xlsx files (*.xlsx)|*.xlsx";
            deviceDialog.AddExtension = true;
            // DialogResult dr = deviceDialog.ShowDialog();

            return deviceDialog;
        }

        private void Process_BTN_Click(object sender, EventArgs e)
        {
            BrowseReport_BTN.Enabled = false;
            BrowseTransactionReport_TXT.Enabled = false;

            progressBar.Value = 0;
            if (!string.IsNullOrWhiteSpace(transactionReportFileLocation))
            {
                var SettlementStatusObject = MPBS.Settlements.SettlementsManager.PTS_TransactionsReportReader(transactionReportFileLocation);
                var RecordsAsFoundInFile = SettlementStatusObject.Object;

                progressBar.Value = 10;


                List<TransactionReport> CleanRecords = new List<TransactionReport>();

                //Add Branch Number is another 10%
                //Add branch and account number
                int progressCountForEachRecor = 10 / RecordsAsFoundInFile.Count;
                foreach(var r in RecordsAsFoundInFile)
                {
                   var aStatus = PTSAccountController.getAccount(r.WalletNumber);
                    
                    if (!aStatus.status || aStatus.Object == null)
                    {
                        //Add to logs in the futrue
                       
                        continue;
                    }

                    r.LYDAccountNumber = aStatus.Object.AccountNumberLYD;
                    r.USDAccountNumber = aStatus.Object.AccountNumberCurrency;

                    r.BranchCode = r.LYDAccountNumber.Substring(10, 2);

                    CleanRecords.Add(r);

                    progressBar.Value = progressBar.Value + progressCountForEachRecor;


                }
                progressBar.Value = 20;


                if (SettlementStatusObject.status)
                {
                    var brStatus = Database.PTSBranchController.getBranches();
                    if(!brStatus.status)
                    {
                        MessageBox.Show(brStatus.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    progressCountForEachRecor = 75/brStatus.Object.Count;
                    foreach (var b in brStatus.Object)
                    {
                     
                     
                       var branchRecords = CleanRecords.FindAll(r => b.Code.Contains(r.BranchCode));

                        if(branchRecords.Count==0)
                        {
                            MessageBox.Show(string.Format("No Records for Branch {0} {1}",b.Code,b.Name), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            continue;
                        }

                         extractTransactionFile(branchRecords, b.Code);

                        progressBar.Value = progressBar.Value + progressCountForEachRecor;

                        //}
                    }


                    progressBar.Value = 100;
                }
                else
                {
                    MessageBox.Show(SettlementStatusObject.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BrowseReport_BTN.Enabled = Enabled;
                    BrowseTransactionReport_TXT.Enabled = Enabled;
                    progressBar.Value = 0;
                    return;
                }

                BrowseReport_BTN.Enabled = Enabled;
                BrowseTransactionReport_TXT.Enabled = Enabled;
                //progressBar.Value = 0;
            }
        }

        private async void extractTransactionFile(List<TransactionReport> records,string branchCode)
        {
            //Get all Debit Transactions
            var allDebitRecords = MPBS.Settlements.SettlementsManager.getTotalDebitAmountPerWallet(records);

            var status = MPBS.Settlements.SettlementsManager.createTransactionsSettelmentsFile(FileType.DEBIT, allDebitRecords, branchCode);
            if (!status.status)
            {
                MessageBox.Show(status.message + string.Format(" Error In generating Debit Tnx File for branch ",branchCode), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //Balance Enqury only
            var balanceEnquiryRecords = MPBS.Settlements.SettlementsManager.getBallanceEnquriyFees(records);
            ////Sum all fees 
            //foreach (var tnx in allDebitRecords)
            //{
            //    if (tnx.TotalFeesAndCharges > 0)
            //    {
            //        tnx.BillingAmount = tnx.TransactionFees;
            //        allTransactionsFeeRecords.Add(tnx);
            //    }

            //}

            status = MPBS.Settlements.SettlementsManager.createTransactionsSettelmentsFile(FileType.BALANCE_FEE,balanceEnquiryRecords, branchCode);
            if (!status.status)
            {
                MessageBox.Show(status.message + string.Format(" Error In generating Purchase and PreAuth completion fee Tnx File for branch ", branchCode), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //
            var ba = MPBS.Settlements.SettlementsManager.getBallanceEnquriyFees(records);



            //Get All Credit Transactions
            var allCreditRecords = MPBS.Settlements.SettlementsManager.getTotalCreditAmountPerWallet(records);
            status = MPBS.Settlements.SettlementsManager.createTransactionsSettelmentsFile(FileType.CREDIT, allCreditRecords, branchCode);
            if (!status.status)
            {
                MessageBox.Show(status.message + string.Format(" Error In generating Purchase and PreAuth completion fee Tnx File for branch ", branchCode), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Get All Reversal Transactions
            var allReversalRecords = MPBS.Settlements.SettlementsManager.getTotalReversalAmountPerWallet(records);
            status = MPBS.Settlements.SettlementsManager.createTransactionsSettelmentsFile(FileType.REVERSAL, allReversalRecords, branchCode);
            if (!status.status)
            {
                MessageBox.Show(status.message+ string.Format(" Error In generating Purchase and PreAuth completion fee Tnx File for branch ", branchCode),  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
