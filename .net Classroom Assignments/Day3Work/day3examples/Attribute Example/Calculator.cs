using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute_Example
{
    [developerinfo(empid =123,name ="suresh",projname ="banking",dateofcreation ="07/07/2000",message ="This is a really useful property of attribute")]
    class Calculator
    {
        public int add(int x,int y)
        {
            return (x + y);
        }
        public int sub(int x, int y)
        {
            return (x - y);
        }
        public int mul(int x, int y)
        {
            return (x * y);
        }
        public int div(int x, int y)
        {
            return (x / y);
        }
    }
}
