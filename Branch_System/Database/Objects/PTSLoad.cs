using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPBS.Database.Objects
{
    public class PTSLoad
    {
        public int ID { get; set; }
        public string CustomerID  { get; set; }

        public string ProgramCode { get; set; }
        public string WalletNumber { get; set; }
        public string BranchCode { get; set; }
        public string Year { get; set; }
        public int Amount { get; set; }

        public string Inputter { get; set; }
        public DateTime InputTime { get; set; }

        public string BranchAuthorizer { get; set; }
        public DateTime BranchAuthorizeTime { get; set; }

        public string HQAuthorizer { get; set; }
        public DateTime HQAuthorizeTime { get; set; }

        public bool Generated { get; set; }
        public DateTime GenTime { get; set; }
    }
}
