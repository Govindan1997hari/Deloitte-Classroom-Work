using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1;
            Console.WriteLine("Enter the String:");
            s1 = Console.ReadLine();
            string s2 = "Deloitte Training";
            try
            {
                if (!(s1.Equals(s2)))
                {
                    throw new NoMatchException("The Strings Dosen't Match !");
                }
                else
                {
                    Console.WriteLine("String match!!");
                }
            }
            catch(NoMatchException E)
            {
                Console.WriteLine("Exception Found:" + E.Message);
            }
        }
    }
}
