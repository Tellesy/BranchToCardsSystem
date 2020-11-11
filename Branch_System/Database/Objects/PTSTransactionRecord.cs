using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPBS.Database.Objects
{
   public class PTSTransactionRecord
    {
        /// <summary>
        /// Mandatory Field
        /// </summary>
        public string DeviceNumber { get; set; }
        /// <summary>
        /// Mandatory Field
        /// </summary>
        public string WalletNumber { get; set; }
        /// <summary>
        /// Mandatory Field
        /// </summary>
        public string Indicator { get; set; }
        /// <summary>
        /// Optional Field
        /// Date Format: DDMMYYYY
        /// </summary>
        public string TransactionDate { get; set; }

        /// <summary>
        /// Mandatory Field
        /// Valid Values
        /// U1: Load Cash allowed for prepaid product only. 
        /// 71: Misc Credit allowed for all product types. 
        /// 70: Misc Debit allowed for all product types.
        /// 21: Card Fees.
        /// 92: Cashback Allowed for Prepaid Product only. 
        /// </summary>
        public string TransactionCode { get; set; }
        /// <summary>
        /// Conditional Field (In Case of Card fees)
        /// </summary>
        public string FeesReason { get; set; }
        /// <summary>
        /// Optional Field
        /// </summary>
        public string TransactionAmount { get; set; }
        /// <summary>
        /// Optional Field
        /// '0006000'
        /// means 60 This is as per the currency exponent.
        /// This value should be whole number. 
        /// Value is calculated with following method using ISO Defined exponent. 
        /// For example: 
        /// Value of file: 000000000100333 Currency: USD Exponent value:
        /// as per ISO standard for USD is 2 Calculated value is:
        /// 000000000100333/100 : 1003.33
        /// </summary>
        public string TransactionCurrency { get; set; }
        /// <summary>
        ///  Conditional Field 
        ///  ISO Currency Code
        /// </summary>
        public string ConversionRate { get; set; }
        /// <summary>
        ///  Optional Field 
        /// </summary>
        public string ConversionRateDate { get; set; }
        /// <summary>
        /// Mandatory Field 
        /// '0006000'
        /// means 60 This is as per the currency exponent.
        /// This value should be whole number. 
        /// Value is calculated with following method using ISO Defined exponent. 
        /// For example: 
        /// Value of file: 000000000100333 Currency: USD Exponent value:
        /// as per ISO standard for USD is 2 Calculated value is:
        /// 000000000100333/100 : 1003.33 
        /// </summary>
        public string BillingAmount { get; set; }
        /// <summary>
        /// Mandatory Field 
        /// ISO Currency Code
        /// 840
        /// </summary>
        public string BillingCurrency { get; set; }
        /// <summary>
        /// Optional Field 
        /// Transaction Description 
        /// </summary>
        public string Narration { get; set; }
        /// <summary>
        /// Conditional Field 
        /// Original Transaction Acquirer Reference Number (ARN) used for extracting original
        /// </summary>
        public string OrgTxnArn { get; set; }
        /// <summary>
        /// Conditional Field 
        /// </summary>
        public string OrgTxnArnDate { get; set; }
        /// <summary>
        /// Valid Values: – 
        /// 1 IVR  
        /// 2 Mobile  
        /// 3 ATM 
        /// 4 Net Banking
        /// 5 POS 
        /// 6 Scheme
        /// 7 Core Banking 
        /// 8 SMS
        /// 9 ACS 
        /// 10 OnUs 
        /// 11 Other 
        /// 12 Other 2  
        /// 13 Other 3 
        /// 14 Other 4 
        /// 15 Other 5 
        /// </summary>
        public int Source { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Checksum{ get; set; }










    }


}
