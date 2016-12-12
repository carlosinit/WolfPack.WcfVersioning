using System;
using System.Linq;
using System.ServiceModel;

namespace WcfVersioning.ConsoleHost
{
    internal class Program
    {
        private static void Main()
        {
            using (var host = new ServiceHost(typeof(EchoService)))
            {
                host.Open();

                Console.WriteLine("The service is ready at {0}", host.BaseAddresses.FirstOrDefault());
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }
        }
    }
}