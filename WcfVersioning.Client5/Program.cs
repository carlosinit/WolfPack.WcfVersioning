using System;
using System.ServiceModel;
using WcfVersioning.Client5.Contracts;
using WcfVersioning.Client5.Contracts.Animals;

namespace WcfVersioning.Client5
{
    internal class Program
    {
        private static void Main()
        {
            using (var factory = new ChannelFactory<IEchoService>("*"))
            {
                try
                {
                    Print((dynamic)factory.CreateChannel().GetRandomAnimal(0));
                    Print((dynamic)factory.CreateChannel().GetRandomAnimal(1));
                    Print((dynamic)factory.CreateChannel().GetRandomAnimal(2));
                }
                catch (FaultException exception)
                {
                    if (exception.Message.Contains(
                            "Element 'http://ingenico/echo/V1:GetRandomAnimalResult' contains data from a type " +
                            "that maps to the name 'http://ingenico/animals/fish:Fish'. " +
                            "The deserializer has no knowledge of any type that maps to this name"))
                    {
                        Console.WriteLine("Unknown animal received");
                        Console.Read();
                        return;
                    }
                    throw;
                }
            }
        }

        private static void Print(Animal animal)
        {
            Console.WriteLine($"{animal.GetType().Name} {animal.Name} arrived");
        }

        private static void Print(Dog dog)
        {
            Print(dog as Animal);
            Console.WriteLine($"{dog.Name} has {dog.LegsNumber} legs");
        }

        private static void Print(Snake snake)
        {
            Print(snake as Animal);
            Console.WriteLine($"{snake.Name} is {snake.BodyLength}cm long");
        }
    }
}