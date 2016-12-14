using System.ServiceModel;
using WcfVersioning.Contracts.V1.Animals;

namespace WcfVersioning.Contracts.V1
{
    [ServiceContract(Namespace = "http://ingenico/echo/V1")]
    public interface IEchoService
    {
        [OperationContract]
        Message Echo(Message message);

        [OperationContract]
        Message EchoWithType(Message message, MessageType? type);

        [OperationContract]
        Animal GetRandomAnimal(int value);        
    }
}