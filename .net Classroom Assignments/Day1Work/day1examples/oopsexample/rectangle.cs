using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsexample
{
    class rectangle:shapes
    {
        int len;
        int brd;
        public override void displayshapes()
        {
            base.displayshapes();
            Console.WriteLine("rectangle class");
        }
        public override void displayarea()
        {
            len = 200;
            brd = 50;
            area = len * brd;
            Console.WriteLine("area of rectangle :"+area);
        }
    }
}
