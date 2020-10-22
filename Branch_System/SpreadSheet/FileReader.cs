using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPBS.Database.Objects;
using MPBS.SpreadSheet.Structure;

namespace MPBS.SpreadSheet
{
    public static class FileReader
    {
        private static Microsoft.Office.Interop.Excel.Application xlApp;
        private static Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
        private static Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
        private static Microsoft.Office.Interop.Excel.Range range;

        //SMT Transaction File Table Headers
        private static string SMTAmountCellName = "AMOUNT USD";
        private static string SMTDescriptionCellName = "LOCALITY";
        private static string SMTTypeCellName = "TYPE";
        private static string STMCardNumberCellName = "CARDHOLDER";

        //T24 Transaction Settlements File Headers
        private static string T24DebitAccountNumberCellName = "DEBIT.ACCOUNT";
        private static string T24DebitCurrencyCellName = "USD";
 

        private static string T24AmountCellName = "DEBIT.AMOUNT";
        private static string T24ValueDateCellName = "DEBIT.VALUE.DATE";
        private static string T24DebitTheirRefCellName = "DEBIT.THEIR.REF";
        private static string T24CreditTheirRefCellName = "CREDIT.THEIR.REF";
        private static string T24CreditAccountNumberCellName = "CREDIT.ACCT";
        private static string T24CreditCurrencyCellName = "EUR";
        private static string T24CreditAmountCellName = "CREDIT.ACCOUNT";
        private static string T24CreditValueDateCellName = "CREDIT.VALUE.DATE";
        

        private static string T24TreasuryRateCellName = "TREASURY.RATE";
        private static string T24DescriptionCellName = "Description";
        private static string T24TypeCellName = "TYPE";
        private static string T24CompanyCodeCellName = "COMPANY.CODE";
        private static string T24OredringCustomerCellName = "ORDERING.CUSTOMER";
        private static string T24OrderingBankCellName = "ORDERING.BANK";








