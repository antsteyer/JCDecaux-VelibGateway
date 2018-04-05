using System;
using System.Collections.Generic;
using System.ServiceModel;
using VelibGateway_Service.model;

namespace VelibGateway_Service
{
  [ServiceContract(CallbackContract = typeof(IServiceEvents))]
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

    [OperationContract]
    void BikesAvailable(String stationName);

    [OperationContract]
    void SuscribeToStationEvent();
  
    [OperationContract]
    void SuscribeRequestFinishedEvent();
    
  }
}
