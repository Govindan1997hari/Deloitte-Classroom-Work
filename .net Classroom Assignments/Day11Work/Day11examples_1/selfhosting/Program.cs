using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using LoginService;

namespace selfhosting
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(login));
            host.Open();
            Console.WriteLine("Server Started. . .");
            Console.WriteLine("Press Any key to continue. . .");
            Console.ReadLine();

        }
    }
}
