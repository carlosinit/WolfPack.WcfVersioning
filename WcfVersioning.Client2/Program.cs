﻿using System;
using System.ServiceModel;
using WcfVersioning.Client2.Contracts;

namespace WcfVersioning.Client2
{
    internal class Program
    {
        private static void Main()
        {
            using (var factory = new ChannelFactory<IEchoService>("*"))
            {
                var author = new Author("Carlos", "Marc", new DateTime(2005, 1, 1));
                author.SaveFavoriteBeer("Chimay Bleu", 100);
                var result = factory.CreateChannel().Echo(new Message("Hello world", author));
                Console.WriteLine($"Message received: {result.Text}");
                Console.WriteLine($"Author received: {result.Author.FullName} born on {result.Author.BirthDate}");
                Console.WriteLine($"And likes {result.Author.FavoriteBeer}");
                Console.Read();
            }
        }
    }
}