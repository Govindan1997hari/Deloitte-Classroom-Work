using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateExamples
{
    class Program
    {
        public delegate void sms(string msg);
        static void Main(string[] args)
        {
            SchoolGroup sg = new SchoolGroup();
            CollegeGroup cg = new CollegeGroup();
            DeloitteGroup dg = new DeloitteGroup();
            sms sms = sg.message;
            sms += cg.message;
            sms += dg.message;
            sms("Good morning");
            sms -= cg.message;
            sms -= sg.message;
            sms("Alumini meeting at college auditorium on saterday");
            sms += dg.message;
            sms -= cg.message;
            sms("dotnet stream traing starting on 18/7");
        }
    }
}
