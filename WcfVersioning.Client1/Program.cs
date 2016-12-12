using System;
using System.ServiceModel;
using WcfVersioning.Client1.Contracts;

namespace WcfVersioning.Client1
{
    internal class Program
    {
        private static void Main()
        {
            using (var factory = new ChannelFactory<IEchoService>("*"))
            {
                var result = factory.CreateChannel().Echo(new Message("Hello world"));
                Console.WriteLine(result.Text);
                Console.Read();
            }
        }
    }
}