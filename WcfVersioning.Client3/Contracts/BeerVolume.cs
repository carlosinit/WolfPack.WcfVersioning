using System.Runtime.Serialization;

namespace WcfVersioning.Client3.Contracts
{
    [DataContract(Namespace = "http://ingenico/beervolume")]
    public class BeerVolume
    {
        public BeerVolume(int volume, string unit)
        {
            Volume = volume;
            Unit = unit;
        }

        [DataMember]
        public int Volume { get; private set; }

        [DataMember]
        public string Unit { get; private set; }

        public override string ToString()
        {
            return $"{Volume} {Unit}";
        }
    }
}