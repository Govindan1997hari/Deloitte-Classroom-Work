using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinerySerialization
{
    [Serializable]
    class PersonInfo
    {
        string name;
        int age;
        public PersonInfo()
        { }
        public PersonInfo(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public void showdata()
        {
            Console.WriteLine("name:" + name);
            Console.WriteLine("Age:" + age);
        }
    }
}
