using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MPBS.Database;

namespace MPBS.PersoOps
{
    public static class DeviceAndPINReader
    {
        //Read Device  Prduction File

        static string MainFileHeader = "HRLibyan Islamic Bank           ";
        public static List<EmbPINRecord> extractEMBFile(string fileLocation)
        {
            int counter = 0;
            string line;
            DateTime fileDate = DateTime.Now;
            string fileName = Path.GetFileName(fileLocation); 

            List<EmbPINRecord> records = new List<EmbPINRecord>();

            System.IO.StreamReader file = new System.IO.StreamReader(fileLocation);
          
            while ((line = file.ReadLine()) != null)
            {
                if(counter == 0)
                {
                    //get file date from first line
                   fileDate = DateTime.ParseExact(line.Substring(32, 6), "MMddyy", null);
                   counter++;
                   continue;
                }
                EmbPINRecord record = new EmbPINRecord();
                record.Sequence = counter;
                record.Line = line;
                record.FileDate = fileDate;
                record.DeviceNumber = line.Substring(16, 16);
                record.FileName = fileName;
                //In case BIN is six digits 
                record.BIN = line.Substring(2, 8).Replace(" ", "");

                counter++;
                records.Add(record);
                System.Console.WriteLine(line);
            }

            records.Remove(records[(records.Count - 1)]);

            System.Console.WriteLine(records);
            return records;
        }

        public static List<EmbPINRecord> extractPINFile(string fileLocation)
        {
            int counter = 0;
            string line;
            DateTime fileDate = DateTime.Now;
            string fileName = Path.GetFileName(fileLocation);

            List<EmbPINRecord> records = new List<EmbPINRecord>();
            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(fileLocation); ;
            while ((line = file.ReadLine()) != null)
            {
                if (counter == 0)
                {
                    //get file date from first line
                    fileDate = DateTime.ParseExact(line.Substring(32, 6), "MMddyy", null);
                    counter++;
                    continue;
                }
                EmbPINRecord record = new EmbPINRecord();
                record.Sequence = counter;
                record.Line = line;
                record.FileDate = fileDate;
                record.DeviceNumber = line.Substring(60, 16);
                record.FileName = fileName;
                //In case BIN is six digits 
                record.BIN = line.Substring(0, 6);

                counter++;
                records.Add(record);
                System.Console.WriteLine(line);
            }



            records.Remove(records[(records.Count - 1)]);
 
            System.Console.WriteLine(records);
            return records;

        }

        public static Status CreateEMBFile(List<EmbPINRecord> records,string BIN,string branch)
        {

            Status status = new Status();
            string header = MainFileHeader + DateTime.Now.ToString("MMddyy");
            //+2 for header and footer
            string[] lines = new string[records.Count+2];
            lines[0] = header;
            int counter = 1;
            foreach(var r in records)
            {
                //349-1
                lines[counter] = r.Line.Substring(0, 348) + counter.ToString().PadLeft(6,' ') + r.Line.Substring(354, 42);
                counter++;
            }
            lines[counter]= "TR" + records.Count.ToString().PadLeft(8,'0');


            //Create a file here
            string folder = DateTime.Now.ToString("dd-MM-yyyy");
            string path= Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Perso\" + BIN +@"\"+ folder + @"\" + branch;
            
            string filename = "TTVD8T0."+DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") + ".001";
            System.IO.Directory.CreateDirectory(path);

            System.IO.File.WriteAllLines((path + @"\" + filename), lines);


            return status;
             
        }

        public static Status CreatePINFile(List<EmbPINRecord> records, string BIN, string branch)
        {

            Status status = new Status();
            string header = MainFileHeader + DateTime.Now.ToString("MMddyy");
            //+2 for header and footer
            string[] lines = new string[records.Count + 2];
            lines[0] = header;
            int counter = 1;
            foreach (var r in records)
            {
                //349-1
                lines[counter] = counter.ToString().PadLeft(10, ' ') + r.Line.Substring(10);
                    //; r.Line.Substring(0, 348) + counter.ToString().PadLeft(6, ' ') + r.Line.Substring(354, 42);
                counter++;
            }
            lines[counter] = "TR" + records.Count.ToString().PadLeft(8, '0');


            //Create a file here
            string folder = DateTime.Now.ToString("dd-MM-yyyy");
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Perso\" + BIN + @"\" + folder + @"\" + branch;
            string filename = "TTXO0T0." + DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") + ".001";
            System.IO.Directory.CreateDirectory(path);

            System.IO.File.WriteAllLines((path + @"\" + filename), lines);


            return status;

        }



    }

    public class EmbPINRecord
    {
        public int Sequence;
        public String Line;
        public string DeviceNumber;
        public string FileName;
        public DateTime FileDate;
        public string BIN;
    }
}
