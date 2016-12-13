using System.Runtime.Serialization;

namespace WcfVersioning.Contracts.V1.Animals
{
    [DataContract(Namespace = "http://ingenico/animals/fish")]
    public class Fish : Animal
    {
        [DataMember]
        public decimal Weight { get; private set; }

        public Fish(string name, decimal weight) : base(name)
        {
            Weight = weight;
        }
    }
}