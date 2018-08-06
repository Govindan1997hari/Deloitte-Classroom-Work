using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class calculator : icalculator
    {
        public int add(int x, int y)
        {
            if (x <= 0 || y <= 0)
                throw new ArgumentException("THe parameter value has to be positive");
            else
                return (x + y);
        }

        public int sub(int x, int y)
        {
            if (x < y)
                throw new ArgumentException("Cannot subtract lesser value from greater value");
            else if (x <= 0 || y <= 0)
                throw new ArgumentException("THe parameter value has to be positive");
            else
                return (x - y);
        }
    }
}
