﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace VelibGateway_EventsHostWS
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        ServiceHost host = new ServiceHost(typeof(VelibGateway_Service.Service));
        host.Open();
        Console.WriteLine("Service is Hosted as http://localhost:9011/Service");
        Console.WriteLine("\nPress  key to stop the service.");
        Console.ReadLine();
        host.Close();
      }
      catch (Exception eX)
      {
        Console.WriteLine("There was en error while Hosting Service [" + eX.Message + "]");
        Console.WriteLine("\nPress  key to close.");
        Console.ReadLine();
      }
    }
  }
}