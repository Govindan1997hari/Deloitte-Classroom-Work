using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class person
    {
        string fname;
        string lname;
        string email;
        DateTime DOB;
        string s_sign;
        int age;
        public person(string fname,string lname,string email,DateTime DOB)
        {
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.DOB = DOB;
        }
        public person(string fname, string lname, string email)
        {
            this.fname = fname;
            this.lname = lname;
            this.email = email;
        }
        public person(string fname, string lname, DateTime DOB)
        {
            this.fname = fname;
            this.lname = lname;
            this.DOB = DOB;
        }
        public void adult()
        {
            age = DateTime.Now.Year - DOB.Year;
            if (age > 18)
            {
                Console.WriteLine("The User is Above 18");
            }
            else
                Console.WriteLine("The user is Under 18");
        }
        public void sun_sign()
        {
            if(DOB.Month==3)
            {
                s_sign = "aries";
                Console.WriteLine("The Sun sign is " + s_sign);
            }
            else if (DOB.Month == 4)
            {
                s_sign = "taurus";
                Console.WriteLine("The Sun sign is " + s_sign);
            }
            else if (DOB.Month == 5)
            {
                s_sign = "gemini";
                Console.WriteLine("The Sun sign is " + s_sign);
            }
            else if (DOB.Month == 6)
            {
                s_sign = "cancer";
                Console.WriteLine("The Sun sign is " + s_sign);
            }
            else if (DOB.Month == 7)
            {
                s_sign = "leo";
                Console.WriteLine("The Sun sign is " + s_sign);
            }
            else if (DOB.Month == 8)
            {
                s_sign = "virgo";
                Console.WriteLine("The Sun sign is " + s_sign);
            }
            else if (DOB.Month == 9)
            {
                s_sign = "libra";
                Console.WriteLine("The Sun sign is " + s_sign);
            }
            else if (DOB.Month == 10)
            {
                s_sign = "scorpio";
                Console.WriteLine("The Sun sign is " + s_sign);
            }
            else if (DOB.Month == 11)
            {
                s_sign = "sagittarius";
                Console.WriteLine("The Sun sign is " + s_sign);
            }
            else if (DOB.Month == 12)
            {
                s_sign = "capricon";
                Console.WriteLine("The Sun sign is " + s_sign);
            }
            else if (DOB.Month == 1)
            {
                s_sign = "aquarias";
                Console.WriteLine("The Sun sign is " + s_sign);
            }
            else if (DOB.Month == 2)
            {
                s_sign = "pisces";
                Console.WriteLine("The Sun sign is " + s_sign);
            }
        }
        public void birthday()
        {
            int months = DateTime.Now.Month - DOB.Month;
            int date = DateTime.Now.Date - DOB.Date;
            if ((months==0)&&(date==0))
            {
                Console.WriteLine("Happy BirthDay !! \n Many more happy returns of the day.");
            }
            else
            {
                Console.WriteLine("Sorry but Your Birthday is On " + DOB);
            }   
        }
    }
}
