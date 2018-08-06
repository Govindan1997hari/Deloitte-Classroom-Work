using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class UpperNameException:Exception
    {
        string msg;
        public UpperNameException()
        {
            msg = "Name has to be in Upper case";
        }
        public UpperNameException(string m)
        {
            msg = m;
        }
        public override string Message
        {
            get
            {
                return msg;
            }
        }
    }
}
