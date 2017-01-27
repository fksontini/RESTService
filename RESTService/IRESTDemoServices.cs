using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace RESTService
{
    [ServiceContract(Name = "RESTDemoServices")]
    public interface IRESTDemoServices
    {
        [OperationContract]
        [WebGet(UriTemplate = Routing.GetClientRoute, BodyStyle = WebMessageBodyStyle.Bare ,RequestFormat =WebMessageFormat.Json)]
        string GetClientNameById(string Id);

        [OperationContract]
        [WebGet(UriTemplate = Routing.HelloWorld, BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat  = WebMessageFormat.Json)]
        string helloWorld(String value);
    }
}
