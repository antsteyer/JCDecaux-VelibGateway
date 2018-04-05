using System;
using System.Collections.Generic;
using System.Runtime.Caching;
using VelibGateway_Service.model;
using Newtonsoft.Json;
using System.ServiceModel;

namespace VelibGateway_Service
{
  [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
  public class Service : IService
  {

    private VelibWeb velibWeb;
    private static String key = "932c426b59237c8d4817475895cb9ec5b50f3ec1";

    // Service Caches
    private static ObjectCache contractsCache = MemoryCache.Default;
    private static ObjectCache citiesCache = MemoryCache.Default;
    private static ObjectCache stationsCache = MemoryCache.Default;
    private static ObjectCache bikesCache = MemoryCache.Default;

    // Actions
    static Action<String,int> m_Event1 = delegate { };
    static Action m_Event2 = delegate { };

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
        cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(1);
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
        cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(1);
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
            cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(1);
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
        cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(1);
        contractsCache.Add(cityName, stations, cacheItemPolicy);
        return stations;
      }
      
    }

    public string TestConnexion(String clientID)
    {
      return "From Server | Connexion established with : " + clientID;
    }

    public void SuscribeToStationEvent()
    {
      IServiceEvents subscriber = OperationContext.Current.GetCallbackChannel<IServiceEvents>();
      m_Event1 += subscriber.Requested;
    }

    public void SuscribeRequestFinishedEvent()
    {
      IServiceEvents subscriber = OperationContext.Current.GetCallbackChannel<IServiceEvents>();
      m_Event2 += subscriber.RequestFinished;
    }

    public void BikesAvailable(string stationName)
    {
      int result = NumberOfBikesAvailable(stationName);
      m_Event1(stationName, result);
      m_Event2();

    }
  }
}
