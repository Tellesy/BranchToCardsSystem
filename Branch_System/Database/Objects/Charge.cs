using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPBS.Database.Objects
{

    public class ChargeType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
    }
    public class Charge
    {
        public int ID { get; set; }
        public int ChargeType { get; set; }
        public int CustomerID { get; set; }
        public string ProgramCode { get; set; }
        public bool GenFlag { get; set; }
        public DateTime InputDate { get; set; }
        public DateTime GenDate { get; set; }
        public bool ExeFlag { get; set; }
        public DateTime ExeDate { get; set; }
        
        public string BranchCode { get; set; }

        public int RefRecordID { get; set; }
    }
}
