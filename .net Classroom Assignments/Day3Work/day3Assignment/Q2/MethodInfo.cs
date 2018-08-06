using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    [AttributeUsage(AttributeTargets.Method)]
    class MethodInfo:Attribute
    {
        public string methodname { get; set; }
        public string returntype { get; set; }
        public int parameters { get; set; }
        public string message { get; set; }
    }
}
