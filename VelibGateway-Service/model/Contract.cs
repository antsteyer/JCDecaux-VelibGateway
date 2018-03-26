using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelibGateway_Service.model
{
  class Contract
  {
    public String name { get; set; }
    public List<String> cities { get; set; }
    public String commercial_name { get; set; }
    public String country_code { get; set; }
  }
}
