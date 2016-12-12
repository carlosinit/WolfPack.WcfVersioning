using System;
using System.Runtime.Serialization;

namespace WcfVersioning.Contracts.V1
{
    [DataContract(Namespace = "http://ingenico/message")]
    public class Message
    {
        [DataMember]
        public string Text { get; private set; }

        [DataMember]
        public DateTime CreationDate { get; private set; }

        [DataMember]
        public Author Author { get; private set; }

        public Message(string text, Author author)
        {
            Text = text;
            Author = author;
            CreationDate = DateTime.UtcNow;
        }
    }
}