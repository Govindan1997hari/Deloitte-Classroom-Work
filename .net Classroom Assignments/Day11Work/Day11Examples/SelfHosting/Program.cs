﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CalculatorLibrary;

namespace SelfHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost host = new ServiceHost(typeof(calculator));
                host.Open();
                Console.WriteLine("Server Started...");
                Console.WriteLine("Press any key to stop the server");
                Console.ReadLine();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
