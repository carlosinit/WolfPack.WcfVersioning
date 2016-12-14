using System;
using System.ServiceModel;
using WcfVersioning.Client4.Contracts;

namespace WcfVersioning.Client4
{
    class Program
    {
        static void Main()
        {
            using (var factory = new ChannelFactory<IEchoService>("*"))
            {
                var author = new Author("Carlos", "Marc", new DateTime(2005, 1, 1));
                author.SaveFavoriteBeer("Chimay Red", new BeerVolume(200, "ml"));

                try
                {
                    var service = factory.CreateChannel();
                    Console.WriteLine(service.EchoWithType(new Message("Hello world", author, MessageType.Question), MessageType.Question).Type);
                    Console.WriteLine(service.EchoWithType(new Message("Hello world", author, MessageType.Information), MessageType.Information).Type);
                    factory.CreateChannel().EchoWithType(new Message("Hello world", author, MessageType.Question), null);
                }
                catch (FaultException exception)
                {
                    if (exception.Message.Contains("'Invalid enum value 'Echo'"))
                    {
                        Console.WriteLine($"Expected: {exception.Message}");
                        Console.Read();
                        return;
                    }
                    throw;
                }
            }
        }
    }
}
