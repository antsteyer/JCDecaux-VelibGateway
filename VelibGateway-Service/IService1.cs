using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace VelibGateway_Service
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(string value);
        
    }
}
