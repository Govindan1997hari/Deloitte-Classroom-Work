using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1, val2;
            USERTRAIL s = new USERTRAIL();
            Console.WriteLine("Enter the first value ");
            val1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second value ");
            val2 = int.Parse(Console.ReadLine());
            try
            {
                s.show(val1, val2);
                s.calculate(val1, val2);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
