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
    private String contractsCache = "";

    public string CitiesInContract(string contractName)
    {
      throw new NotImplementedException();
    }

    public String ClearCaches()
    {
      contractsCache = "";
      return "Caches cleaned.\n";
    }

    public string Contracts()
    {
      velibWeb = new VelibWeb(key);
      var response = velibWeb.ConnectToAPI("contracts?");
      var contracts = JsonConvert.DeserializeObject<List<Contract>>(response);
      String responseToClient = "----------| Contracts | ---------\n";
      if (!contractsCache.Equals(""))
        responseToClient += contractsCache;
      else
      {
        contractsCache = "";
        foreach (Contract contract in contracts)
        {
          contractsCache += contract.name;
          if (contract.cities.Count > 1)
            contractsCache += "*";
          contractsCache += ", ";
        }
        // Remove the last ,
        contractsCache.Remove(contractsCache.Length - 1);
        responseToClient += contractsCache;
        
      }
      responseToClient += "\n| Contracts ending with * contains several cities. You can use the command /citiesincontract <nameofcontract> to see these list." +
          " All of the cities stations can be found with the global contract name.\n";
      responseToClient += "--------------------------------";
      return responseToClient;
    }

    public int NnumberOfBikesAvailable(string stationName)
    {
      throw new NotImplementedException();
    }

    public string StationsOfTheCity(string cityName)
    {
      throw new NotImplementedException();
    }

    public string TestConnexion(string clientID)
    {
      return "From Server | Connexion established with : " + clientID;
    }
  }
}
