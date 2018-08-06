using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public delegate void print(int num);
    class Program
    {
        static void Main(string[] args)
        {
            delegateclass d = new delegateclass();
            print p = d.PrintNumber;
            p += d.PrintMoney;
            p += d.PrintHexaDecimal;
            p(100000);

        }
    }
}
