﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    public class NoMatchException:Exception
    {
        public NoMatchException(string Ename):base(Ename)
        {

        }
    }
}
