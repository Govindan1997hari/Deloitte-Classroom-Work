using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace extentionexample
{
    class Program
    {
        static void Main(string[] args)
        {
            calculator c = new calculator();
            Console.WriteLine(c.add(12, 13));
            Console.WriteLine(c.sub(12, 11));
            Console.WriteLine(c.mul(3, 4));
        }
    }
}
