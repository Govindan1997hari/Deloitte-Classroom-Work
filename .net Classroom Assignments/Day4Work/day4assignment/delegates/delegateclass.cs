using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class delegateclass
    {
        public void PrintNumber(int number)
        {
            int p = number;
            Console.WriteLine("{0:n}", p);
        }
        public void PrintMoney(int number)
        {
            int p = number;
            Console.WriteLine("{0:c}", p);
        }
        public void PrintHexaDecimal(int number)
        {
            int p = number;
            Console.WriteLine("{0:x}",p );
        }
    }
}
