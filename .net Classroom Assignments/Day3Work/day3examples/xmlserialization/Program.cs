using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xmlserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            //personinfo pi=new personinfo("martin", 22);
            serialize s = new serialize();
            //s.savedata(pi);
            personinfo pnew = new personinfo();
            pnew.showdata();
            pnew = s.getdata();
            pnew.showdata();
        }
    }
}
