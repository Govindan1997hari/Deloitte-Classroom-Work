
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsexample
{
    class Program
    {
        static void Main(string[] args)
        {
            ///personinfo p = new personinfo();
            // p.getdata();
            // p.showdata();
            // personinfo p2 = new personinfo();
            // p2.showdata();
            // personinfo p3 = new personinfo("amit", 20, "something@something.com");
            //p3.showdata();
            //shapes s = new rectangle();
            //s.displayarea();
            //s.displayshapes();
            bird b = new bird();
            b.fly();
            kite k = new kite();
            k.fly();
            plane p = new plane();
            p.fly();
            p.printticket();
        }
    }
}
