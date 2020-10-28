using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPBS.Database.Objects
{
    public class PTSDevice
    {
        public string DeviceNumber { get; set; }
        public string WalletNumber { get; set; }
        public string CardPackID { get; set; }
        public bool Active { get; set; }


    }
}
