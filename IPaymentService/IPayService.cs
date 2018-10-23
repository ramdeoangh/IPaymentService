using IPaymentService.Model;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace IPaymentService
{
    [ServiceContract]
    public interface IPayService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", 
            ResponseFormat = WebMessageFormat.Xml, 
            BodyStyle = WebMessageBodyStyle.Wrapped, 
            UriTemplate = "xml/{id}")]
        string XMLData(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", 
            ResponseFormat = WebMessageFormat.Json, 
            BodyStyle = WebMessageBodyStyle.Wrapped, 
            UriTemplate = "json/{id}")]
        string JSONData(string id);

        [OperationContract]
        bool Connect(SocketConnectRequest connectRequest);


        [OperationContract(Name = "HeartBeat")]
        bool CheckHeartBeat();
    }
}