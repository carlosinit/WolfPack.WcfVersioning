using System.ServiceModel;

namespace WcfVersioning.Client4.Contracts
{    
    [ServiceContract(Namespace = "http://ingenico/echo/V1")]
    public interface IEchoService
    {
        [OperationContract]
        Message Echo(Message message);
        [OperationContract]
        Message EchoWithType(Message message, MessageType? type);
    }
}