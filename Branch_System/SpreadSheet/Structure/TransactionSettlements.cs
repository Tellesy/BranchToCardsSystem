using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPBS.SpreadSheet.Structure
{
   public class TransactionSettlements
    {
        public string AccountNumber { get; set; }
        public string CardNumber { get; set; }

        public float Amount { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Branch { get; set; }

        //public TransactionSettlements(string accountNumber, string cardNumber, float amount, string type, string description, string branch)
        //{
        //    this.AccountNumber = accountNumber;
        //    this.CardNumber = cardNumber;
        //    this.Amount = amount;
        //    this.Type = type;
        //    this.Description = description;
        //    this.Branch = branch;
        //}
    }
}
