using System.ComponentModel;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.

    [ServiceContract]
    public interface ITest
    {
        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest, UriTemplate = "/TestServiceInCode")]
        [Description("Teste service in code")]
        void TestServiceInCode(string json);
    }
}

