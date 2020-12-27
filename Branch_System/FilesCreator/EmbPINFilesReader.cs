using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MPBS.Database;

namespace MPBS.FilesCreator
{
  
    public static class PINFileRecordsReorder
    {
        private static string header = "HRLibyan Islamic Bank           ";
        private static string footer = "TR";


        public static List<EmbPINRecord> extractPINString(string fileLocation)
        {
            int counter = 0;
            string line;
            List<EmbPINRecord> records = new List<EmbPINRecord>();
            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(fileLocation);;
            while ((line = file.ReadLine()) != null)
            {
                EmbPINRecord record = new EmbPINRecord();
                //it is header
                record.Sequence = counter;
                record.Line = line;
                //if (counter > 0 && counter < 27)
                //{
                    
                //    record.PAN = line.Substring(60, 16);             
                //}

                counter++;
                records.Add(record);
                System.Console.WriteLine(line);
            }

            records.Remove(records[0]);
            records.Remove(records[(records.Count - 1)]);
            foreach(EmbPINRecord r in records)
            {
                r.PAN = r.Line.Substring(60, 16);
            }
            System.Console.WriteLine(records);
            return records;

        }


        public static List<EmbPINRecord> extractEMBString(string fileLocation)
        {
            int counter = 0;
            string line;
            List<EmbPINRecord> records = new List<EmbPINRecord>();
            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(fileLocation); ;
            while ((line = file.ReadLine()) != null)
            {
                EmbPINRecord record = new EmbPINRecord();
                //it is header
                record.Sequence = counter;
                record.Line = line;
                //if (counter > 0 && counter < 27)
                //{

                //    record.PAN = line.Substring(60, 16);             
                //}

                counter++;
                records.Add(record);
                System.Console.WriteLine(line);
            }

            records.Remove(records[0]);
            records.Remove(records[(records.Count - 1)]);
            foreach (EmbPINRecord r in records)
            {
                r.PAN = r.Line.Substring(16, 16);
            }
            System.Console.WriteLine(records);
            return records;
        }

        /// <summary>
        /// Sort PIN file based on Emb File
        /// </summary>
        /// <param name="embFile"></param>
        /// <param name="pinFile"></param>
        /// <returns></returns>
        public static List<EmbPINRecord> sortPINFile(List<EmbPINRecord> embFile, List<EmbPINRecord> pinFile)
        {
            List<EmbPINRecord> sortedPINs = new List<EmbPINRecord>();
           foreach(EmbPINRecord pin in pinFile)
            {
                pin.Sequence = embFile.First(i => i.PAN == pin.PAN).Sequence;
                var aStringBuilder = new StringBuilder(pin.Line);
                aStringBuilder.Remove(4, 6);
                aStringBuilder.Insert(4, pin.Sequence.ToString().PadLeft(6,' '));
                pin.Line = aStringBuilder.ToString();
                sortedPINs.Add(pin);
            }



            return sortedPINs.OrderBy(i => i.Sequence).ToList<EmbPINRecord>();
        }

        public static Status generatePINFile(List<EmbPINRecord> pinFile)
        {
            Status status = new Status();
            status.status = false;
            string fileName = "TTXO0T0." + DateTime.Now.Year + "-" + DateTime.Now.Month.ToString().PadLeft(2, '0') + "-" + DateTime.Now.Day.ToString().PadLeft(2, '0') + DateTime.Now.Hour.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString().PadLeft(2, '0') + DateTime.Now.Millisecond.ToString().PadLeft(2, '0') + ".Sorted";
            string file = String.Format(MPBSConfig.PINFiles + @"\" + fileName);

            try
            {
                // Check if file already exists. If yes, delete it.     


                // Create a new file 
                using (StreamWriter fs = File.CreateText(file))
                {
                    //Write header
                    fs.WriteLine(header);
                    foreach(var record in pinFile)
                    {
                        fs.WriteLine(record.Line);
                    }
                    //Write Footer  
                    fs.WriteLine(footer);

                    status.status = true;

                }
                return status;
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
                status.status = false;
                status.message = Ex.Message;
                return status;
            }
        }
    }

    public class EmbPINRecord
    {
        public int Sequence;
        public String Line;
        public string PAN;
    }
}
