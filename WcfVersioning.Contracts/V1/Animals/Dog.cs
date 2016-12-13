using System.Runtime.Serialization;

namespace WcfVersioning.Contracts.V1.Animals
{
    [DataContract(Namespace = "http://ingenico/animals/dog")]
    public class Dog : Animal
    {
        [DataMember]
        public int LegsNumber { get; private set; }

        public Dog(string name, int legsNumber) : base(name)
        {
            LegsNumber = legsNumber;
        }
    }
}