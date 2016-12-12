using System;
using WcfVersioning.Contracts.V1;

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

            return new Message(
                $"Echo: {message.Text} @ {creationDate}",
                author);
        }
    }
}