using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPBS.Database.Objects;
using MPBS.SpreadSheet.Structure;


namespace MPBS.SpreadSheet
{
    public class GenericSpreadsheetReader
    {
        private Microsoft.Office.Interop.Excel.Application xlApp;
        private Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
        private Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
        private Microsoft.Office.Interop.Excel.Range range;

        private List<SpreadSheetHeader> Headers;
        


        public void setHeaders(List<SpreadSheetHeader> headers)
        {
            Headers = headers;
        }

        public List<SpreadSheetColumn> readSpreadSheetFile(string fileLocation)
        {
            List<SpreadSheetColumn> content = new List<SpreadSheetColumn>();
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


            for (rowCounter = 1; rowCounter <= rw; rowCounter++)
            {
                //Console.WriteLine("Row: " + rowCounter);
                if (rowCounter == 1)
                {
                    //for (colCounter = 1; colCounter <= cl; colCounter++)
                    //{

                    //    if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == SMTAmountCellName)
                    //    {
                    //        amountColNo = colCounter;
                    //    }
                    //    else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == SMTDescriptionCellName)
                    //    {
                    //        descriptionColNo = colCounter;
                    //    }
                    //    else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == SMTTypeCellName)
                    //    {
                    //        typeColNo = colCounter;
                    //    }
                    //    else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == STMCardNumberCellName)
                    //    {
                    //        cardNumberColNo = colCounter;
                    //    }
                    //}
                }
                else
                {
                    foreach(var header in Headers)
                    {
                        SpreadSheetColumn sc = new SpreadSheetColumn();
                        sc.Row = rowCounter;
                        sc.Index = header.Index;
                        sc.Content = (range.Cells[rowCounter, header.Index] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                        content.Add(sc);
                    }
                   
                  

                }

            }

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();
            return content;
        }
    }
}
