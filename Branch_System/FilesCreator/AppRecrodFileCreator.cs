using CTS.Database.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CTS.FilesCreator
{
    public static class AppRecrodFileCreator
    {
        private static string bankCode = "020354";

       public static Status<int> GenerateAppRecordFile(List<PTSAppRecord> records)
        {
            Status<int> statusObject = new Status<int>();


            return statusObject;
        }

        public static Status<int> GenerateAppRecordFilesBasedOnProgramCode(List<PTSAppRecord> records)
        {
            Status<int> statusObject = new Status<int>();


            return statusObject;
        }


        private static string getHeader()
        {
            var today = DateTime.Today;
            string day = today.Day.ToString().PadLeft(2, '0');
            string month = today.Month.ToString().PadLeft(2, '0');
            string year = today.Year.ToString();

            string hour = today.Hour.ToString().PadLeft(2, '0');
            string minutes = today.Minute.ToString().PadLeft(2, '0');
            string seconds = today.Second.ToString().PadLeft(2, '0');
            string header = "HD" + "|" + bankCode + "|" + day + month + year + hour + minutes + seconds + "|" + "2.0"; 

            return header;
        }

        private static string getFooter(int count)
        {
            string recordCount = count.ToString().PadLeft(9, '0');
            string footer = "FT" + "|" + recordCount;
            return footer;
        }


        public static string extractRecordsString(PTSAppRecord record)
        {

            string recordString = "";

            PropertyInfo[] properties = typeof(PTSAppRecord).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                //property.SetValue(record, value);

                Console.WriteLine(property);
                
            }

            //Console.WriteLine(properties.GetValue());
            //Object.keys(record).forEach(function(key) {
            //    if (key == '_bankCode')
            //    {
            //        record[key] = bankCode;
            //    }

            //    var value = record[key];

            //    if (!value)
            //    {
            //        value = '';
            //    }

            //    if (recordString == '')
            //    {
            //        recordString = value;
            //    }
            //    else recordString = recordString + '|' + value;
            //}); //end the record with '|' 
            //    //recordString = recordString+'|';

            //console.log(recordString);
            return recordString;
        }
    }
}
