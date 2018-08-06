using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsexample
{
    class personinfo
    {
        string name;
        int age;
        string email;
        public void getdata()
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter email");
            email = Console.ReadLine();

        }
        public void showdata()
        {
            Console.WriteLine(" Name:" + name);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Email:" + email);

        }
        public personinfo()
        {
            name = "default";
            age = 99;
            email = "default@default.com";
        }
        public personinfo(string name,int age, string email)
        {
            this.name = name;
            this.age = age;
            this.email = email;        
        }    
        ~personinfo()
        {
            GC.Collect();
            Console.WriteLine("object destroyed");
        }
    }

}
