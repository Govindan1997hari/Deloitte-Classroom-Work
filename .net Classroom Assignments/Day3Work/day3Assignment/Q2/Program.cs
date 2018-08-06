using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            float l, h;
            float r;
            Console.WriteLine("Enter the Length of sqare to find the Area of square:");
            x = int.Parse(Console.ReadLine());
            shapes s = new shapes();
            s.area(x);
            Console.WriteLine("Enter the length and breadth to find the area of rectangle:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            s.area(x, y);

            Console.WriteLine("enter the radious to find the area of circle:");
            r = float.Parse(Console.ReadLine());
            s.area(r);
            Console.WriteLine("enter the length and height to find the area of triangle");
            l = float.Parse(Console.ReadLine());
            h = float.Parse(Console.ReadLine());
            s.area(l, h);
        }
    }
}
