using System.Runtime.Serialization;

namespace WcfVersioning.Contracts.V1
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
