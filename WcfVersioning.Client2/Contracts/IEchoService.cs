using System.ServiceModel;

namespace WcfVersioning.Client2.Contracts
{    
    [ServiceContract(Namespace = "http://ingenico/echo/V1")]
    public interface IEchoService
    {
        [OperationContract]
        Message Echo(Message message);
    }
}