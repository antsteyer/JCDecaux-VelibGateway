using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelibGateway_Service.model
{
  class Station
  {
    public int number { get; set; }
    public String name { get; set; }
    public String address { get; set; }
    public Position position { get; set; }
    public Boolean banking { get; set; }
    public Boolean bonus { get; set; }
    public String status { get; set; }
    public String contract_name { get; set; }
    public int bike_stands { get; set; }
    public int available_bike_stands { get; set; }
    public int available_bikes { get; set; }
    public long last_update { get; set; }
  }
}
