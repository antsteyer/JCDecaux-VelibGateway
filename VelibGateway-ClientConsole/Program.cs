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
        System.Diagnostics.Stopwatch watch;
        Console.WriteLine();
        switch (command)
        {
          case "/exit":
            exit = true;
            break;
          case "/test":
            watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(client.TestConnexion("Client Console"));
            watch.Stop();
            Console.WriteLine("(Command executed in " + watch.ElapsedMilliseconds + "ms.)");
            break;
          case "/contracts":
            watch = System.Diagnostics.Stopwatch.StartNew();
            Contract[] contracts = client.Contracts();
            if (contracts == null)
            {
              Console.WriteLine("Command Failed.");
              watch.Stop();
              break;
            }
            foreach (Contract contract in contracts)
            {
              Console.WriteLine("- "+contract.name);
            }

            watch.Stop();
            Console.WriteLine("(Command executed in " + watch.ElapsedMilliseconds + "ms.)");
            break;
          case "/citiesincontract":
            Console.Write("Enter the name of the contract : ");
            contractName = Console.ReadLine();
            watch = System.Diagnostics.Stopwatch.StartNew();
            String[] cities = client.CitiesInContract(contractName);
            watch.Stop();
            if ((cities == null) || (cities.Length == 0))
            {
              Console.WriteLine("Wrong contract name.");
              break;
            }
            foreach (String city in cities)
            {
              Console.WriteLine("- "+city);
            }

            Console.WriteLine("(Command executed in " + watch.ElapsedMilliseconds + "ms.)");
            break;
          case "/stations":
            Console.Write("Enter the name of the city : ");
            contractName = Console.ReadLine();
            watch = System.Diagnostics.Stopwatch.StartNew();
            Station[] stations = client.StationsOfTheCity(contractName);
            watch.Stop();
            if ((stations == null) || (stations.Length == 0))
            {
              Console.WriteLine("Wrong city name.");
              break;
            }
            foreach (Station station in stations)
            {
              Console.WriteLine("- " + station.name);
            }
            Console.WriteLine("(Command executed in " + watch.ElapsedMilliseconds + "ms.)");
            break;
          case "/bikes":
            Console.Write("Enter the name of the station : ");
            String stationName = Console.ReadLine();
            watch = System.Diagnostics.Stopwatch.StartNew();
            Dictionary<String, int> bikes = client.NumberOfBikesAvailable(stationName);
            if ((bikes == null) || (bikes.Count() == 0))
            {
              Console.WriteLine("Wrong station name");
              break;
            }
            foreach (String key in bikes.Keys)
            {
              Console.WriteLine("- Station " + key + " : " + bikes[key] + " bikes available.");
            }
            watch.Stop();
            Console.WriteLine("(Command executed in " + watch.ElapsedMilliseconds + "ms.)");
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
      return "----------| Commands |----------\n"
            + "/test : Test the connection with the server.\n"
            + "/contracts : Print all the Velib contracts (cities).\n"
            + "/citiesincontract : Print all the cities in the velib contract given.\n"
            + "/stations : Print all the stations in the velib contract given.\n"
            + "/bikes : Number of bikes available in the given velib station.\n"
            + "/exit : Exit the application.\n"
            + "--------------------------------";
    }
  }
}
