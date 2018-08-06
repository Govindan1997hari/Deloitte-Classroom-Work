using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WcfServiceLibrary1;

namespace SelfHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost host = new ServiceHost(typeof(cardinfo));
                host.Open();
                Console.WriteLine("Started To Host. . .");
                Console.WriteLine("Press Any Key To Exit. . .");
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
