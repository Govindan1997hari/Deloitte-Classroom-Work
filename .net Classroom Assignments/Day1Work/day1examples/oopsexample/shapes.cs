using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsexample
{
    abstract class shapes
    {
        protected double area;// variable
        public abstract void displayarea();
        public virtual void displayshapes()
        {
            Console.WriteLine("this is shapes class");
        }
    }
}
