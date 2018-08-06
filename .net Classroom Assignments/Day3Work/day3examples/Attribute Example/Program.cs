using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadAttributeValues r = new ReadAttributeValues();
            r.readattribute(typeof(Calculator));
        }
    }
}
