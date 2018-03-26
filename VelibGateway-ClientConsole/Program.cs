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
        var watch;
        Console.WriteLine();
        switch (command) {
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
            Console.WriteLine(client.Contracts());
            watch.Stop();
            Console.WriteLine("(Command executed in " + watch.ElapsedMilliseconds + "ms.)");
            break;
          case "/citiesincontract":
            Console.Write("Enter the name of the contract : ");
            contractName = Console.ReadLine();
            watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(client.CitiesInContract(contractName));
            watch.Stop();
            Console.WriteLine("(Command executed in " + watch.ElapsedMilliseconds + "ms.)");
            break;
          case "/stations":
            Console.Write("Enter the name of the city : ");
            contractName = Console.ReadLine();
            watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(client.StationsOfTheCity(contractName));
            watch.Stop();
            Console.WriteLine("(Command executed in " + watch.ElapsedMilliseconds + "ms.)");
            break;
          case "/bikes":
            Console.Write("Enter the name of the station : ");
            String stationName = Console.ReadLine();
            watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(client.NumberOfBikesAvailable(stationName));
            watch.Stop();
            Console.WriteLine("(Command executed in " + watch.ElapsedMilliseconds + "ms.)");
            break;
          case "/clear":
            watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(client.ClearCaches());
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
