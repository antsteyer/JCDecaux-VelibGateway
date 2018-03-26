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

    public string CitiesInContract(String contractName)
    {
      contractName = contractName.ToUpper();
      Boolean contractFound = false;

      velibWeb = new VelibWeb(key);
      var response = velibWeb.ConnectToAPI("contracts?");
      if (response.Equals("KO"))
      {
        return "Error with API.";
      }
      var contracts = JsonConvert.DeserializeObject<List<Contract>>(response);

      String responseToClient = "----------| Cities in \"" + contractName + "\" | ---------\n";

      foreach (Contract contract in contracts)
      {
        if (contract.name.ToUpper().Equals(contractName))
        {
          contractFound = true;
          foreach (String city in contract.cities)
          {
            responseToClient += city + ", ";
          }
          break;
        }
      }
      if (contractFound)
      {
        // Remove last ,
        responseToClient = responseToClient.Remove(responseToClient.Length - 1);
      }
      else
      {
        responseToClient += "\nContract name not found.";
      }

      responseToClient += "\n--------------------------------";
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

    public string Contracts()
    {
      String responseToClient = "----------| Contracts |----------\n";
      if (!contractsCache.Equals(""))
        responseToClient += contractsCache;
      else
      {
        velibWeb = new VelibWeb(key);
        var response = velibWeb.ConnectToAPI("contracts?");
        if (response.Equals("KO"))
        {
          return "Error with API.";
        }

        var contracts = JsonConvert.DeserializeObject<List<Contract>>(response);
        contractsCache = "";
        foreach (Contract contract in contracts)
        {
          contractsCache += contract.name;
          if (contract.cities.Count > 1)
            contractsCache += "*";
          contractsCache += ", ";
        }
        // Remove the last ,
        contractsCache = contractsCache.Remove(contractsCache.Length - 1);
        responseToClient += contractsCache;

      }
      responseToClient += "\n\nContracts ending with * contain several cities. You can use the command /citiesincontract <nameofcontract> to see these list." +
          " All of the cities stations can be found with the global contract name.\n";
      responseToClient += "--------------------------------";
      return responseToClient;
    }

    public string NumberOfBikesAvailable(String stationName)
    {
      stationName = stationName.ToUpper();
      String responseToClient = "";
      if (stationName.Equals(lastStationName))
      {
        responseToClient += "Number of bikes available at \"" + stationName + "\" : ";
        responseToClient += bikesCache;
      }
      else
      {
        velibWeb = new VelibWeb(key);
        var response = velibWeb.ConnectToAPI("stations?");
        if (response.Equals("KO"))
        {
          return "Error.";
        }

        var stations = JsonConvert.DeserializeObject<List<Station>>(response);
        lastStationName = "";
        bikesCache = "";
        int numberOfStations = 0;
        foreach (Station station in stations)
        {
          if (station.name.Contains(stationName))
          {
            lastStationName = stationName;
            bikesCache = station.available_bikes.ToString();
            responseToClient += "Number of bikes available at \"" + station.name + "\" : ";
            responseToClient += bikesCache + "\n";
            numberOfStations++;
          }
        }
        // If station not found
        if (lastStationName.Equals(""))
        {
          responseToClient += "Station not found.";
        }

        if(numberOfStations > 1)
        {
          responseToClient += "\nMore of one station corresponded to the name given. The cache works only with one result (Try to be more precise on the name of the station to find it).";
          lastStationName = "";
          bikesCache = "";
        }
      }
      return responseToClient;
    }

    public string StationsOfTheCity(String cityName)
    {

      String responseToClient = "----------| Stations |----------\n";
      if (lastContractName.Equals(cityName.ToUpper()))
      {
        responseToClient += stationsCache;
      }
      else
      {
        velibWeb = new VelibWeb(key);
        var response = velibWeb.ConnectToAPI("stations?contract=" + cityName.ToUpper());
        if (response.Equals("KO"))
        {
          return "City name does not exist.";
        }
        var stations = JsonConvert.DeserializeObject<List<Station>>(response);

        lastContractName = cityName.ToUpper();
        stationsCache = "";
        foreach (Station station in stations)
        {
          stationsCache += station.name + ", ";
        }
        stationsCache = stationsCache.Remove(stationsCache.Length - 1);
        responseToClient += stationsCache;
      }

      responseToClient += "\n";
      responseToClient += "--------------------------------";
      return responseToClient;
    }

    public string TestConnexion(String clientID)
    {
      return "From Server | Connexion established with : " + clientID;
    }
  }
}
