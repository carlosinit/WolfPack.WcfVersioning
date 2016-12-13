using System.Runtime.Serialization;

namespace WcfVersioning.Client5.Contracts
{
    [DataContract(Namespace = "http://ingenico/favoritebeer")]
    public class FavoriteBeer
    {
        public FavoriteBeer(string name, BeerVolume volume)
        {
            Name = name;
            BeerVolume = volume;
        }

        [DataMember]
        public string Name { get; private set; }

        [DataMember]
        public BeerVolume BeerVolume { get; private set; }

        [DataMember]
        public decimal Volume
        {
            get { return BeerVolume.Volume; }
            private set
            {
                if (BeerVolume == null)
                {
                    BeerVolume = new BeerVolume((int)value, "cl");
                }
            }
        }

        public override string ToString()
        {
            return $"{Name} {BeerVolume}";
        }
    }
}