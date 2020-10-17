using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPBS.Database.Objects
{
  public class Product
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Cash_Limit { get; set; }
        public int Cash_Transactions_Limit { get; set; }
        public int POS_Limit { get; set; }
        public int POS_Transactions_Limit { get; set; }
    }
}
