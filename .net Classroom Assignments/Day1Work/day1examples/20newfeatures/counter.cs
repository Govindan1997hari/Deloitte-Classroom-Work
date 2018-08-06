using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20newfeatures
{
    static class counter
    {
        static int count;
        static counter()
        {
            count = 10;
        }
        public static void countdata()
        {
            int ctr = 0;
            ctr++;
            count++;
            Console.WriteLine("ctr:" + ctr);
            Console.WriteLine("count:" + count);
        }
    }
}
