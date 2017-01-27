using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Threading.Tasks;

namespace RESTService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single, IncludeExceptionDetailInFaults = true)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RestDemoServices : IRESTDemoServices
    {
        public string GetClientNameById(String id)
        {
            Random r = new Random();
            string ReturnString = "";
            int Idnum = Convert.ToInt32(id);
            for (int i = 0; i < Idnum; i++)
                ReturnString += char.ConvertFromUtf32(r.Next(65, 85));

            return ReturnString;
        }

        public string helloWorld(String value)
        {
            return "Hello World ya " + value;
        }
    }
}
