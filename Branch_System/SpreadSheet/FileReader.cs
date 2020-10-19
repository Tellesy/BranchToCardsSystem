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
        private static string AmountCellName = "AMOUNT USD";
        private static string DescriptionCellName = "LOCALITY";
        private static string TypeCellName = "TYPE";
        private static string CardNumberCellName = "CARDHOLDER";





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

                        if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == AmountCellName)
                        {
                            amountColNo = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == DescriptionCellName)
                        {
                            descriptionColNo = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == TypeCellName)
                        {
                            typeColNo = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == CardNumberCellName)
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
    }
}
