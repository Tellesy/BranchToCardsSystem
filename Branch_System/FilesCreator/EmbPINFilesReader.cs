using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPBS.FilesCreator
{
  
    public static class EmbPINFilesReader
    {
        private static string header = "HRLibyan Islamic Bank           ";
        private static string footer = "TR";


        public static List<EmbPINRecord> ExtractRecordsFromFiles(string fileLocation)
        {
            int counter = 0;
            string line;
            List<EmbPINRecord> records = new List<EmbPINRecord>();

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(fileLocation);
            while ((line = file.ReadLine()) != null)
            {
                EmbPINRecord record = new EmbPINRecord();
                record.Sequence = counter;
                record.Line = line;
                records.Add(record);
                System.Console.WriteLine(line);
                counter++;
            }

            //Remove header and footer
            records.Remove(records[0]);
            records.Remove(records[(records.Count - 1)]);
            System.Console.WriteLine(records);
            return records;
             
        }
    }

    public class EmbPINRecord
    {
        public int Sequence;
        public String Line;
    }
}
