using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsexample
{
    class bird : iflying
    {
        public void fly()
        {
            Console.WriteLine("flies in groups");
        }
    }
    class kite : iflying
    {
        public void fly()
        {
            Console.WriteLine("Flies with a string");
        }
    }
    class plane : iflying, ipassengerinfo
    {
        public void fly()
        {
            Console.WriteLine("Flies with passengers");
        }

        public void printticket()
        {
            Console.WriteLine("passenger name:Lol");
            Console.WriteLine("source:bangalore");
        }
    }
}
