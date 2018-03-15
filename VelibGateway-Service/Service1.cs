using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace VelibGateway_Service
{
    
    public class Service1 : IService1
    {
        [WebInvoke( Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "data/{value}")]
        public string GetData(string value)
        {
            return string.Format("You entered: "+value);
        }
    }
}
