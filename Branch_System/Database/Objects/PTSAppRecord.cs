using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Database.Objects
{
  public  class PTSAppRecord
    {
        public int RecordID;
        public string CustomerID;
        public string BankCode;
        public char ApplicationType;
        public char ApplicationSubType;
        public string ProgramCode;
        public string DeviceNumber;
        public string DevicePlanCode;
        public string BranchCode;
        public string Inputter;
        public DateTime InputTime;
        public string BranchAuthorizer;
        public DateTime BranchAuthTime;
        public string HQAuthorizer;
        public DateTime HQAuthTime;
        public bool Generated;


    }
}
