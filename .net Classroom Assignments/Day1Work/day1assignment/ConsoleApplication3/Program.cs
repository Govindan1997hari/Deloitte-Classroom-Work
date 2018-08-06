using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname;
            string lname;
            string email;
            DateTime DOB;
            Console.WriteLine("Enter the First Name:");
            fname = Console.ReadLine();
            Console.WriteLine("Enter the last Name:");
            lname = Console.ReadLine();
            Console.WriteLine("Enter the Email:");
            email = Console.ReadLine();
            Console.WriteLine("Enter the Date of birth:");
            DOB =DateTime.Parse( Console.ReadLine());
            person p = new person(fname,lname,email,DOB);
            p.adult();
            p.sun_sign();
            p.birthday();
        }
    }
}
