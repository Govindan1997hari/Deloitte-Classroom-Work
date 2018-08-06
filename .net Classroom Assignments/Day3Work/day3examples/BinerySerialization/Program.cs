using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinerySerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonInfo pi = new PersonInfo("clark", 20);
            Serializedata sd = new Serializedata();
            //sd.savedata(pi);
            PersonInfo pi = new PersonInfo();
            pi.showdata();
            pi=sd.getdata();
            pi.showdata();
        }
    }
}
