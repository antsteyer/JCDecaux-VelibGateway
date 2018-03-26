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
          case "/clear":
            
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
            + "/exit : Exit the application.\n"
            + "--------------------------------";
    }
  }
}
