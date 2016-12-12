using System;
using System.Runtime.Serialization;

namespace WcfVersioning.Contracts.V1
{
    [DataContract(Namespace = "http://ingenico/author")]
    public class Author
    {
        public readonly static Author UnknownAuthor = new Author("Unknown", "", new DateTime(2000, 1, 1)).SaveFavoriteBeer("Jupiler", new BeerVolume(100, "cl"));

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