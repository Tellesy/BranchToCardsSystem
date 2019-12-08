using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.FilesCreator
{
    public static class FileExporter
    {
        public static string Card_Number_s;
        public static string Card_Account_Number_s;
        public static string Update_code_s;
        public static string Card_Holder_Name_s;
        public static string Holder_Address_1_s;
        public static string Bank_Account_Number_1_s;
        public static string Branch_Code_s;
        public static string Card_Begin_Date_s;
        public static string Card_End_Date_s;
        public static string CARD_PROCESS_INDICATOR_s;
        public static string Cardholder_Birthdate_s;
        public static string Passport_ID_s;
        public static string ID_Code_s;
        public static string Phone_Number_s;
        public static string Email_s;
        public static string HONOR;


        //Files location
        public static string location = @"C:\Users\Public\LIB\";

        //PO file
        public static List<string> POFile;
        public static string POLine;


        //CA File
        public static List<string> CAFile;
        public static bool isFirstCAF = true;
        public static int CACount = 1;
        public static string AggregateDailyLimit_s;
        public static string CAFExpDate_s;
        public static string CashDailyLimit_s;
        public static string CashTransCount_s;
        public static string POSDailyLimit_s;
        public static string POSTransCount_s;
        public static string CALine;

        //BP File 
        public static List<string> BPFile;
        public static bool isFirstBP = true;
        public static int BPCount = 1;
        public static int Amount_s;
        public static string BFLine;

        public static void POFileExporter()
        {
            string day = DateTime.Today.Day.ToString();
            string month = DateTime.Today.Month.ToString();
            if (DateTime.Today.Day < 10)
            {
                day = String.Format("0{0}", day);
            }

            if (DateTime.Today.Month < 10)
            {
                month = String.Format("0{0}", month);
            }

            string fileName = String.Format(@"{0}RECEPT\" + "PO0143_{1}{2}{3}{4}{5}.dat", location, day, month, DateTime.Today.Year, DateTime.UtcNow.Hour, DateTime.UtcNow.Minute);


            System.IO.File.WriteAllLines(fileName, POFile);
            POFile = new List<string>();

        }
        public static void AddToPOFile()
        {

            string Header_Record = "P005";
            string Card_Number = Card_Number_s;
            string Update_code = Update_code_s;
            string Product_type = "50";
            string Card_Holder_Name = Card_Holder_Name_s;
            string Filler = "";
            string Corporate_Name = "0010013000011";
            string Holder_Address_1 = Holder_Address_1_s;
            string Holder_Address_2 = "";
            string Holder_Address_3 = "";
            string Postal_Code = "000000000"; //No. 49
            string Filler_X = ""; //No.50
            string Bank_Account_Number_1 = Bank_Account_Number_1_s;
            string Bank_Account_Number_2 = "";
            string Branch_Code = Branch_Code_s;


            string Card_Begin_Date = Card_Begin_Date_s;
            string Card_End_Date = Card_End_Date_s;
            string CARD_PROCESS_INDICATOR = CARD_PROCESS_INDICATOR_s;

            string CARD_LIMIT = "000000000000";
            string GAB_OFF_LIMIT = "000000000000";

            string Filler_2 = "";
            string CASH_LIMIT = "000000000000";
            string FEES_CODE = "001";

            string Territory_code = "2";
            string Debit_Per_code = "0";
            string Manual_Auth_code = "0";

            string Process_Julian_Date = "";
            string Bank_ID = "00143"; //000143
            string Cardholder_Birthdate = Cardholder_Birthdate_s;
            string Passport_ID = Passport_ID_s;

            string Filler_3 = "";
            string Filler_XY = ""; //No. 31
            string Country_Code = "434";
            string City_Code = "00000";
            string Renew_Option = "0";

            string Filler_4 = "";
            string Cardholder_Source_Code = "1";
            string Primary_Card_Code = "0";
            //Card number agian

            string Filler_5 = "";
            string Currency_Code = "840";
            string Filler_6 = "";
            string Filler_7 = "";
            string Filler_8 = "";

            string Card_PKI_Code_Indicator = "0";
            string ACS_Code = "";
            string ID_Code = ID_Code_s;
            string Filler_9 = "";
            string Filler_10 = "";
            string Phone_Number = Phone_Number_s;
            string Email = Email_s;
            string Filler_11 = "";



            string line = String.Format("{0,-4}{1,-19}{2,-1}{3,-2}{4,-26}{5,-26}{6,-26}{7,-32}{8,-32}{9,-32}{49,-9}{50,-26}{10,-24}{11,-24}{12,-5}{13,-4}{14,-4}{15,-1}{16,-12}{17,-12}{18,-5}{19,-12}{20,-3}{21,-1}{22,-1}{23,-1}{24,-6}{25,-5}{26,-8}{27,-10}{28,-3}{29,-3}{30,-3}{31,-5}{32,-1}{33,-26}{34,-1}{35,-1}{36,-19}{37,-5}{38,-3}{39,-6}{40,-24}{41,-6}{42,-1}{43,-1}{44,-16}{45,-26}{46,-3}{47,-11}{48,-40}",
                                        Header_Record,
                                        Card_Number,
                                        Update_code,
                                        Product_type,
                                        Card_Holder_Name,
                                        Filler,
                                        Corporate_Name,
                                        Holder_Address_1,
                                        Holder_Address_2,
                                        Holder_Address_3,
                                        Bank_Account_Number_1,
                                        Bank_Account_Number_2,
                                        Branch_Code,
                                        Card_Begin_Date,
                                        Card_End_Date,
                                        CARD_PROCESS_INDICATOR,
                                        CARD_LIMIT,
                                        GAB_OFF_LIMIT,
                                        Filler_2,
                                        CASH_LIMIT,
                                        FEES_CODE,
                                        Territory_code,
                                        Debit_Per_code,
                                        Manual_Auth_code,
                                        Process_Julian_Date,
                                        Bank_ID,
                                        Cardholder_Birthdate,
                                        Passport_ID,
                                        Filler_3,
                                        Filler_XY,
                                        Country_Code,
                                        City_Code,
                                        Renew_Option,
                                        Filler_4,
                                        Cardholder_Source_Code,
                                        Primary_Card_Code,
                                        Card_Number,
                                        Filler_5,
                                        Currency_Code,
                                        Filler_6,
                                        Filler_7,
                                        Filler_8,
                                        Card_PKI_Code_Indicator,
                                        ACS_Code,
                                        ID_Code,
                                        Filler_9,
                                        Filler_10,
                                        Phone_Number,
                                        Email,
                                        Filler_11,
                                        Postal_Code,
                                        Filler_X
                                       );

            POLine = line;
            POFile.Add(line);
            Console.WriteLine(line);
            Console.ReadLine();
        }

        public static void CAFileExporter()
        {
            string random = DateTime.UtcNow.Hour.ToString() + DateTime.UtcNow.Minute.ToString() +
                DateTime.UtcNow.Second.ToString();
            string day = DateTime.Today.Day.ToString();
            string month = DateTime.Today.Month.ToString();

            if (DateTime.Today.Day < 10)
            {
                day = String.Format("0{0}", day);
            }

            if (DateTime.Today.Month < 10)
            {
                month = String.Format("0{0}", month);
            }

            //if (DateTime.UtcNow.Hour > 10)
            //    random = random.Substring(0, 1);

            string fileName = String.Format(@"{0}REFRESH\" + "CF{1}{2}{3}{4}.txt", location, day, month, DateTime.Today.Year, random);

            CAFile.Add("000000005BT000000000000000000000000002                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             Z");
            CAFile.Add("000000006FT0000000020                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              Z");
            System.IO.File.WriteAllLines(fileName, CAFile);

            isFirstCAF = true;
            CACount = 1;
            CAFile = new List<string>();

        }
        public static void AddToCAFile()
        {
            string line;

            if (isFirstCAF)
            {
                string day = DateTime.Today.Day.ToString();
                string month = DateTime.Today.Month.ToString();
                string hour = DateTime.UtcNow.Hour.ToString();
                string minute = DateTime.UtcNow.Minute.ToString();


                if (DateTime.Today.Day < 10)
                {
                    day = String.Format("0{0}", day);
                }

                if (DateTime.Today.Month < 10)
                {
                    month = String.Format("0{0}", month);
                }

                if (DateTime.UtcNow.Hour < 10)
                {
                    hour = String.Format("0{0}", hour);
                }

                if (DateTime.UtcNow.Minute < 10)
                {
                    minute = String.Format("0{0}", minute);
                }


                CAFile = new List<string>();
                string first_line = String.Format("000000001FH1CF0143{0}{1}{2}{3}{4}PRO260  1809182018091808363635353518091820180918083636353535                          100                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            Z", 
                    DateTime.Today.Year, month, day,hour,minute);
                CAFile.Add(first_line);
                string second_line = "000000002BH0143                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    Z";
                CAFile.Add(second_line);

                isFirstCAF = false;
            }

            string CashDailyLimit = CashDailyLimit_s;

            if (int.Parse(CashDailyLimit) < 1000)
            {
                CashDailyLimit = "0" + CashDailyLimit;
            }
            //008800200000000000500000000000000000000000000000000000000000000000000000ATM  
            //00880020000000000{5}000000000000000000000000000000000000000000000000000ATM    
            if (CACount >= 100  && CACount < 1000)     //0346000000001
                line = String.Format("0346000000{0}{1}   000CMD01431                " +
                    "0000000{4}0000000000000000000000000000000000000000000000{4}00000000000" +
                    "            {2}" +
                    "                                                                                                                                                                                                       "
                    + "00880020000000000{5}000000000000000000000000000000000000000000000000000ATM             " +
                    "0140000000000000000000000000000000000000000000000000000000000000000000000{6}000000000000100000000000000000000000000        POS             00280010NN0000        " +
                    "00000100400101{3}   1CHECK ACCT                   Z"
                    , CACount, Card_Number_s, CAFExpDate_s, Card_Account_Number_s, AggregateDailyLimit_s, CashDailyLimit, POSDailyLimit_s);

           else if (CACount >= 10 && CACount < 100)
                                    //0346000000001
                line = String.Format("03460000000{0}{1}   000CMD0143{7}                " +
                    "0000000{4}0000000000000000000000000000000000000000000000{4}00000000000" +
                    "            {2}" +
                    "                                                                                                                                                                                                       "
                    + "00880020000000000{5}000000000000000000000000000000000000000000000000000ATM             " +
                    "0140000000000000000000000000000000000000000000000000000000000000000000000{6}000000000000100000000000000000000000000        POS             00280010NN0000        " +
                    "00000100400101{3}   1CHECK ACCT                   Z"
                    , CACount, Card_Number_s, CAFExpDate_s, Card_Account_Number_s, AggregateDailyLimit_s, CashDailyLimit, POSDailyLimit_s, HONOR);
            else
            {//                       0346000000001
                line = String.Format("034600000000{0}{1}   000CMD0143{7}                " +
                "0000000{4}0000000000000000000000000000000000000000000000{4}00000000000" +
                "            {2}" +
                "                                                                                                                                                                                                       "
                + "00880020000000000{5}000000000000000000000000000000000000000000000000000ATM             " +
                "0140000000000000000000000000000000000000000000000000000000000000000000000{6}000000000000100000000000000000000000000        POS             00280010NN0000        " +
                "00000100400101{3}   1CHECK ACCT                   Z"
                , CACount, Card_Number_s, CAFExpDate_s, Card_Account_Number_s, AggregateDailyLimit_s, CashDailyLimit, POSDailyLimit_s,HONOR);
            }



            CALine = line;
            CAFile.Add(line);
            CACount++;

        }

        public static void BPFileExporter()
        {
            string day = DateTime.Today.Day.ToString();
            string month = DateTime.Today.Month.ToString();
            if (DateTime.Today.Day < 10)
            {
                day = String.Format("0{0}", day);
            }

            if (DateTime.Today.Month < 10)
            {
                month = String.Format("0{0}", month);
            }
            string fileName = String.Format(@"{0}REFRESH\" + "PB{1}{2}{3}{4}{5}.txt", location, day, month, DateTime.Today.Year, DateTime.UtcNow.Hour, DateTime.UtcNow.Minute);

            BPFile.Add("000000005BT00000000000005740{000000002                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             Z");
            BPFile.Add("000000006FT0000000110                                                                                                                                                                                                                                                                                                                                        Z");
            System.IO.File.WriteAllLines(fileName, BPFile);

            isFirstBP = true;
            BPCount = 1;
            BPFile = new List<string>();
        }


        public static void AddToBPFile()
        {
            string line;

            if (isFirstBP)
            {
                int hour = DateTime.Now.Hour;
                int minitus = DateTime.Now.Minute;
                string day_header = DateTime.Today.Day.ToString();
                string month_header = DateTime.Today.Month.ToString();


                if (DateTime.Today.Day < 10)
                {
                    day_header = String.Format("0{0}", day_header);
                }

                if (DateTime.Today.Month < 10)
                {
                    month_header = String.Format("0{0}", month_header);
                }
                string hourString = hour.ToString();
                string minitusString = minitus.ToString();
                if (hour < 10)
                {
                    hourString = "0" + hourString;
                }

                if (minitus < 10)
                {
                    minitusString = "0" + minitusString;
                }

                string hourMinitus = hourString + minitusString;

                BPFile = new List<string>();
                string first_line = String.Format("000000001FH1BF0143{0}{1}{2}{3}PRO260  1809182018091808363635353518091820180918083636353535                          100                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             Z", 
                    DateTime.Today.Year, month_header, day_header, hourMinitus);
                BPFile.Add(first_line);
                string second_line = "000000002BH0143                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    Z";
                BPFile.Add(second_line);

                isFirstBP = false;

            }

            string amount;
            if (Amount_s < 10)
            {
                amount = String.Format("0000{0}", Amount_s.ToString());
            }
            else if (Amount_s < 100)
            {
                amount = String.Format("000{0}", Amount_s.ToString());
            }
            else if (Amount_s < 1000)
            {
                amount = String.Format("00{0}", Amount_s.ToString());
            }
            else if (Amount_s > 999 && Amount_s < 10000)
            {
                amount = String.Format("0{0}", Amount_s.ToString());
            }
            else
            {
                amount = String.Format("{0}", Amount_s.ToString());
            }

            string day;
            if (DateTime.Today.Day < 10)
                day = "0" + DateTime.Today.Day.ToString();
            else
                day = DateTime.Today.Day.ToString();

            string month;
            if (DateTime.Today.Month < 10)
                month = "0" + DateTime.Today.Month.ToString();
            else
                month = DateTime.Today.Month.ToString();

            if (BPCount < 10 && BPCount > 0)
            {
                line = String.Format("030000000000{0}0143{1}"
                    +
                    "    "
                  + "11C00000000000{2}0{6}00000000000{2}0{6}0000000000000000000000000000000000000000000000000000000000000000000000840"
                  +
                    "                                                                                                     "
                    + "{3}{4}{5}0848                                      00420000000000000000000000000000000000000"
                  + "                                                                                                                                                                                                                                                                                                                              Z"

                , BPCount, Card_Account_Number_s, amount, DateTime.Today.Year, month, day, @"{");

            }
            else if(BPCount >= 10 && BPCount < 100)
            {   //                    030000000000{0}
                line = String.Format("03000000000{0}0143{1}" + "    " +
                "11C00000000000{2}0{6}00000000000{2}0{6}0000000000000000000000000000000000000000000000000000000000000000000000840                                                                                                     " +
                "{3}{4}{5}0848                                      00420000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                              Z"
                , BPCount, Card_Account_Number_s, amount, DateTime.Today.Year, month, day, @"{");
            }
            else if (BPCount >= 100 && BPCount < 1000)
            {   //                    030000000000{0}
                line = String.Format("0300000000{0}0143{1}" + "    " +
                "11C00000000000{2}0{6}00000000000{2}0{6}0000000000000000000000000000000000000000000000000000000000000000000000840                                                                                                     " +
                "{3}{4}{5}0848                                      00420000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                              Z"
                , BPCount, Card_Account_Number_s, amount, DateTime.Today.Year, month, day, @"{");
            }
            else
            {   //                    030000000000{0}
                line = String.Format("03000000000{0}0143{1}" + "    " +
                "11C00000000000{2}0{6}00000000000{2}0{6}0000000000000000000000000000000000000000000000000000000000000000000000840                                                                                                     " +
                "{3}{4}{5}0848                                      00420000000000000000000000000000000000000                                                                                                                                                                                                                                                                                                                              Z"
                , BPCount, Card_Account_Number_s, amount, DateTime.Today.Year, month, day, @"{");
            }
            BFLine = line;
            BPFile.Add(line);
            BPCount++;

        }
    }
}
