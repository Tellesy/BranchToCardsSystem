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

        private string[] Headers;
        

        public void setHeaders(string[] headers)
        {
            Headers = headers;
        }
    }
}
