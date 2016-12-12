using System.Runtime.Serialization;

namespace WcfVersioning.Client1.Contracts
{
    [DataContract(Namespace = "http://ingenico/message")]
    public class Message
    {
        [DataMember]
        public string Text { get; private set; }

        public Message(string text)
        {
            Text = text;
        }
    }
}