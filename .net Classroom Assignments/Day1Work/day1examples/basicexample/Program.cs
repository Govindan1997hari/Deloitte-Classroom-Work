using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicexample
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            char gender;
            double salary;
            bool cab;
            DateTime DOJ;
            Console.WriteLine("enter ID;");
            //id=int.Parse(Console.ReadLine());
            bool res = int.TryParse(Console.ReadLine(), out id);
            if(res==false)
            {
                Console.WriteLine("not valid");
                return;
            }
            Console.WriteLine("Enter Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Gender:");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("enter cab (true/false)");
            cab = Boolean.Parse(Console.ReadLine());
            Console.WriteLine("Enter date of joining");
            DOJ = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("ID:"+id);
            Console.WriteLine("Name:"+name);
            Console.WriteLine("Gender:"+gender);
            Console.WriteLine("Salary:"+salary);
            Console.WriteLine("cab:"+cab);
            Console.WriteLine("Date of Joining:"+DOJ);
        }
    }
}
