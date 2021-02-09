using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MPBS
{
   public static class MPBSConfig
    {
        public static string serverAddress = "10.128.130.119";
        public static string PTSBankCode = "020354";
        public static string rootLocation = @"C:\Users\Public\MPBS\";
        public static string PTSLocation = String.Format(rootLocation + @"PTS\");

        private static string ConfigFileLocation = @"\\" + serverAddress + @"\mpbs\Settings\config.xml";


        public static string PTSApplicationFiles = String.Format(PTSLocation + "PTSApplication");
        public static string PTSLoadFiles = String.Format(PTSLocation + "PTSLoad");
        public static string PINFiles = String.Format(PTSLocation + "PIN");
        public static string Logs = String.Format(PTSLocation + "Logs");



        //Features
        public static bool PTSLoad = true;

        public static void CreateFolders()
        {
            System.IO.Directory.CreateDirectory(rootLocation);
            System.IO.Directory.CreateDirectory(PTSLocation);

            System.IO.Directory.CreateDirectory(PTSApplicationFiles);
            System.IO.Directory.CreateDirectory(PTSLoadFiles);
            System.IO.Directory.CreateDirectory(PINFiles);
            System.IO.Directory.CreateDirectory(Logs);

        }

        public static void getConfigFromServer()
        {
            //var xml = XDocument.Load(ConfigFileLocation);
            //var list = xml.Descendants("MPBS");
            //Console.WriteLine("Hello");
            //var load = from c in xml.Descendants("MPBS").Descendants("Features").Descendants("PTS")

            //            select c.Element("Load").Value;

            ////PTSLoad = Boolean.Parse(load.First().get);

            //Console.WriteLine(PTSLoad.ToString());
        }
    }
}
