using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPBS.Database.Objects
{
    public class PBFObject
    {
      //  SELECT[ID],[Card_Account],[Balance] ,[Inputter],[Time] FROM[PBF]

        public int ID { get; set; }
        public string Card_Account { get; set; }
        public int Balance { get; set; }
        public int Inputter { get; set; }
        public string Time { get; set; }
        public string NID { get; set; }
        public string Product { get; set; }
    }
}
