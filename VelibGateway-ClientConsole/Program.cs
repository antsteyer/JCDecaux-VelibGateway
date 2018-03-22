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
      Console.WriteLine("--VelibGateway Client SOAP--");
      Console.WriteLine("Use exit at anytime to end.");
      Console.WriteLine("Use help at anytime to show all commands available.");
      while (!exit)
      {
        Console.Write(">_ ");
        String command = Console.ReadLine();
        switch (command) {
          case "exit":
            exit = true;
            break;
          case "test":
            Console.WriteLine(client.testConnexion("Client Console"));
            break;
          case "help":
            Console.WriteLine(client.help());
            break;
          default:
            break;
        }
        Console.WriteLine();
      }
    }
  }
}
