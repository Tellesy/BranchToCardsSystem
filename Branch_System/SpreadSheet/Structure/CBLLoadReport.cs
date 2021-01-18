using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPBS.SpreadSheet.Structure
{
   public class CBLLoadReport
    {
        public string CustomerID { get; set; }
        public string NID { get; set; }
        public string Date { get; set; }
        public string AmountLYD { get; set; }
        public string AmountUSD { get; set; }
        public string ExchangeRate { get; set; }
        public string BranchCode { get; set; }



    }
}
