 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute_Example
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method|AttributeTargets.Constructor)]
    class developerinfo:Attribute
    {
        public int empid { get; set; }
        public string name { get; set; }
        public string projname { get; set; }
        public string dateofcreation { get; set; }
        public string message { get; set;}
    }
}
