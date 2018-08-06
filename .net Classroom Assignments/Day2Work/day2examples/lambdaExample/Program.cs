using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, -1, 4, 5, 7, 8, -2, 3, 2, 10 };
            foreach (var a in arr.Where(n => n>5))
                Console.WriteLine(a);
            string[] cities = { "Mumbai", "Pune", "Hydrabad", "New delhi", "Kolkatta", "pondicherry" };
            foreach (var c in cities.Where(y => y.StartsWith("P")||y.StartsWith("M")))
            {
                Console.WriteLine(c);
            }
            foreach (var c in cities.Where(x => x.Contains("e")))
                Console.WriteLine(c);
            var result = cities.Where(x => x.Contains("e"));
            Console.WriteLine(result.Count());
            List<Employee> emp = new List<Employee>
            {
                new Employee {empid=100,name="something",dept="IT",salary=35000 },
                new Employee {empid=200,name="something2",dept="HR",salary=25000 },
                new Employee {empid=300,name="clark",dept="account",salary=20000},
                new Employee {empid=400,name="king",dept="IT",salary=75000 }

            };
            foreach (var r in emp)
                Console.WriteLine(r.empid + " " + r.name + " " + r.dept + " " + r.salary);
            Console.WriteLine("********************");
            var data = emp.Where(x => x.empid == 100).SingleOrDefault();
            if (data == null)
                Console.WriteLine("invalid empid");
            else
                Console.WriteLine(data.empid + " " + data.name + " " + data.dept + " " + data.salary);
            Console.WriteLine("*************************");
            var data2 = emp.Where(x => x.dept == "IT");
            if(data2.Count()==0)
            {
                Console.WriteLine("Invalid deptname");
            }
            else
            {
                foreach(var d in data2)
                {
                    Console.WriteLine(d.empid + " " + d.name + " " + d.dept + " " + d.salary);
                }
            }
            //select name sorted in asc/desc order of name
            var data4=emp.OrderByDescending(x=>x.name).Select(y => y.name);
            foreach (var d in data4)
                Console.WriteLine(d);
            Console.WriteLine("***********");
            //selects 1 or all of the property
            //select name and salary - anonymous type from c#3.5
            // new{variablename = e.name, variablename2=e.salary}
            var data5 = emp.Select(x => new { empname = x.name, empsalary = x.salary });
            foreach(var d in data5)
                Console.WriteLine(d.empname +" "+d.empsalary);
            Console.WriteLine("***********");
            Console.WriteLine("max salary:" + emp.Max(x => x.salary));
            Console.WriteLine("Min salary:" + emp.Min(x => x.salary));
            //sumary - count of emp dept wise sum of salary paid dept wise
            //key - column on which the group by is given
            var grp = emp.GroupBy(x => x.dept).Select(x => new { deptname = x.Key, empcount = x.Count(), sumsalary = x.Sum(y => y.salary) });
            foreach (var g in grp)
                Console.WriteLine(g.deptname + " " + g.empcount + " " + g.sumsalary);
            Console.WriteLine("***********");
            var maxsal = emp.Where(x => x.salary== emp.Max(y => y.salary));
            foreach(var d in maxsal)
                Console.WriteLine(d.empid + " " + d.name + " " + d.dept + " " + d.salary);
            Console.WriteLine("***********");
        }
    }
}
