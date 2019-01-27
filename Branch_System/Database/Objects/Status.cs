using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch_System.Database.Objects
{
    public class Status<T>
    {
        //public Status statusObject;
        public T Object;
        public bool status;
        public string message;
    }
}
