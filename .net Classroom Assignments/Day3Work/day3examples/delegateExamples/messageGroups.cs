using System;
using System.Collections.Generic;                                 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateExamples
{
    class SchoolGroup
    {
        List<int> phone = new List<int>();
        public SchoolGroup()  
        public void message(string msg)
        {
            foreach (var p in phone)
                Console.WriteLine("school group:" + p + ":" + msg);
        }
    }
    class CollegeGroup
    {
        List<int> phone = new List<int>();
        public CollegeGroup()
        {
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                phone.Add(r.Next(20000, 30000));
            }
        }
        public void message(string msg)
        {
            foreach (var p in phone)
                Console.WriteLine("College group:" + p + ":" + msg);
        }

    }
    class DeloitteGroup
    {
        List<int> phone = new List<int>();
        public DeloitteGroup()
        {
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                phone.Add(r.Next(30000, 40000));
            }
        }
        public void message(string msg)
        {
            foreach (var p in phone)
                Console.WriteLine("Deloitte group:" + p + ":" + msg);
        }
    }
}
