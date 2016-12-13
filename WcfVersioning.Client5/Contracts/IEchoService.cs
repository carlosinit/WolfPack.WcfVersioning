using System.ServiceModel;
using WcfVersioning.Client5.Contracts.Animals;

namespace WcfVersioning.Client5.Contracts
{
    [ServiceContract(Namespace = "http://ingenico/echo/V1")]
    public interface IEchoService
    {
        [OperationContract]
        Message Echo(Message message);

        [OperationContract]
        Animal GetRandomAnimal(int value);
    }
}