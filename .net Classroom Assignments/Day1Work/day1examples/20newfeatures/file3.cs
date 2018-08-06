using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20newfeatures
{
    partial class Employee
    {
        public void showdata()
        {
            Console.WriteLine("ID:" + id);
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Dept:" + dept);
            Console.WriteLine("salary:" + salary);
        }
    }
}
