using System;
using System.Runtime.Remoting.Channels;
using WcfVersioning.Contracts.V1;
using WcfVersioning.Contracts.V1.Animals;

namespace WcfVersioning.ConsoleHost
{
    public class EchoService : IEchoService
    {
        Message IEchoService.Echo(Message message)
        {
            var creationDate = message.CreationDate;
            if (creationDate == default(DateTime))
            {
                creationDate = DateTime.UtcNow;
            }
            var author = message.Author ?? Author.UnknownAuthor;

            Console.WriteLine($"Received {message.Text} @ {creationDate} by {author.FullName}");
            Console.WriteLine($"who is born on the {author.BirthDate}");
            Console.WriteLine($"and likes {author.FavoriteBeer}");
            Console.WriteLine($"This is a {message.Type} message");

            return new Message(
                $"Echo: {message.Text} @ {creationDate}",
                author,
                MessageType.Echo);
        }

        public Animal GetRandomAnimal(int value)
        {
            switch (value)
            {
                case 1: return new Snake("Fnake", 150);
                case 2: return new Fish("Nemo", 1.5m);
                default: return new Dog("Fluke", 4);
            }
        }

        public int GetNumber()
        {
            return 5;
        }
    }
}