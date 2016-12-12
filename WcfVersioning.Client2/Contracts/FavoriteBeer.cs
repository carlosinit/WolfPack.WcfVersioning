using System.Runtime.Serialization;

namespace WcfVersioning.Client2.Contracts
{
    [DataContract(Namespace = "http://ingenico/favoritebeer")]
    public class FavoriteBeer
    {
        public FavoriteBeer(string name, decimal volume)
        {
            Name = name;
            Volume = volume;
        }

        [DataMember]
        public string Name { get; private set; }

        [DataMember]
        public decimal Volume
        {
            get;private set;
        }

        public override string ToString()
        {
            return $"{Name} {Volume} cl";
        }
    }
}