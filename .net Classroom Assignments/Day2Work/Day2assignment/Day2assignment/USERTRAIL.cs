using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2assignment
{
    class USERTRAIL
    {
        int val1, val2;
        public void show(int val1,int val2)
        {
            this.val1 = val1;
            this.val2 = val2;
            if (val1 < 0)
            {
                throw new Exception("Error: Value of First input is less than 0");
            }
            if (val2 < 0)
            {
                throw new Exception("Error: Value of second input is less than 0");
            }
        }
        public void calculate(int val1,int val2)
        {
            this.val1 = val1;
            this.val2 = val2;
            int bal;
            bal = val1 - val2;
            if(bal>=0)
            {
                Console.WriteLine("The balance is Greater than  0 and the result is " + bal);
            }
            else
            {
                throw new Exception("Error:The result of subtraction is less than 0"); 
            }
        }
    }
}
