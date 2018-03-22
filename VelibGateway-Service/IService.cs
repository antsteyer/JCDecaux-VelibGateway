using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace VelibGateway_Service
{
  [ServiceContract]
  public interface IService
  {
    [OperationContract]
    string showCoucou();
  }
}
