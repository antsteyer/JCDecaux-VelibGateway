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
    String TestConnexion(String clientID);

    [OperationContract]
    String Contracts();

    [OperationContract]
    String CitiesInContract(String contractName);

    [OperationContract]
    String StationsOfTheCity(String cityName);

    [OperationContract]
    String NumberOfBikesAvailable(String stationName);

    [OperationContract]
    String ClearCaches();
  }
}
