using System;
using System.Runtime.Serialization;

namespace WcfVersioning.Client3.Contracts
{
    [DataContract(Namespace = "http://ingenico/author")]
    public class Author
    {        
        public Author(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        [DataMember]
        public string FirstName { get; private set; }

        [DataMember]
        public string LastName { get; private set; }

        [DataMember]
        public DateTime BirthDate { get; private set; }
        [DataMember]
        public FavoriteBeer FavoriteBeer { get; private set; }        

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public Author SaveFavoriteBeer(string name, BeerVolume volume)
        {
            FavoriteBeer = new FavoriteBeer(name, volume);
            return this;
        }
    }
}