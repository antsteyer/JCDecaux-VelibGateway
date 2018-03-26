using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelibGateway_ClientConsole.VelibServiceReference;

namespace VelibGateway_ClientConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      ServiceClient client = new ServiceClient();
      Boolean exit = false;
      Console.WriteLine("--_VelibGateway Shell Client SOAP -v1.0_--");
      Console.WriteLine("Use /exit at anytime to end.");
      Console.WriteLine("Use /help at anytime to show all commands available.");
      while (!exit)
      {
        Console.Write(">_ ");
        String command = Console.ReadLine();
        String contractName;
        Console.WriteLine();
        switch (command) {
          case "/exit":
            exit = true;
            break;
          case "/test":
            Console.WriteLine(client.TestConnexion("Client Console"));
            break;
          case "/contracts":
            Console.WriteLine(client.Contracts());
            break;
          case "/citiesincontract":
            Console.Write("Enter the name of the contract : ");
            contractName = Console.ReadLine();
            Console.WriteLine(client.CitiesInContract(contractName));
            break;
          case "/stations":
            Console.Write("Enter the name of the city : ");
            contractName = Console.ReadLine();
            Console.WriteLine(client.StationsOfTheCity(contractName));
            break;
          case "/bikes":
            Console.Write("Enter the name of the station : ");
            String stationName = Console.ReadLine();
            Console.WriteLine(client.NumberOfBikesAvailable(stationName));
            break;
          case "/clear":
            Console.WriteLine(client.ClearCaches());
            break;
          case "/help":
            Console.WriteLine(help());
            break;
          default:
            Console.WriteLine("Unknown Command.");
            break;
        }
        Console.WriteLine();
      }
    }

    static string help()
    {
      return  "----------| Commands |----------\n"
            + "/test : Test the connection with the server.\n"
            + "/contracts : Print all the Velib contracts (cities).\n"
            + "/citiesincontract : Print all the cities in the velib contract given.\n"
            + "/stations : Print all the stations in the velib contract given.\n"
            + "/bikes : Number of bikes available in the given velib station.\n"
            + "/clear : Clear the caches used by Velib Gateway Service.\n"
            + "/exit : Exit the application.\n"
            + "--------------------------------";
    }
  }
}
