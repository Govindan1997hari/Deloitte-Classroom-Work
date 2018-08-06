using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20newfeatures
{
    class swapexample<T>
    {
        public void swap(ref T a,ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
