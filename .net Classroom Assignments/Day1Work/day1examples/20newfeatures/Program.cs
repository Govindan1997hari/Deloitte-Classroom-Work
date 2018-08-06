using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20newfeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee e1 = new Employee();
            //e1.showdata();
            //Employee E2 = new Employee(10, "gavub", "cs", 30000);
            // E2.showdata();
            //for (int i = 0; i < 10; i++)
            //  counter.countdata();
            int num1 = 100;
            int num2 = 200;
            string str1 = "hello";
            string str2 = "world";
            Console.WriteLine("Before swapping: " + num1 + " " + num2);
            swapexample<int> intobj = new swapexample<int>();
            intobj.swap(ref num1, ref num2);
            Console.WriteLine("after swapping:" + num1 + " " + num2);

            Console.WriteLine("before swap:" + str1 + " " + str2);
            swapexample<string> strobj = new swapexample<string>();
            strobj.swap(ref str1, ref str2);
            Console.WriteLine("after swapping:" + str1 + " " + str2);
            int? age = 32;
            double? pi = null;
            if (age.HasValue)
                Console.WriteLine(age.Value);
            else
                Console.WriteLine("Age: Null");
            if(pi.HasValue)
                Console.WriteLine(pi.Value);
            else
                Console.WriteLine("pi is null");
        }
    }
}
