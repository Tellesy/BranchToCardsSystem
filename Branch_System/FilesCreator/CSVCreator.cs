//using System;
//using System.IO;
//using System.Text;
//using CsvHelper;

//namespace MPBS.FilesCreator
//{
//    public static class CSVCreator
//    {
//        public static void GenerateTemplateSpreadsheet(string fileName, List<List<string>> dataTable)
//        {

//            //var data = new[]
//            // {
//            //    new Project { CustomerName = "Big Corp", Title = "CRM updates", Deadline = DateTime.Today.AddDays(-2) },
//            //    new Project { CustomerName = "Imaginary Corp", Title = "Sales system", Deadline = DateTime.Today.AddDays(1) }
//            //};

//            using (var mem = new MemoryStream())
//            using (var writer = new StreamWriter(mem))
//            using (var csvWriter = new CsvWriter(writer))
//            {
//                csvWriter.Configuration.Delimiter = ";";
//                csvWriter.Configuration.HasHeaderRecord = true;
//                csvWriter.Configuration.AutoMap<Project>();

//                csvWriter.WriteHeader<Project>();
//                csvWriter.WriteRecords(data);

//                writer.Flush();
//                var result = Encoding.UTF8.GetString(mem.ToArray());
//                Console.WriteLine(result);
//            }

//            int rows = dataTable.Count;

//            //Create Headers out of First Row in DataTable
//            for (int i = 1; i <= dataTable[0].Count; i++)
//            {

//                xlWorkSheet.Cells[1, i] = dataTable[0][i - 1];

//            }


//            range = xlWorkSheet.UsedRange.EntireColumn;
//            // range = xlWorkSheet.get_Range("A1").EntireColumn;


//            range.NumberFormat = "@";

//            //Extract the other rows (Start from index No.1
//            for (int i = 1; i < dataTable.Count; i++)
//            {
//                int cellCounter = 1;
//                foreach (string cell in dataTable[i])
//                {
//                    xlWorkSheet.Cells[i + 1, cellCounter] = dataTable[i][cellCounter - 1];
//                    cellCounter++;
//                }
//            }


//            string location = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
//            xlWorkBook.SaveAs(location + @"\" + fileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
//            xlWorkBook.Close(true, misValue, misValue);
//            xlApp.Quit();

//        }
//    }
//}
