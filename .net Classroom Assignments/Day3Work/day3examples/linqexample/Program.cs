using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lambdaExample;

namespace linqexample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>
            {
                new Employee {empid=100,name="something",dept="IT",salary=35000 },
                new Employee {empid=200,name="something2",dept="HR",salary=25000 },
                new Employee {empid=300,name="clark",dept="account",salary=20000},
                new Employee {empid=400,name="king",dept="IT",salary=75000 }

            };
            //select all data
            var data = from t in emp
                       select t;
            foreach (var d in data)
                Console.WriteLine(d.empid + "|" + d.name + "|" + d.dept + "|" + d.salary);
            Console.WriteLine("=-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-=");
            //select based on id
            var data1 = (from t in emp
                         where t.empid == 100
                         select t).SingleOrDefault();
            if (data1 == null)
                Console.WriteLine("Invalid Id");
            else
                Console.WriteLine(data1.empid + "|" + data1.name + "|" + data1.dept + "|" + data1.salary);
            Console.WriteLine("=-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-=");
            //select data base on multiple condision

            var data2=from t in emp
                      where t.dept=="IT"&& t.salary>50000
                      select t;
            foreach(var d in data2)
                Console.WriteLine(d.empid + "|" + d.name + "|" + d.dept + "|" + d.salary);
            Console.WriteLine("=-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-=");
            //sort name asc/desc and select only name
            var data3 = from t in emp
                        orderby t.name ascending
                        select t.name;
            foreach (var d in data3)
                Console.WriteLine(d);
            Console.WriteLine("=-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-=");
            //print multiple data using anonymous
            var data4 = from t in emp
                        select new { empname = t.name, empsalary = t.salary };
            foreach (var d in data4)
                Console.WriteLine(d.empname + "|" + d.empsalary);
            Console.WriteLine("=-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-=");
            //group up
            var data5 = from t in emp
                        group t by t.dept into grp
                        select new { deptname = grp.Key, empcount = grp.Count(), sumsalary = grp.Sum(x => x.salary) };
            foreach (var t in data5)
                Console.WriteLine(t.deptname + "|" + t.empcount + "|" + t.sumsalary);
            Console.WriteLine("=-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-=");
            //select emp getting max/min salary
            var data6 = from t in emp
                        where t.salary == emp.Min(x => x.salary)
                        select t;
            foreach(var d in data6)
                Console.WriteLine(d.empid + "|" + d.name + "|" + d.dept + "|" + d.salary);
            Console.WriteLine("=-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-=");

        }
    }
}
