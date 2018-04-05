using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelibGateway_ClientConsole
{
  class ServiceCallBackSync : VelibServiceReference.IServiceCallback
  {

    public void Requested(string stationName, int result)
    {
      Console.WriteLine("Number of bikes Available in Station "+stationName+" : "+result.ToString());
    }

    public void RequestFinished()
    {
      Console.WriteLine("Request finished.");
    }
  }
}
