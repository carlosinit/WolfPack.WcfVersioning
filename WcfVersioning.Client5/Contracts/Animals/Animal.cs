using System.Runtime.Serialization;

namespace WcfVersioning.Client5.Contracts.Animals
{
    [DataContract(Namespace = "http://ingenico/animals/animal")]
    [KnownType(typeof(Dog))]
    [KnownType(typeof(Snake))]
    public abstract class Animal
    {
        [DataMember]
        public string Name { get; private set; }

        protected Animal(string name)
        {
            Name = name;
        }
    }
}