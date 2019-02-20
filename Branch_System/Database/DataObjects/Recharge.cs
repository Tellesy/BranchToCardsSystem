using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Database.DataObjects
{
    public class Recharge
    {
        public int ID { get; set; }
        public string Customer_ID { get; set; }
        public int R_Year { get; set; }
        public string Product { get; set; }
        public int Amount { get; set; }
        public string Time { get; set; }
        public string NID { get; set; }
        public int Inputter { get; set; }
        public int Branch { get; set; }
        public int Authorizer { get; set; }
        public int Authorized { get; set; }
        public string CardAccount { get; set; }
        public string Type { get; set; }
    }
}
