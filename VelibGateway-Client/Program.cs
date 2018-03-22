using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VelibGateway_Client.VelibServiceReference;

namespace VelibGateway_Client
{
  class Program
  {
    static void Main(string[] args)
    {
      ServiceClient client = new ServiceClient();
      
      Console.WriteLine(client.showCoucou());
      Console.ReadLine();
    }
  }
}
