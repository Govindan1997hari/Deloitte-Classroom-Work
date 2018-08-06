using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute_Example
{
    class ReadAttributeValues
    {
        public void readattribute(Type t)
        {
            developerinfo di=(developerinfo)Attribute.GetCustomAttribute(t,typeof(developerinfo));
            if (di == null)
                Console.WriteLine("No attribute created");
            else
                Console.WriteLine(di.empid + " " + di.name + " " + di.projname + " " + di.dateofcreation + " " + di.message);
        }
    }
}
