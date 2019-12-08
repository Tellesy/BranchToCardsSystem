using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Database.Objects
{
  public class CAFObject
    {
        public int ID { get; set; }
        public string Card_Number { get; set; }
        public string Card_Account { get; set; }
        public string EXP_Date { get; set; }
        public string Product { get; set; }
        public int Inputter { get; set; }
        public string Time { get; set; }
        public bool HONOR { get; set; }

    }
}
