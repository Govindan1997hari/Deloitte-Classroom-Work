using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlIncsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            readwritexml xml = new readwritexml();
            //xml.writexml();
            xml.readxml();
        }
    }
}
