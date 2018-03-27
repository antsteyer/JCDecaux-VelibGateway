using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using VelibGateway_Service.model;

namespace VelibGateway_Service
{
  [ServiceContract]
  public interface IService
  {
    [OperationContract]
    String TestConnexion(String clientID);

    [OperationContract]
    List<Contract> Contracts();

    [OperationContract]
    List<String> CitiesInContract(String contractName);

    [OperationContract]
    List<Station> StationsOfTheCity(String cityName);

    [OperationContract]
    int NumberOfBikesAvailable(String stationName);
    
  }
}
