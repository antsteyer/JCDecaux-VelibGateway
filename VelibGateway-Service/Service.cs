using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
using VelibGateway_Service.model;
using Newtonsoft.Json;

namespace VelibGateway_Service
{
  public class Service : IService
  {

    private VelibWeb velibWeb;
    private static String key = "932c426b59237c8d4817475895cb9ec5b50f3ec1";

    // Service Caches
    private static ObjectCache contractsCache = MemoryCache.Default;
    private static ObjectCache citiesCache = MemoryCache.Default;
    private static ObjectCache stationsCache = MemoryCache.Default;
    private static ObjectCache bikesCache = MemoryCache.Default;

    public List<String> CitiesInContract(String contractName)
    {
      contractName = contractName.ToUpper();
      if (citiesCache.Contains(contractName))
      {
        return (List<String>)citiesCache.Get(contractName);
      }
      else
      {
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
        CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
        cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(30);
        contractsCache.Add(contractName, responseToClient, cacheItemPolicy);
        return responseToClient;
      }
      
    }

    public List<Contract> Contracts()
    {
      if(contractsCache.Contains("Contracts"))
      {
        return (List<Contract>)contractsCache.Get("Contracts");
      }
      else
      {
        velibWeb = new VelibWeb(key);
        var response = velibWeb.ConnectToAPI("contracts?");
        if (response.Equals("KO"))
        {
          return null;
        }
        List<Contract> contracts = JsonConvert.DeserializeObject<List<Contract>>(response);
        CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
        cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(30);
        contractsCache.Add("Contracts", contracts, cacheItemPolicy);
        return contracts;
      }
      
    }

    public int NumberOfBikesAvailable(String stationName)
    {
      stationName = stationName.ToUpper();

      if(bikesCache.Contains(stationName))
      {
        return (int)bikesCache.Get(stationName);
      }
      else
      {
        velibWeb = new VelibWeb(key);
        var response = velibWeb.ConnectToAPI("stations?");
        if (response.Equals("KO"))
        {
          return -1;
        }

        var stations = JsonConvert.DeserializeObject<List<Station>>(response);
        int responseToClient = -1;
        foreach (Station station in stations)
        {
          if (station.name.Equals(stationName))
          {
            responseToClient = station.available_bikes;
            CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
            cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(30);
            contractsCache.Add(stationName, responseToClient, cacheItemPolicy);
            break;
          }
        }

        return responseToClient;
      }
      
    }

    public List<Station> StationsOfTheCity(String cityName)
    {
      cityName = cityName.ToUpper();
      if(stationsCache.Contains(cityName))
      {
        return (List<Station>)stationsCache.Get(cityName);
      }
      else
      {
        velibWeb = new VelibWeb(key);
        var response = velibWeb.ConnectToAPI("stations?contract=" + cityName);
        if (response.Equals("KO"))
        {
          return null;
        }
        var stations = JsonConvert.DeserializeObject<List<Station>>(response);

        CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
        cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(30);
        contractsCache.Add(cityName, stations, cacheItemPolicy);
        return stations;
      }
      
    }

    public string TestConnexion(String clientID)
    {
      return "From Server | Connexion established with : " + clientID;
    }
  }
}
