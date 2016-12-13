using System.Runtime.Serialization;

namespace WcfVersioning.Client5.Contracts
{
    [DataContract(Namespace = "http://ingenico/messagetype")]
    public enum MessageType
    {
        [EnumMember]
        Echo = 0,
        [EnumMember]
        Information,
        [EnumMember]
        Question
    }
}
