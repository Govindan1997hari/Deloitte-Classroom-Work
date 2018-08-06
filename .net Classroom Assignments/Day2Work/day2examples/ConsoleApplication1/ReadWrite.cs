using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class ReadWrite
    {
        public void writefile(string fname)
        {
            StreamWriter write = new StreamWriter(fname,true);
            try
            {
                Console.WriteLine("enter data to be written to file");
                string data = Console.ReadLine();
                write.WriteLine(data);
                Console.WriteLine("Data written to file");
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }
            finally
            {
                write.Close();
            }

        }
        public void readfile(string fname)
        {
            StreamReader read = new StreamReader(fname);
            try
            {
                string data = read.ReadToEnd();
                Console.WriteLine("Data read from file");
                Console.WriteLine(data);

            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }
            finally
            {
                read.Close();
            }
        }
    }
}
