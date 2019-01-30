using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Database.Objects
{
    public class PObject
    {
        public int ID { get; set; }
        public string Card_Number { get; set; }
        public string Name { get; set; }
        public string Customer_ID { get; set; }
        public string Account { get; set; }
        public string Begin_Date { get; set; }
        public string End_Date { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Passport { get; set; }
        public int Update_Code { get; set; }
        public char Process_Indicator { get; set; }
        public string Branch_Code { get; set; }
        public int Inputter { get; set; }
        public string Time { get; set; }
    }
}
