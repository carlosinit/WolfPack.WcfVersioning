using System.Runtime.Serialization;

namespace WcfVersioning.Client5.Contracts.Animals
{
    [DataContract(Namespace = "http://ingenico/animals/snake")]    
    public class Snake : Animal
    {
        [DataMember]
        public int BodyLength { get; private set; }

        public Snake(string name, int bodyLength) : base(name)
        {
            BodyLength = bodyLength;
        }
    }
}