using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelibGateway_Service
{
  public class Service : IService
  {
    public string help()
    {
      return "------ Commands ------\n"
            + "\ttest : Test the connection with the server";
    }

    public string testConnexion(string clientID)
    {
      return "From Server | Connexion established with : " + clientID;
    }



  }
}
