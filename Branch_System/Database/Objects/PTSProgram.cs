﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPBS.Database.Objects
{
  public  class PTSProgram
    {
        public string Code { get; set; }
        public string NameAR { get; set; }
        public string NameEN { get; set; }
        public string CBSCatagory { get; set; }

        public bool Active { get; set; }
        public int YearlyLimit { get; set; }
    }
}
