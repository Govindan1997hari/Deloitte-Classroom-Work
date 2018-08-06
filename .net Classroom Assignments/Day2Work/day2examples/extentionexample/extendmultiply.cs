using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace extentionexample
{
    static class extendmultiply
    {
        public static int mul(this calculator c,int x, int y)
        {
            return (x * y);
        }
    }
}
