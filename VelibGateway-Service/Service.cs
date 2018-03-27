using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelibGateway_Service.model;
using Newtonsoft.Json;

namespace VelibGateway_Service
{
  public class Service : IService
  {

    private VelibWeb velibWeb;
    private static String key = "932c426b59237c8d4817475895cb9ec5b50f3ec1";

    // Service Caches
    private static String contractsCache = "";
    private static String stationsCache = "";
    private static String lastContractName = "";
    private static String bikesCache = "";
    private static String lastStationName = "";

    public List<String> CitiesInContract(String contractName)
    {
      contractName = contractName.ToUpper();

      velibWeb = new VelibWeb(key);
      var response = velibWeb.ConnectToAPI("contracts?");
      if (response.Equals("KO"))
      {
        return null;
      }
      List<Contract> contracts = JsonConvert.DeserializeObject<List<Contract>>(response);

      List<String> responseToClient = new List<String>();
      foreach (Contract contract in contracts)
      {
        if (contract.name.ToUpper().Equals(contractName))
        {
          foreach (String city in contract.cities)
          {
            responseToClient.Add(city);
          }
          break;
        }
      }
      return responseToClient;
    }

    public String ClearCaches()
    {
      contractsCache = "";
      stationsCache = "";
      lastContractName = "";
      bikesCache = "";
      lastStationName = "";
      return "Caches cleaned.";
    }

    public List<Contract> Contracts()
    {
      velibWeb = new VelibWeb(key);
      var response = velibWeb.ConnectToAPI("contracts?");
      if (response.Equals("KO"))
      {
        return null;
      }
      List<Contract> contracts = JsonConvert.DeserializeObject<List<Contract>>(response);
      return contracts;
    }

    public Dictionary<String, int> NumberOfBikesAvailable(String stationName)
    {
      stationName = stationName.ToUpper();
      velibWeb = new VelibWeb(key);
      var response = velibWeb.ConnectToAPI("stations?");
      if (response.Equals("KO"))
      {
        return null;
      }

      var stations = JsonConvert.DeserializeObject<List<Station>>(response);
      Dictionary<String, int> responseToClient = new Dictionary<string, int>();

      foreach (Station station in stations)
      {
        if (station.name.Contains(stationName))
        {
          responseToClient.Add(station.name, station.available_bikes);
        }
      }

      return responseToClient;
    }

    public List<Station> StationsOfTheCity(String cityName)
    {
      velibWeb = new VelibWeb(key);
      var response = velibWeb.ConnectToAPI("stations?contract=" + cityName.ToUpper());
      if(response.Equals("KO"))
      {
        return null;
      }
      var stations = JsonConvert.DeserializeObject<List<Station>>(response);
      return stations;
    }

    public string TestConnexion(String clientID)
    {
      return "From Server | Connexion established with : " + clientID;
    }
  }
}
