using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPBS
{
   public static class MPBSConfig
    {
        public static string PTSBankCode = "020354";
        public static string rootLocation = @"C:\Users\Public\MPBS\";
        public static string PTSLocation = String.Format(rootLocation + @"PTS\");


        public static string PTSApplicationFiles = String.Format(PTSLocation + "PTSApplication");
        public static string PTSLoadFiles = String.Format(PTSLocation + "PTSLoad");
        public static string PINFiles = String.Format(PTSLocation + "PIN");

        public static void CreateFolders()
        {
            System.IO.Directory.CreateDirectory(rootLocation);
            System.IO.Directory.CreateDirectory(PTSLocation);

            System.IO.Directory.CreateDirectory(PTSApplicationFiles);
            System.IO.Directory.CreateDirectory(PTSLoadFiles);
            System.IO.Directory.CreateDirectory(PINFiles);
        }

    }
}
