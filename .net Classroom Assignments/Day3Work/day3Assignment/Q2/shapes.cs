using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class shapes
    {
        int x, y;
        float l, h;
        float pi = 3.14F;
        float r;
        float sarea;
        float half = 0.5F;
        [MethodInfo(methodname ="AreaOfSquare",returntype ="Int",parameters =1,message ="This class is used to calculate the Area of square")]
        public void area(int x)
        {
            this.x = x;
            sarea = x * x;
            Console.WriteLine("The Area Of Square is " + sarea);
        }
        [MethodInfo(methodname = "AreaOfRectangle", returntype = "Int", parameters = 2, message = "This class is used to calculate the Area of Rectangle")]
        public void area(int x, int y)
        {
            this.x = x;
            this.y = y;
            sarea = x * y;
            Console.WriteLine("The area of rectangle is " + sarea);
        }
        [MethodInfo(methodname = "AreaOfCircle", returntype = "float", parameters = 1, message = "This class is used to calculate the Area of circle")]
        public void area(float r)
        {
            this.r = r;
            sarea = pi * (r * r);
            Console.WriteLine("The area of circle is " + sarea);
        }
        [MethodInfo(methodname = "AreaOftriangle", returntype = "float", parameters = 2, message = "This class is used to calculate the Area of triangle")]
        public void area(float l, float h)
        {
            this.l = l;
            this.h = h;
            sarea = half * (l * h);
            Console.WriteLine("The area of triangle is " + sarea);
        }
    }
}
