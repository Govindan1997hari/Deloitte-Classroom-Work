using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class shapes
    {
        int x, y;
        float l, h;
        float pi=3.14F;
        float r;
        float sarea;
        float half = 0.5F;
        public void area(int x)
        {
            this.x = x;
            sarea = x * x;
            Console.WriteLine("The Area Of Square is " + sarea);
        }
        public void area(int x,int y)
        {
            this.x = x;
            this.y = y;
            sarea = x * y;
            Console.WriteLine("The area of rectangle is " + sarea);
        }
        public void area(float r)
        {
            this.r = r;
            sarea =pi * (r * r);
            Console.WriteLine("The area of circle is " + sarea);
        }
        public void area(float l,float h)
        {
            this.l = l;
            this.h = h;
            sarea = half*(l * h);
            Console.WriteLine("The area of triangle is " + sarea);
        }
    }
}
