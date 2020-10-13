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


            //Add Bank code;
            recordString += bankCode + "|";
           

            //Add Form Number
            recordString += record.FromNumber + "|";

            //Add Application Sub Type
            recordString += record.ApplicationSubType + "|";

            //Add Customer Type
            if (string.IsNullOrWhiteSpace(record.CustomerType))
                record.CustomerType = "0";
            recordString += record.CustomerType + "|";

            //Add Program Code
            recordString += record.ProgramCode + "|";

            //Add Existing Device Number
            if (string.IsNullOrWhiteSpace(record.ExistingDeviceNumber))
                record.ExistingDeviceNumber = "";
            recordString += record.ExistingDeviceNumber + "|";

            //Add Existing Client Code
            if (string.IsNullOrWhiteSpace(record.ExistingClientCode))
                record.ExistingClientCode = "";
            recordString += record.ExistingClientCode + "|";

            //Add Existing Add-on Client Code
            if (string.IsNullOrWhiteSpace(record.ExistingAddonClientCode))
                record.ExistingAddonClientCode = "";
            recordString += record.ExistingAddonClientCode + "|";


            //Add Relation with Primary Client
            if (string.IsNullOrWhiteSpace(record.RelationwithPrimaryClient))
                record.RelationwithPrimaryClient = "";
            recordString += record.RelationwithPrimaryClient + "|";

            //Add Relation with Wallet Plan 1 Promo
            if (string.IsNullOrWhiteSpace(record.WalletPlan1Promo))
                record.WalletPlan1Promo = "";
            recordString += record.WalletPlan1Promo + "|";

            //Add  Wallet Plan 2 Promo
            if (string.IsNullOrWhiteSpace(record.WalletPlan2Promo))
                record.WalletPlan2Promo = "";
            recordString += record.WalletPlan2Promo + "|";

            //Add Wallet Plan 3 Promo
            if (string.IsNullOrWhiteSpace(record.WalletPlan3Promo))
                record.WalletPlan3Promo = "";
            recordString += record.WalletPlan3Promo + "|";


            //Add  Wallet Plan 3 Promo
            if (string.IsNullOrWhiteSpace(record.WalletPlan3Promo))
                record.WalletPlan3Promo = "";
            recordString += record.WalletPlan3Promo + "|";

            //Add Device Type 1
            if (string.IsNullOrWhiteSpace(record.DeviceType1))
                record.DeviceType1 = "4";
            recordString += record.DeviceType1 + "|";

            //Add Device Plan Code 1
            if (string.IsNullOrWhiteSpace(record.DevicePlanCode1))
                record.DevicePlanCode1 = "";
            recordString += record.DevicePlanCode1 + "|";

            //Add Device Plan Promo Code 1
            if (string.IsNullOrWhiteSpace(record.DevicePlanPromoCode1))
                record.DevicePlanPromoCode1 = "";
            recordString += record.DevicePlanPromoCode1 + "|";

            //Add Device Photo Indicator  1
            if (string.IsNullOrWhiteSpace(record.DevicePhotoIndicator1))
                record.DevicePhotoIndicator1 = "";
            recordString += record.DevicePhotoIndicator1 + "|";


            //Add Device Type 2
            if (string.IsNullOrWhiteSpace(record.DeviceType2))
                record.DeviceType2 = "";
            recordString += record.DeviceType2 + "|";

            //Add Device Plan Code 2
            if (string.IsNullOrWhiteSpace(record.DevicePlanCode2))
                record.DevicePlanCode2 = "";
            recordString += record.DevicePlanCode2 + "|";

            //Add Device Plan Promo Code 2
            if (string.IsNullOrWhiteSpace(record.DevicePlanPromoCode2))
                record.DevicePlanPromoCode2 = "";
            recordString += record.DevicePlanPromoCode2 + "|";

            //Add Device Photo Indicator  2
            if (string.IsNullOrWhiteSpace(record.DevicePhotoIndicator2))
                record.DevicePhotoIndicator2 = "";
            recordString += record.DevicePhotoIndicator2 + "|";






            return recordString;
        }
    }
}
