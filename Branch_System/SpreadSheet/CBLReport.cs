using MPBS.Database.Objects;
using MPBS.SpreadSheet.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPBS.SpreadSheet
{
    public static class CBLReports
    {

        private static Microsoft.Office.Interop.Excel.Application xlApp;
        private static Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
        private static Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
        private static Microsoft.Office.Interop.Excel.Range range;

        //CBL Reprot Header
        private static string NID = "الرقم الوطني";
        private static string CustomerID = "رقم الحساب";
        private static string Branch = "الفرع";
        private static string Date = "التاريخ";
        private static string ExchangeRate = "سعر الصرف";
        private static string AmountLYD = "القيمة بالدينار";
        private static string AmountUSD = "القيمة بالدولار";




        public static Status<List<CBLLoadReport>> CBLLoadReportReader(string fileLocation)
        {
            Status<List<CBLLoadReport>> status = new Status<List<CBLLoadReport>>();
            List<CBLLoadReport> cbRecords = new List<CBLLoadReport>();
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
            int nid = 0;
            int customerID = 0;
            int branch = 0;
            int date = 0;
            int exchangeRate = 0;
            int amountLYD = 0;
            int amountUSD = 0;


            for (rowCounter = 1; rowCounter <= rw; rowCounter++)
            {
                //Console.WriteLine("Row: " + rowCounter);
                if (rowCounter == 1)
                {
                    for (colCounter = 1; colCounter <= cl; colCounter++)
                    {

                        if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == CBLReports.NID)
                        {
                            nid = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == CustomerID)
                        {
                            customerID = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == Branch)
                        {
                            branch = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2 .ToString() == Date)
                        {
                            date = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == ExchangeRate)
                        {
                            exchangeRate = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == AmountLYD)
                        {
                            amountLYD = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == AmountUSD)
                        {
                            amountUSD = colCounter;
                        }
                    }
                }
                else
                {
                    CBLLoadReport cbl = new CBLLoadReport();
                    cbl.NID = (range.Cells[rowCounter, nid] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                    cbl.CustomerID = (range.Cells[rowCounter, customerID] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                    cbl.CustomerID = cbl.CustomerID.Substring(0, 7);
                    cbl.BranchCode = getBranchCode((range.Cells[rowCounter, branch] as Microsoft.Office.Interop.Excel.Range).Value2.ToString());
                    cbl.Date = (range.Cells[rowCounter, date] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();

                    //cbl.Date = (range.Cells[rowCounter, date] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                    cbl.Date = DateTime.Parse(ConvertToDateTime(cbl.Date)).ToString("yyyy-MM-dd");

                    cbl.ExchangeRate = (range.Cells[rowCounter, exchangeRate] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                    cbl.AmountLYD = (range.Cells[rowCounter, amountLYD] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                    cbl.AmountUSD = (range.Cells[rowCounter, amountUSD] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();



                    cbRecords.Add(cbl);

                }

            }

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            status.Object = cbRecords;
            status.status = true;
            return status;
        }

        public static string ConvertToDateTime(string strExcelDate)
        {
            double excelDate;
            try
            {
                excelDate = Convert.ToDouble(strExcelDate);
            }
            catch
            {
                return strExcelDate;
            }
            if (excelDate < 1)
            {
                throw new ArgumentException("Excel dates cannot be smaller than 0.");
            }
            DateTime dateOfReference = new DateTime(1900, 1, 1);
            if (excelDate > 60d)
            {
                excelDate = excelDate - 2;
            }
            else
            {
                excelDate = excelDate - 1;
            }
            return dateOfReference.AddDays(excelDate).ToShortDateString();
        }
        public static string getBranchCode(string name)
        {
            if (name.Contains("المصرف الإسلامي - الرئيسي"))
            {
                return "1002";
            }
            if (name.Contains("المصرف الإسلامي - فرع تاجوراء"))
            {
                return "1004";
            }
            if (name.Contains("المصرف الاسلامي - فرع مصراتة"))
            {
                return "1005";
            }
            if (name.Contains("المصرف الإسلامي - فرع السواني"))
            {
                return "1006";
            }
            if (name.Contains("المصرف الإسلامي - فرع هون"))
            {
                return "1007";
            }
            if (name.Contains("لمصرف الاسلامي - فرع السياحية"))
            {
                return "1008";
            }
            else
            {
                return null;
            }





        }
    }
}
