using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPBS.Settlements.PTS.ReportTemplates
{
   public class TransactionReport
    {
        public DateTime ValueDate { get; set; }
        public string ProgramName { get; set; }
        public string Channel { get; set; }
        public string TransactionCode { get; set; }
        public string TransactionType { get; set; }
        public string DeviceNumber { get; set; }
        public float BillingAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public float TotalFeesAndCharges { get; set; }
        public bool ReversalFlag { get; set; }
        public string WalletNumber { get; set; }
        public DateTime SettlementDate { get; set; }
        public TransactionToCardType DRorCRtoCardholder { get; set; }

        public String CBSFTDescription { get; set; }
        public String BranchCode { get; set; }
        public String LYDAccountNumber { get; set; }
        public String USDAccountNumber { get; set; }





    }
    public enum TransactionToCardType { DR, CR }
}
