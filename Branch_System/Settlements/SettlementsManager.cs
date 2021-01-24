using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPBS.Database;
using MPBS.Database.Objects;
using MPBS.Settlements.PTS.ReportTemplates;

namespace MPBS.Settlements
{
    public static class SettlementsManager
    {
        //Set Public values

        public static string FileValueDate;
        public static double TreasuryRate;



        private static Microsoft.Office.Interop.Excel.Application xlApp;
        private static Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
        private static Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
        private static Microsoft.Office.Interop.Excel.Range range;

        //SMT Transaction File Table Headers

        //PTS Transaction File Table Headers
        private static string ValueDate = "Value Date";
        private static string ProgramName = "Program Name";
        private static string Channel = "Channel";
        private static string TransactionCode = "Transaction Code";
        private static string TransactionType = "Transaction Type";
        private static string DeviceNumber = "Device Number";
        private static string BillingAmount = "Billing Amount";
        private static string TransactionDate = "Transaction Date";
        private static string TotalFeesAndCharges = "Total Fees & Charges";
        private static string ReversalFlag = "Reversal Flag";
        private static string WalletNumber = "Wallet Number";
        private static string SettlementDate = "Settlement Date";
        private static string DRorCRtoCardholder = "DR/CR to Cardholder";

        //T24 Transaction Settlements File Headers
        private static string T24DebitAccountNumberCellName = "DEBIT.ACCOUNT";
        private static string T24DebitCurrencyCellName = "USD";


        private static string T24AmountCellName = "DEBIT.AMOUNT";
        private static string T24ValueDateCellName = "DEBIT.VALUE.DATE";
        private static string T24DebitTheirRefCellName = "DEBIT.THEIR.REF";
        private static string T24CreditTheirRefCellName = "CREDIT.THEIR.REF";
        private static string T24CreditAccountNumberCellName = "CREDIT.ACCT";
        private static string T24CreditCurrencyCellName = "EUR";
        private static string T24CreditAmountCellName = "CREDIT.AMOUNT";
        private static string T24CreditValueDateCellName = "CREDIT.VALUE.DATE";


        private static string T24TreasuryRateCellName = "TREASURY.RATE";
        private static string T24DescriptionCellName = "Description";
        private static string T24TypeCellName = "TYPE";
        private static string T24CompanyCodeCellName = "COMPANY.CODE";
        private static string T24OredringCustomerCellName = "ORDERING.CUSTOMER";
        private static string T24OrderingBankCellName = "ORDERING.BANK";


