using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadWrite rw = new ReadWrite();
            rw.writefile(@"c:\files\Test.txt");
            rw.readfile(@"c:\files\Test.txt");
        }
    }
}
