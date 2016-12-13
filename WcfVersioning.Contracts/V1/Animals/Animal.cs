using System.Runtime.Serialization;

namespace WcfVersioning.Contracts.V1.Animals
{
    [DataContract(Namespace = "http://ingenico/animals/animal")]
    [KnownType(typeof(Dog))]
    [KnownType(typeof(Snake))]
    [KnownType(typeof(Fish))]
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