        public static Status<List<TransactionReport>> PTS_TransactionsReportReader(string fileLocation)
        {
            Status<List<TransactionReport>> status = new Status<List<TransactionReport>>();
            List<TransactionReport> tsFiles = new List<TransactionReport>();
            int rowCounter;
            int colCounter;
            int rw = 0;
            int cl = 0;

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(fileLocation, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;
            cl = range.Columns.Count;

            //Column numbers of the requried columns
            int valueDateColNo = 0;
            int programNameColNo = 0;
            int channelColNo = 0;
            int transactionCodeColNo = 0;
            int transactionTypeColNo = 0;
            int deviceNumberColNo = 0;
            int billingAmountColNo = 0;
            int transactionDateColNo = 0;
            int totalFeesAndChargesColNo = 0;
            int reversalFlagColNo = 0;
            int walletNumberColNo = 0;
            int settlementDateColNo = 0;
            int dRorCRtoCardholderColNo = 0;


            for (rowCounter = 1; rowCounter <= rw; rowCounter++)
            {
                //Console.WriteLine("Row: " + rowCounter);
                if (rowCounter == 1)
                {
                    for (colCounter = 1; colCounter <= cl; colCounter++)
                    {

                        if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == ValueDate)
                        {
                            valueDateColNo = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == ProgramName)
                        {
                            programNameColNo = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == Channel)
                        {
                            channelColNo = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == TransactionCode)
                        {
                            transactionCodeColNo = colCounter;
                        }

                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == TransactionType)
                        {
                            transactionTypeColNo = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == DeviceNumber)
                        {
                            deviceNumberColNo = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == BillingAmount)
                        {
                            billingAmountColNo = colCounter;
                        }

                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == TransactionDate)
                        {

                            transactionDateColNo = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == TotalFeesAndCharges)
                        {
                            totalFeesAndChargesColNo = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == ReversalFlag)
                        {
                            reversalFlagColNo = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == WalletNumber)
                        {
                            walletNumberColNo = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == SettlementDate)
                        {
                            settlementDateColNo = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == DRorCRtoCardholder)
                        {
                            dRorCRtoCardholderColNo = colCounter;
                        }
                    }
                }
                else
                {
                    TransactionReport tr = new TransactionReport();
                    tr.ValueDate = DateTime.Parse((range.Cells[rowCounter, valueDateColNo] as Microsoft.Office.Interop.Excel.Range).Value2.ToString());
                    tr.ProgramName = (range.Cells[rowCounter, programNameColNo] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                    tr.Channel = (range.Cells[rowCounter, channelColNo] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                    tr.TransactionCode = (range.Cells[rowCounter, transactionCodeColNo] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                    tr.TransactionType = DateTime.Parse((range.Cells[rowCounter, transactionTypeColNo] as Microsoft.Office.Interop.Excel.Range).Value2.ToString());
                    tr.DeviceNumber = (range.Cells[rowCounter, deviceNumberColNo] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                    tr.BillingAmount = float.Parse((range.Cells[rowCounter, billingAmountColNo] as Microsoft.Office.Interop.Excel.Range).Value2.ToString());
                    tr.TransactionDate = DateTime.Parse((range.Cells[rowCounter, transactionDateColNo] as Microsoft.Office.Interop.Excel.Range).Value2.ToString());
                    tr.TotalFeesAndCharges = float.Parse((range.Cells[rowCounter, totalFeesAndChargesColNo] as Microsoft.Office.Interop.Excel.Range).Value2.ToString());

                    string revCol = (range.Cells[rowCounter, reversalFlagColNo] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                    if (revCol == "Reversal") tr.ReversalFlag = true;
                    else tr.ReversalFlag = false;

                    tr.WalletNumber = (range.Cells[rowCounter, walletNumberColNo] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                    tr.SettlementDate = DateTime.Parse((range.Cells[rowCounter, settlementDateColNo] as Microsoft.Office.Interop.Excel.Range).Value2.ToString());
                    string DRorCRVal = (range.Cells[rowCounter, dRorCRtoCardholderColNo] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();

                    switch (DRorCRVal)
                    {
                        case "CR":
                            tr.DRorCRtoCardholder = TransactionToCardType.CR;
                            break;
                        case "DR":
                        default:
                            tr.DRorCRtoCardholder = TransactionToCardType.DR;
                            break;
                    }




                    tsFiles.Add(tr);

                }

            }

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            status.Object = tsFiles;
            status.status = true;
            return status;
        }

        /// <summary>
        /// Get the total Amount for Debit Transactions per Wallet Number except for Purchase/Auth Completion Transaction Fee  Trasnactions
        /// </summary>
        /// <param name="transactionReports"></param>
        /// <returns></returns
        public static List<TransactionReport> getTotalDebitAmountPerWallet(List<TransactionReport> transactionReports)
        {

            List<TransactionReport> transactions = transactionReports.FindAll(t => t.DRorCRtoCardholder == TransactionToCardType.DR && t.TransactionCode != "22").GroupBy(i => i.WalletNumber).Select(tr => new TransactionReport
            {
                WalletNumber = tr.First().WalletNumber,
                DeviceNumber = tr.First().DeviceNumber,
                TotalFeesAndCharges = tr.Sum(s => s.TotalFeesAndCharges),
                BillingAmount = tr.Sum(s => s.BillingAmount),
                CBSFTDescription = "Debit Transactions",
                LYDAccountNumber = getLYDAccountNumber(tr.First().WalletNumber),
                USDAccountNumber = getCurrencyAccountNumber(tr.First().WalletNumber),
                BranchCode = getBranchCode(getLYDAccountNumber(tr.First().WalletNumber))
            }).ToList();


            return transactions;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transactionReports"></param>
        /// <returns></returns>
        public static List<TransactionReport> getPurchaseAndAuthCompletionTransactioFeePerWallet(List<TransactionReport> transactionReports)
        {

            List<TransactionReport> transactions = transactionReports.FindAll(t => t.DRorCRtoCardholder == TransactionToCardType.DR && t.TransactionCode == "22").GroupBy(i => i.WalletNumber).Select(tr => new TransactionReport
            {
                WalletNumber = tr.First().WalletNumber,
                DeviceNumber = tr.First().DeviceNumber,
                TotalFeesAndCharges = tr.Sum(s => s.TotalFeesAndCharges),
                BillingAmount = tr.Sum(s => s.BillingAmount),
                CBSFTDescription = "Card Fees Transactions",
                LYDAccountNumber = getLYDAccountNumber(tr.First().WalletNumber),
                USDAccountNumber = getCurrencyAccountNumber(tr.First().WalletNumber),
                BranchCode = getBranchCode(getLYDAccountNumber(tr.First().WalletNumber))
            }).ToList();


            return transactions;
        }
        /// <summary>
        /// Get the total Amount for Revesed Transactions per Wallet Number
        /// </summary>
        /// <param name="transactionReports"></param>
        /// <returns></returns>
        public static List<TransactionReport> getTotalReversalAmountPerWallet(List<TransactionReport> transactionReports)
        {
            List<TransactionReport> transactions = transactionReports.FindAll(t => t.ReversalFlag == true).GroupBy(i => i.WalletNumber).Select(tr => new TransactionReport
            {
                WalletNumber = tr.First().WalletNumber,
                DeviceNumber = tr.First().DeviceNumber,
                TotalFeesAndCharges = tr.Sum(s => s.TotalFeesAndCharges),
                BillingAmount = tr.Sum(s => s.BillingAmount),
                CBSFTDescription = "Reversal Transactions",
                LYDAccountNumber = getLYDAccountNumber(tr.First().WalletNumber),
                USDAccountNumber = getCurrencyAccountNumber(tr.First().WalletNumber),
                BranchCode = getBranchCode(getLYDAccountNumber(tr.First().WalletNumber))
            }).ToList();

            return transactions;
        }

        /// <summary>
        /// Get The total amount for Credit transctions except for Reversal, Load Cash U1 and Miscellaneous Credit
        /// </summary>
        /// <param name="transactionReports"></param>
        /// <returns></returns>
        public static List<TransactionReport> getTotalCreditAmountPerWallet(List<TransactionReport> transactionReports)
        {

            List<TransactionReport> transactions = transactionReports.FindAll(t => t.DRorCRtoCardholder == TransactionToCardType.CR && !t.ReversalFlag && t.TransactionCode != "71" && t.TransactionCode != "U1").GroupBy(i => i.WalletNumber).Select(tr => new TransactionReport
            {
                WalletNumber = tr.First().WalletNumber,
                DeviceNumber = tr.First().DeviceNumber,
                TotalFeesAndCharges = tr.Sum(s => s.TotalFeesAndCharges),
                BillingAmount = tr.Sum(s => s.BillingAmount),
                CBSFTDescription = "Credit Transaction",
                LYDAccountNumber = getLYDAccountNumber(tr.First().WalletNumber),
                USDAccountNumber = getCurrencyAccountNumber(tr.First().WalletNumber),
                BranchCode = getBranchCode(getLYDAccountNumber(tr.First().WalletNumber))
            }).ToList();


            return transactions;
        }

        public static string getLYDAccountNumber(string walletNumber)
        {
            var status  = PTSAccountController.getAccount(walletNumber);
            return status.status ? status.Object.AccountNumberLYD : null;
        }

        public static string getCurrencyAccountNumber(string walletNumber)
        {
            var status = PTSAccountController.getAccount(walletNumber);
            return status.status ? status.Object.AccountNumberCurrency : null;
        }
        public static string getBranchCode(string account)
        {
            return string.IsNullOrWhiteSpace(account)?null: account.Substring(9, 2);
        }

    }
}
