using CTS.Database.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CTS.FilesCreator
{
   
    public static class AppRecrodFileCreator
    {
        private static string bankCode = "020354";
        public static string rootLocation = @"C:\Users\Public\CTS\";
        public static string PTSLocation = String.Format(rootLocation + @"PTS\");


        public static string PTSApplicationFiles = String.Format(PTSLocation + "PTSApplication");
        public static string PTSLoadFiles = String.Format(PTSLocation + "PTSLoad");

        public static void CreateFolders()
        {
            System.IO.Directory.CreateDirectory(rootLocation);
            System.IO.Directory.CreateDirectory(PTSLocation);

            System.IO.Directory.CreateDirectory(PTSApplicationFiles);
            System.IO.Directory.CreateDirectory(PTSLoadFiles);
        }

        public static Status<int> GenerateAppRecordFile(List<PTSAppRecord> records)
        {
            Status<int> statusObject = new Status<int>();
            List<string> recordStrings = new List<string>();

            foreach(PTSAppRecord record in records)
            {
                recordStrings.Add(extractRecordsString(record));
            }

            string fileName = getFileName();
            string header = getHeader();
            string footer = getFooter(recordStrings.Count);

            createAppFile(fileName, header, footer, recordStrings);
            
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

        private static string getFileName()
        {
            string name = "APPPR"+bankCode;
            int seq = 1;
            var today = DateTime.Today;
            

            string DD = today.Day.ToString().PadLeft(2,'0');
            string MM = today.Month.ToString().PadLeft(2, '0');
            string YY = today.Year.ToString().Substring(2, 2);
            string hh = today.Hour.ToString().PadLeft(2, '0');
            string mm = today.Minute.ToString().PadLeft(2, '0');
            string ss = today.Second.ToString().PadLeft(2, '0');

            name += DD + MM + YY + hh + mm + ss;

            bool exist = true;
            do
            {
                exist = checkFileExist(name + seq.ToString().PadLeft(6, '0')+".dat");
                seq++;


            } while (exist);

            name += seq.ToString().PadLeft(6, '0') + ".dat";
            return name;
        }
        private static string extractRecordsString(PTSAppRecord record)
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


            //Add Device Type 3
            if (string.IsNullOrWhiteSpace(record.DeviceType3))
                record.DeviceType3 = "";
            recordString += record.DeviceType3 + "|";

            //Add Device Plan Code 3
            if (string.IsNullOrWhiteSpace(record.DevicePlanCode3))
                record.DevicePlanCode3 = "";
            recordString += record.DevicePlanCode3 + "|";

            //Add Device Plan Promo Code 3
            if (string.IsNullOrWhiteSpace(record.DevicePlanPromoCode3))
                record.DevicePlanPromoCode3 = "";
            recordString += record.DevicePlanPromoCode3 + "|";

            //Add Device Photo Indicator  3
            if (string.IsNullOrWhiteSpace(record.DevicePhotoIndicator3))
                record.DevicePhotoIndicator3 = "";
            recordString += record.DevicePhotoIndicator3 + "|";


            //Add Device Type 4
            if (string.IsNullOrWhiteSpace(record.DeviceType4))
                record.DeviceType4 = "";
            recordString += record.DeviceType4 + "|";

            //Add Device Plan Code 4
            if (string.IsNullOrWhiteSpace(record.DevicePlanCode4))
                record.DevicePlanCode4 = "";
            recordString += record.DevicePlanCode4 + "|";

            //Add Device Plan Promo Code 4
            if (string.IsNullOrWhiteSpace(record.DevicePlanPromoCode4))
                record.DevicePlanPromoCode4 = "";
            recordString += record.DevicePlanPromoCode4 + "|";

            //Add Device Photo Indicator  4
            if (string.IsNullOrWhiteSpace(record.DevicePhotoIndicator4))
                record.DevicePhotoIndicator4 = "";
            recordString += record.DevicePhotoIndicator4 + "|";



            //Add Device Type 5
            if (string.IsNullOrWhiteSpace(record.DeviceType5))
                record.DeviceType5 = "";
            recordString += record.DeviceType5 + "|";

            //Add Device Plan Code 5
            if (string.IsNullOrWhiteSpace(record.DevicePlanCode5))
                record.DevicePlanCode5 = "";
            recordString += record.DevicePlanCode5 + "|";

            //Add Device Plan Promo Code 5
            if (string.IsNullOrWhiteSpace(record.DevicePlanPromoCode5))
                record.DevicePlanPromoCode5 = "";
            recordString += record.DevicePlanPromoCode5 + "|";

            //Add Device Photo Indicator  5
            if (string.IsNullOrWhiteSpace(record.DevicePhotoIndicator5))
                record.DevicePhotoIndicator5 = "";
            recordString += record.DevicePhotoIndicator5 + "|";


            //Add Device Type 6
            if (string.IsNullOrWhiteSpace(record.DeviceType6))
                record.DeviceType6 = "";
            recordString += record.DeviceType6 + "|";

            //Add Device Plan Code 6
            if (string.IsNullOrWhiteSpace(record.DevicePlanCode6))
                record.DevicePlanCode6 = "";
            recordString += record.DevicePlanCode6 + "|";

            //Add Device Plan Promo Code 6
            if (string.IsNullOrWhiteSpace(record.DevicePlanPromoCode6))
                record.DevicePlanPromoCode6 = "";
            recordString += record.DevicePlanPromoCode6 + "|";

            //Add Device Photo Indicator  6
            if (string.IsNullOrWhiteSpace(record.DevicePhotoIndicator6))
                record.DevicePhotoIndicator6 = "";
            recordString += record.DevicePhotoIndicator6 + "|";

            //Add Branch Code
            recordString += record.BranchCode.PadLeft(6, '0') + "|";


            //Add Corporate Client Code
            if (string.IsNullOrWhiteSpace(record.CorporateClientCode))
                record.CorporateClientCode = "";
            recordString += record.CorporateClientCode + "|";

            //Add Title
            recordString += record.Customer.Title + "|";

            //Add First Name
            recordString += record.Customer.FirstName + "|";

            //Middle Name 1 (Father Name)
            recordString += record.Customer.FatherName + "|";

            //Middle Name 2
            recordString += "|";

            //Add Last Name
            recordString += record.Customer.LastName + "|";

            //Add Gender
            recordString += record.Customer.Gender + "|";

            //Add Maiden Name
            recordString += "|";

            //Married
            recordString += "0" + "|";

            //Nationality
            recordString += record.Customer.Nationality + "|";

            //Birthdate
            recordString += record.Customer.Birthdate + "|";

            //Birth City 
            recordString +="|";

            //Birth Country
            recordString += "|";

            //Education
            recordString += "|";

            //Birth Country
            recordString += "|";

            //VIP Flag
            recordString += "|";

            //Embossed Name
            recordString += record.Customer.EmbossedName + "|";

            //Encoded Name
            recordString += "|";

            //KYC Status
            recordString += "Y" + "|";

            //KYC Remarks
            recordString += "KYC Compliant" + "|";

            //Travel Purpos
            recordString += "|";

            //Picture Code
            recordString += "|";

            //Photo Code
            recordString += "|";

            //Preferred Mailing Address
            recordString += "C" + "|";

            //Current Address Line 1
            recordString += record.Customer.Address + "|";

            //Current Address Line 2
            recordString += "|";

            //Current Address Line 3
            recordString += "|";

            //Current Address Line 4
            recordString += "|";

            //Current City Code
            recordString += "|";

            //Current State Code
            recordString += "|";

            //Current Country Code
            recordString += "434" + "|";

            //Current ZIP Code
            recordString += "|";

            //Current Phone Number 1
            recordString += record.Customer.Phone + "|";

            //Current Phone Number 2
            recordString += "|";

            //Permanent Address Line 1
            recordString += "|";

            //Permanent Address Line 2
            recordString += "|";

            //Permanent Address Line 3
            recordString += "|";

            //Permanent Address Line 4
            recordString += "|";

            //Permanent City Code
            recordString += "|";

            //Permanent State Code
            recordString += "|";

            //Permanent Country Code
            recordString += "434" + "|";

            //Permanent ZIP Code
            recordString += "|";

            //Permanent Phone Number 1
            recordString += "|";

            //Permanent Phone Number 2
            recordString += "|";

            //Fax Number 
            recordString += "|";

            //Register for DNCR
            recordString += "|";

            //SMS Alert
            recordString += "Y" + "|";

            //Email Alert
            recordString += "Y" + "|";

            //Statement Preference
            recordString += "B" + "|";

            //Delivery Mode
            recordString += "|";

            //Mobile ISD  Code
            recordString += record.Customer.PhoneISD + "|";

            //Mobile Number
            recordString += record.Customer.Phone + "|";

            //Email
            recordString += record.Customer.Email + "|";

            //Language Preference
            recordString += "ar" + "|";

            //Office Address Line 1
            recordString += "|";

            //Office Address Line 2
            recordString += "|";

            //Office Address Line 3
            recordString += "|";

            //Office Address Line 4
            recordString += "|";

            //Office City Code
            recordString += "|";

            //Office State Code
            recordString += "|";

            //Office Country Code
            recordString += "434" + "|";

            //Office ZIP Code
            recordString += "|";

            //Office Phone Number 1
            recordString += "|";

            //Office Phone Number 2
            recordString += "|";

            //Office Email
            recordString += "|";

            //Office ISD
            recordString += "|";

            //Office Mobile
            recordString += "|";

            //Legal ID 1 Type (Passport)
            recordString += "1" + "|";

            //Legal ID 1 (Passport Number)
            recordString += record.Customer.PassportNumber + "|";

            //Legal ID 1 Expiry Date (Passport Exp Date)
            recordString += record.Customer.PassportExp + "|";

            //Legal ID 1 Issuance Place (Passport Issuance Place)
            recordString += "Libya" + "|";


            //Legal ID 2 Type (National ID)
            recordString += "2" + "|";

            //Legal ID 2 (National ID)
            recordString += record.Customer.NationalID + "|";

            //Legal ID 2 Expiry Date (National ID)
            recordString +=  "|";

            //Legal ID 2 Issuance Place (National ID)
            recordString +=  "|";

            //Legal ID 3 Type 
            recordString += "|";

            //Legal ID 3 
            recordString += "|";

            //Legal ID 3 Expiry Date
            recordString += "|";

            //Legal ID 3 Issuance Place
            recordString += "|";

            //Legal ID 4 Type 
            recordString += "|";

            //Legal ID 4 
            recordString += "|";

            //Legal ID 4 Expiry Date
            recordString += "|";

            //Legal ID 4 Issuance Place
            recordString += "|";

            //Memo
            recordString += "|";

            //Client Custom Date 1
            recordString += "|";

            //Client Custom Date 2
            recordString += "|";

            //Client Custom Date 3
            recordString += "|";

            //Client Custom Date 4
            recordString += "|";

            //Client Custom Date 5
            recordString += "|";

            //Client Custom Data 1
            recordString += "|";

            //Client Custom Data 2
            recordString += "|";

            //Client Custom Data 3
            recordString += "|";

            //Client Custom Data 4
            recordString += "|";

            //Client Custom Data 5
            recordString += "|";

            //Client Custom Number 1
            recordString += "|";

            //Client Custom Number 2
            recordString += "|";

            //Client Custom Number 3
            recordString += "|";

            //Client Custom Number 4
            recordString += "|";

            //Client Custom Number 5
            recordString += "|";

            //Device Custom Date 1
            recordString += "|";

            //Device Custom Date 2
            recordString += "|";

            //Device Custom Date 3
            recordString += "|";

            //Device Custom Date 4
            recordString += "|";

            //Device Custom Date 5
            recordString += "|";

            //Device Custom Data 1
            recordString += "|";

            //Device Custom Data 2
            recordString += "|";

            //Device Custom Data 3
            recordString += "|";

            //Device Custom Data 4
            recordString += "|";

            //Device Custom Data 5
            recordString += "|";

            //Device Custom Number 1
            recordString += "|";

            //Device Custom Number 2
            recordString += "|";

            //Device Custom Number 3
            recordString += "|";

            //Device Custom Number 4
            recordString += "|";

            //Device Custom Number 5
            recordString += "|";


            //Wallet Custom Date 1
            recordString += "|";

            //Wallet Custom Date 2
            recordString += "|";

            //Wallet Custom Date 3
            recordString += "|";

            //Wallet Custom Date 4
            recordString += "|";

            //Wallet Custom Date 5
            recordString += "|";

            //Wallet Custom Data 1
            recordString += record.Account.AccountNumberCurrency + "|";

            //Wallet Custom Data 2
            recordString += record.Account.AccountNumberLYD + "|";

            //Wallet Custom Data 3
            recordString += "|";

            //Wallet Custom Data 4
            recordString += "|";

            //Wallet Custom Data 5
            recordString += "|";

            //Wallet Custom Number 1
            recordString += record.Account.AccountNumberCurrency + "|";

            //Wallet Custom Number 2
            recordString += record.Account.AccountNumberLYD + "|";

            //Wallet Custom Number 3
            recordString += "|";

            //Wallet Custom Number 4
            recordString += "|";

            //Wallet Custom Number 5
            recordString += "|";

            //Employment Number status
            recordString += "|";

            //Empl ID
            recordString += "|";

            //Employer Name
            recordString += "|";

            //Empl Designation
            recordString += "|";

            //Empl Department
            recordString += "|";

            //Comp Type
            recordString += "|";

            //Current Job Tenure
            recordString += "|";

            //Occupation
            recordString += "|";

            //Applicant Prof
            recordString += "|";

            //Employee Joining Date
            recordString += "|";

            //Travel Type Code
            recordString += "|";

            //Travel Country
            recordString += "|";

            //Travel Start Date
            recordString += "|";

            //Travel End Date
            recordString += "|";

            //Client ID (Customer ID in CBS)
            recordString += record.CustomerID + "|";

            //Risk Catagory Value
            recordString += "|";

            //Cobrand Number
            recordString += "|";

            //Reuter Reference Number
            recordString += "|";

            //CBS Reference Number
            recordString += record.CustomerID + "|";

            //Alternate Name
            recordString += "|";

            //Future Use Field 1
            recordString += "|";
            //Future Use Field 2
            recordString += "|";
            //Future Use Field 3
            recordString += "|";
            //Future Use Field 4
            recordString += "|";
            //Future Use Field 5
            recordString += "|";
            //Future Use Field 6
            recordString += "|";
            //Future Use Field 7
            recordString += "|";
            //Future Use Field 8
            recordString += "|";
            //Future Use Field 9
            recordString += "|";
            //Future Use Field 10
            recordString += "|";
            //Future Use Field 11
            recordString += "|";
            //Future Use Field 12
            recordString += "|";
            //Future Use Field 13
            recordString += "|";
            //Future Use Field 14
            recordString += "|";
            //Future Use Field 15
            recordString += "|";
            //Future Use Field 16
            recordString += "|";
            //Future Use Field 17
            recordString += "|";
            //Future Use Field 18
            recordString += "|";
            //Future Use Field 19
            recordString += "|";
            //Future Use Field 20
            recordString += "|";

            //Lodging Mode
            recordString += "|";

            //Permanent Address From
            recordString += "|";

            //Checksum 
            recordString += "|";

            return recordString;
        }

        private static bool checkFileExist(string fileName)
        {
            string file = String.Format(PTSApplicationFiles + @"\" + fileName);

            if (File.Exists(file))
            {
                Console.WriteLine("Exist");
                return true;
            }
            return false;
        }
        public static void createAppFile(string fileName, string header, string footer, List<string> recordStrings)
        {
            string file = String.Format(PTSApplicationFiles + @"\" + fileName);

            try
            {
                // Check if file already exists. If yes, delete it.     
            

                // Create a new file 
                using (StreamWriter fs = File.CreateText(file))
                {
                    //Write header
                    fs.WriteLine(header);
                    foreach (string record in recordStrings)
                    {
                        fs.WriteLine(record);
                    }
                    // Add some text to file    
                    fs.WriteLine(footer);
   
                    

                }
                //Nothing
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        
    }
}
