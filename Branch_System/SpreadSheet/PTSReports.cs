using MPBS.Database.Objects;
using MPBS.SpreadSheet.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPBS.SpreadSheet
{
    public static class PTSReports
    {

        private static Microsoft.Office.Interop.Excel.Application xlApp;
        private static Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
        private static Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
        private static Microsoft.Office.Interop.Excel.Range range;

        //PTS Application Approve Report
        private static string PTSClientCode = "Client Code";
        private static string PTSCustomerID = "Client Customer Id";
        private static string PTSWalletNumber = "Wallet Number";
        private static string PTSDeviceNumber = "Device Number";
        private static string PTSDevicePackID   = "Device Pack ID";



        public static Status<List<ApplicationApproveReport>> PTS_ApplicationApproveReportUpload(string fileLocation)
        {
            Status<List<ApplicationApproveReport>> status = new Status<List<ApplicationApproveReport>>();
            List<ApplicationApproveReport> arFiles = new List<ApplicationApproveReport>();
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
            int clientCodeColNo = 0;
            int customerIDColNo = 0;
            int walletNumberColNo = 0;
            int deviceNumberColNo = 0;
            int devicePackIDColNo = 0;

            for (rowCounter = 1; rowCounter <= rw; rowCounter++)
            {
                //Console.WriteLine("Row: " + rowCounter);
                if (rowCounter == 1)
                {
                    for (colCounter = 1; colCounter <= cl; colCounter++)
                    {

                        if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == PTSClientCode)
                        {
                            clientCodeColNo = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == PTSCustomerID)
                        {
                            customerIDColNo = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == PTSWalletNumber)
                        {
                            walletNumberColNo = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == PTSDeviceNumber)
                        {
                            deviceNumberColNo = colCounter;
                        }
                        else if ((range.Cells[rowCounter, colCounter] as Microsoft.Office.Interop.Excel.Range).Value2.ToString() == PTSDevicePackID)
                        {
                            devicePackIDColNo = colCounter;
                        }
                    }
                }
                else
                {
                    ApplicationApproveReport aar = new ApplicationApproveReport();
                    aar.ClientCode = (range.Cells[rowCounter, clientCodeColNo] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                    aar.CBSCustomerID = (range.Cells[rowCounter, customerIDColNo] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                    aar.WalletNumber = (range.Cells[rowCounter, walletNumberColNo] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                    aar.DeviceNumber = (range.Cells[rowCounter, deviceNumberColNo] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                    aar.DevicePackID = (range.Cells[rowCounter, devicePackIDColNo] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();

                    arFiles.Add(aar);

                }

            }

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            status.Object = arFiles;
            status.status = true;
            return status;
        }



    }
}
