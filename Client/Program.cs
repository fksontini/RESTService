using RESTService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            RestDemoServices DemoServices = new RestDemoServices();
            WebHttpBinding binding = new WebHttpBinding();
            WebHttpBehavior behavior = new WebHttpBehavior();

            WebServiceHost _serviceHost = new WebServiceHost(DemoServices, new Uri("http://localhost:8000/DEMOService"));
            _serviceHost.AddServiceEndpoint(typeof(IRESTDemoServices), binding, "");
            _serviceHost.Open();
            Console.ReadKey();
            _serviceHost.Close();
        }
    }
}
