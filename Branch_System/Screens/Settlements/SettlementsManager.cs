﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                BrowseReport_BTN.Text = deviceDialog.FileName;
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
            if(!string.IsNullOrWhiteSpace(transactionReportFileLocation))
            {
                var SettlementStatusObject = MPBS.Settlements.SettlementsManager.PTS_TransactionsReportReader(transactionReportFileLocation);
                var allRecords = SettlementStatusObject.Object;

                if (SettlementStatusObject.status)
                {
                    var brStatus = Database.PTSBranchController.getBranches();
                    if(!brStatus.status)
                    {
                        MessageBox.Show(brStatus.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    foreach(var b in brStatus.Object)
                    {
                       var branchRecords = allRecords.FindAll(r => b.Code.Contains(r.BranchCode));
                        if(branchRecords.Count==0)
                        {
                            MessageBox.Show(string.Format("No Records for Branch {0} {1}",b.Code,b.Name), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            continue;
                        }
                        //Get all Debit Transactions
                        var allDebitRecords = MPBS.Settlements.SettlementsManager.getTotalDebitAmountPerWallet(branchRecords);
                       
                        var status = MPBS.Settlements.SettlementsManager.createDebitTransactionsSettelmentsFile(allDebitRecords, b.Code);
                        if(!status.status)
                        {
                            MessageBox.Show(status.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }



                   
                    //Get All Purchase and AuthCompletion Transactio Fee Transactions
                    var allTransactionsFeeRecords = MPBS.Settlements.SettlementsManager.getPurchaseAndAuthCompletionTransactioFeePerWallet(allRecords);

                    //Get All Credit Transactions
                    var allCreditRecords = MPBS.Settlements.SettlementsManager.getTotalCreditAmountPerWallet(allRecords);

                    //Get All Reversal Transactions
                    var allReversalRecords = MPBS.Settlements.SettlementsManager.getTotalReversalAmountPerWallet(allRecords);



                }
                else
                {
                    MessageBox.Show(SettlementStatusObject.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void extractTransactionFile(List<TransactionReport> records,string branchCode)
        {
            //Get all Debit Transactions
            var allDebitRecords = MPBS.Settlements.SettlementsManager.getTotalDebitAmountPerWallet(records);

            var status = MPBS.Settlements.SettlementsManager.createDebitTransactionsSettelmentsFile(allDebitRecords, branchCode);
            if (!status.status)
            {
                MessageBox.Show(status.message + string.Format(" Error In generating Debit Tnx File for branch ",branchCode), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //Get All Purchase and AuthCompletion Transactio Fee Transactions
            var allTransactionsFeeRecords = MPBS.Settlements.SettlementsManager.getPurchaseAndAuthCompletionTransactioFeePerWallet(records);
            status = MPBS.Settlements.SettlementsManager.createDebitTransactionsSettelmentsFile(allTransactionsFeeRecords, branchCode);
            if (!status.status)
            {
                MessageBox.Show(status.message + string.Format(" Error In generating Purchase and PreAuth completion fee Tnx File for branch ", branchCode), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Get All Credit Transactions
            var allCreditRecords = MPBS.Settlements.SettlementsManager.getTotalCreditAmountPerWallet(records);
            status = MPBS.Settlements.SettlementsManager.createDebitTransactionsSettelmentsFile(allCreditRecords, branchCode);
            if (!status.status)
            {
                MessageBox.Show(status.message + string.Format(" Error In generating Purchase and PreAuth completion fee Tnx File for branch ", branchCode), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Get All Reversal Transactions
            var allReversalRecords = MPBS.Settlements.SettlementsManager.getTotalReversalAmountPerWallet(records);
            status = MPBS.Settlements.SettlementsManager.createDebitTransactionsSettelmentsFile(allReversalRecords, branchCode);
            if (!status.status)
            {
                MessageBox.Show(status.message+ string.Format(" Error In generating Purchase and PreAuth completion fee Tnx File for branch ", branchCode),  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}