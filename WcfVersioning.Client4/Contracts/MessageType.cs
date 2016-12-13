using System.Runtime.Serialization;

namespace WcfVersioning.Client4.Contracts
{
    [DataContract(Namespace = "http://ingenico/messagetype")]
    public enum MessageType
    {
        [EnumMember]
        Information,
        [EnumMember]
        Question
    }
}
