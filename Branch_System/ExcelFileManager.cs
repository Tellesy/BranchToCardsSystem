using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace Branch_System
{
   public static class ExcelFileManager
    {

        private static string TodayFile;

        public static void CreateExcelSheet(string Product)
        {
            string day = DateTime.Today.Day.ToString();
            if (DateTime.Today.Day < 10)
            {
                day = "0" + day;
            }

            string month = DateTime.Today.Month.ToString();
            if (DateTime.Today.Month < 10)
            {
                month = "0" + month;
            }

            TodayFile = day + month + DateTime.Today.Year.ToString();
            string file = String.Format(@"C:\BranchToCards\{0}-{1}.xlsx", TodayFile,Product);

            if (File.Exists(file))
            {
                return;
            }
            else
            using (ExcelPackage excel = new ExcelPackage())
            {
                    excel.Workbook.Worksheets.Add("IR");
                    createTables(excel.Workbook.Worksheets["IR"], "IR");
                    excel.Workbook.Worksheets.Add("I");
                    createTables(excel.Workbook.Worksheets["I"], "I");
                    excel.Workbook.Worksheets.Add("RFirst");
                    createTables(excel.Workbook.Worksheets["RFirst"], "RFirst");
                    excel.Workbook.Worksheets.Add("R");
                    createTables(excel.Workbook.Worksheets["R"], "R");
                    excel.Workbook.Worksheets.Add("ReI");
                    createTables(excel.Workbook.Worksheets["ReI"], "ReI");
                    excel.Workbook.Worksheets.Add("PIN");
                    createTables(excel.Workbook.Worksheets["PIN"], "PIN");

                    FileInfo excelFile = new FileInfo(file);
                
                    excel.SaveAs(excelFile);
            }
        }

        public static void createTables(ExcelWorksheet ws, string TableName)
        {
            ws.Cells[1, 1].Value = "Card_Number";
            ws.Cells[1, 2].Value = "Card_Account";
            ws.Cells[1, 3].Value = "Name";
            ws.Cells[1, 4].Value = "Account";
            ws.Cells[1, 5].Value = "EXP date YYMM";
            ws.Cells[1, 6].Value = "Old Amount";
            ws.Cells[1, 7].Value = "New Amount";
            ws.Cells[1, 8].Value = "Passport";
            ws.Cells[1, 9].Value = "Phone";
            ws.Cells[1, 10].Value = "PO_Begin Date MMYY";
            ws.Cells[1, 11].Value = "PO_EXP Date MMYY";
            ws.Cells[1, 12].Value = "Birthdate";
            ws.Cells[1, 13].Value = "Email";

            ws.Tables.Add(ws.Cells[1, 1, 301, 13], TableName);
        }

        public static void AddToExcelSheet(List<string> card, string Product, string sheet)
        {
            string fileName = (@"C:\BranchToCards\" + TodayFile + "-" + Product + ".xlsx");
            string connectionString = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source={0};Extended Properties='Excel 12.0;HDR=YES;IMEX=0'", fileName);


            using (OleDbConnection cn = new OleDbConnection(connectionString))
            {

                cn.Open();
              
                    OleDbCommand cmd1 = new OleDbCommand("INSERT INTO [" + sheet + "$] " +
                     "([Card_Number],[Card_Account],[Name],[Account],[EXP date YYMM],[Old Amount],[New Amount],[Passport],[Phone]," +
                     "[PO_Begin Date MMYY],[PO_EXP Date MMYY],[Birthdate],[Email])" +

                     "VALUES(@value1, @value2, @value3,@value4, @value5, @value6,@value7, @value8, @value9,@value10, @value11, @value12,@value13)", cn);

                    cmd1.Parameters.AddWithValue("@value1", card[0].ToString());
                    cmd1.Parameters.AddWithValue("@value2", card[1].ToString());
                    cmd1.Parameters.AddWithValue("@value3", card[2].ToString());
                    cmd1.Parameters.AddWithValue("@value4", card[3].ToString());
                    cmd1.Parameters.AddWithValue("@value5", card[4].ToString());
                    cmd1.Parameters.AddWithValue("@value6", card[5].ToString());
                    cmd1.Parameters.AddWithValue("@value7", card[6].ToString());
                    cmd1.Parameters.AddWithValue("@value8", card[7].ToString());
                    cmd1.Parameters.AddWithValue("@value9", card[8].ToString());
                    cmd1.Parameters.AddWithValue("@value10", card[9].ToString());
                    cmd1.Parameters.AddWithValue("@value11", card[10].ToString());
                    cmd1.Parameters.AddWithValue("@value12", card[11].ToString());
                    cmd1.Parameters.AddWithValue("@value13", card[12].ToString());

                    cmd1.ExecuteNonQuery();

                    cn.Close();
            }
        }
    }

}
