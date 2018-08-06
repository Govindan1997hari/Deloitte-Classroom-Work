using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20newfeatures
{
    partial class Employee  
    {
        public Employee()
        {
            id = 77;
            name = "lolfaced";
            dept = "CID";
            salary = 40000;
        }
        public Employee(int id,string name,string dept,double sal)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;
            salary = sal;
        }
    }
}
