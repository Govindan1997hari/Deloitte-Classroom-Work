using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using emplibrary;

namespace reflectionexample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assembly t = Assembly.GetAssembly(typeof(Employee));
            Type tt = typeof(Employee);
            ConstructorInfo[] ci = tt.GetConstructors();
            foreach (var p in ci)
            {
                Console.WriteLine("Constructor Name:" + p.Name);
                Console.WriteLine("is public:" + p.IsPublic);
                ParameterInfo[] pi = p.GetParameters();
                foreach(var c in pi)
                {
                    Console.WriteLine("parameter type " + c.ParameterType);
                    Console.WriteLine("parameter position " + c.Position);
                    Console.WriteLine("default value for parameter" + c.DefaultValue);
                }
                MethodInfo[] mi = tt.GetMethods();
                foreach(var m in mi)
                {
                    Console.WriteLine("method name:" + m.Name);
                    Console.WriteLine("module name:" + m.Module);
                    Console.WriteLine("return name:" + m.ReturnType);
                    Console.WriteLine("is public:" + m.IsPublic);
                }
                Console.WriteLine("********************");
                MemberInfo[] fi = tt.GetMembers();
                foreach (var f in fi)
                {
                    Console.WriteLine(f.Name);
                    Console.WriteLine(f.Module);
                    Console.WriteLine(f.MemberType);
                    Console.WriteLine(f.DeclaringType);
                }
                Console.WriteLine("********************");
            }
        }
    }
}
