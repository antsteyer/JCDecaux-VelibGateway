using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VelibGateway_Service
{
  class VelibWeb
  {
    private String APIkey;
    private static String baseVelibURL = "https://api.jcdecaux.com/vls/v1/";

    public VelibWeb(String APIkey)
    {
      this.APIkey = APIkey;
    }

    public String ConnectToAPI(String requestParams)
    {
      try
      {
        WebRequest request = WebRequest.Create(baseVelibURL + requestParams + "&apiKey=" + APIkey);
        return getResponseToString(request.GetResponse());
      } catch (System.Net.WebException e)
      {
        return "KO";
      }
      
      
    }

    private String getResponseToString(WebResponse response)
    {
      Stream dataStream = response.GetResponseStream();
      StreamReader reader = new StreamReader(dataStream);
      String responseFromServer = reader.ReadToEnd();
      reader.Close();
      response.Close();
      return responseFromServer;
    }

  }
}
