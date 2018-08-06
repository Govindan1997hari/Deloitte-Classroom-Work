using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertyexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name And Age");
            string n = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            PersoninfoAuto auto = new PersoninfoAuto();
            auto.Name = n;
            auto.Age = a;
            Console.WriteLine(auto.Name + "\n" + auto.Age);
            PersonInfoCLR clr = new PersonInfoCLR { Name = "king", Age = 250 };
            Console.WriteLine(clr.Name + "\n " + clr.Age);
        }
    }
}