        public static Status<List<TransactionSettlements>> SMT_TransactionsFileReader(string fileLocation)
        {
            Status<List<TransactionSettlements>> status = new Status<List<TransactionSettlements>>();
            List<TransactionSettlements> tsFiles = new List<TransactionSettlements>();
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
            int descriptionColNo=0;
            int amountColNo=0;
            int typeColNo =0;
            int cardNumberColNo = 0;

            for (rowCounter = 1; rowCounter <= rw; rowCounter++)
            {
                //Console.WriteLine("Row: " + rowCounter);
                if (rowCounter == 1)
                {
                    for (colCounter = 1; colCounter <= cl; colCounter++)
                    {

                        if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == SMTAmountCellName)
                        {
                            amountColNo = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == SMTDescriptionCellName)
                        {
                            descriptionColNo = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == SMTTypeCellName)
                        {
                            typeColNo = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == STMCardNumberCellName)
                        {
                            cardNumberColNo = colCounter;
                        }
                    }
                }
                else
                {
                    TransactionSettlements ts = new TransactionSettlements();
                    ts.CardNumber = (range.Cells[rowCounter, cardNumberColNo] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                    ts.Description = (range.Cells[rowCounter, descriptionColNo] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                    ts.Type = (range.Cells[rowCounter, typeColNo] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                    ts.Amount = float.Parse((range.Cells[rowCounter, amountColNo] as Microsoft.Office.Interop.Excel.Range).Value2.ToString());
                    tsFiles.Add(ts);

                }

            }

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            status.Object = tsFiles;
            status.status = true;
            return status;
        }
        public static Status<int> TransactionsSettelmentsFileCreator(List<TransactionSettlements> transactions,string branch)
        {
            Status<int> status = new Status<int>();

            try
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();

                if (xlApp == null)
                {
                    status.message = "Excel is not properly installed!";
                    status.Object = 0;
                    status.status = false;
                }

                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                //xlWorkBook = xlApp.Workbooks.Add("Transactions");

                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                int rows = transactions.Count;

                xlWorkSheet.Cells[1, 1] = T24CompanyCodeCellName;
                xlWorkSheet.Cells[1, 2] = T24DebitAccountNumberCellName;
                xlWorkSheet.Cells[1, 3] = T24DebitCurrencyCellName;
                xlWorkSheet.Cells[1, 4] = T24AmountCellName;
                xlWorkSheet.Cells[1, 5] = T24ValueDateCellName;
                xlWorkSheet.Cells[1, 6] = T24DebitTheirRefCellName;
                xlWorkSheet.Cells[1, 7] = T24CreditTheirRefCellName;
                xlWorkSheet.Cells[1, 8] = T24CreditAccountNumberCellName;
                xlWorkSheet.Cells[1, 9] = T24CreditCurrencyCellName;
                xlWorkSheet.Cells[1, 10] = T24CreditAmountCellName;
                xlWorkSheet.Cells[1, 11] = T24CreditValueDateCellName;
                xlWorkSheet.Cells[1, 12] = T24TreasuryRateCellName;
                xlWorkSheet.Cells[1, 13] = T24OredringCustomerCellName;
                xlWorkSheet.Cells[1, 14] = T24OrderingBankCellName;



                //xlWorkSheet.Cells[1, 3] = T24TypeCellName;
                //xlWorkSheet.Cells[1, 4] = T24AmountCellName;

                range = xlWorkSheet.get_Range("A1").EntireColumn;
                range.NumberFormat = "@";

                for (int i = 0; i < transactions.Count; i++)
                {

                    xlWorkSheet.Cells[1, 1] = transactions[i].CompanyCode.ToString();
                    xlWorkSheet.Cells[1, 2] = "";
                    xlWorkSheet.Cells[1, 3] = transactions[i].AccountNumber.ToString();
                    xlWorkSheet.Cells[1, 4] = "USD";
                    xlWorkSheet.Cells[1, 5] = transactions[i].Amount.ToString();
                    xlWorkSheet.Cells[1, 5] = T24ValueDateCellName;
                    xlWorkSheet.Cells[1, 6] = T24DebitTheirRefCellName;
                    xlWorkSheet.Cells[1, 7] = T24CreditTheirRefCellName;
                    xlWorkSheet.Cells[1, 8] = T24CreditAccountNumberCellName;
                    xlWorkSheet.Cells[1, 9] = T24CreditCurrencyCellName;
                    xlWorkSheet.Cells[1, 10] = T24CreditAmountCellName;
                    xlWorkSheet.Cells[1, 11] = T24CreditValueDateCellName;
                    xlWorkSheet.Cells[1, 12] = T24TreasuryRateCellName;
                    xlWorkSheet.Cells[1, 13] = T24OredringCustomerCellName;
                    xlWorkSheet.Cells[1, 14] = T24OrderingBankCellName;

                    xlWorkSheet.Cells[i + 2, 1] = transactions[i].AccountNumber.ToString();
                    xlWorkSheet.Cells[i + 2, 2] = transactions[i].Description;
                    xlWorkSheet.Cells[i + 2, 3] = transactions[i].Type;
                    xlWorkSheet.Cells[i + 2, 4] = transactions[i].Amount.ToString();
                }

                string location = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                //xlWorkBook.SaveAs(location+ @"\transactionFile.xls");
                string fileName = "TS"+"BR"+ branch +"DATE" + DateTime.Parse(DateTime.Now.ToString()).ToString("ddMMyyyyhhmmss");

                xlWorkBook.SaveAs(location+@"\"+ fileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                status.status = true;
                status.Object = transactions.Count;
                return status;
            }
            catch(Exception e)
            {
                status.status = false;
                status.Object = 0;
                status.message = e.Message;
                return status;
            }
          
        }

        public static void GenerateTemplateSpreadsheet(string fileName,List<List<string>> dataTable )
        {
            
            xlApp = new Microsoft.Office.Interop.Excel.Application();


            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);

            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            int rows = dataTable.Count;

            //Create Headers out of First Row in DataTable
            for (int i = 1; i<=dataTable[0].Count ;i++)
            {
                
                xlWorkSheet.Cells[1, i] = dataTable[0][i - 1];

            }

        
            range = xlWorkSheet.UsedRange.EntireColumn;
           // range = xlWorkSheet.get_Range("A1").EntireColumn;


            range.NumberFormat = "@";

            //Extract the other rows (Start from index No.1
            for (int i = 1; i < dataTable.Count; i++)
            {
                int cellCounter = 1;
                foreach(string cell in dataTable[i])
                {
                    xlWorkSheet.Cells[i+1, cellCounter] = dataTable[i][cellCounter-1];
                    cellCounter++;
                }
            }


            string location = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            xlWorkBook.SaveAs(location + @"\" + fileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

        }
    }
}
