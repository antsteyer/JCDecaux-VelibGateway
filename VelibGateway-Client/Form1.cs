using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VelibGateway_Client.VelibServiceReference;

namespace VelibGateway_Client
{
  public partial class Form1 : Form
  {
    private ServiceClient client;

    public Form1()
    {
      InitializeComponent();
      client = new ServiceClient();
      Contract[] contracts = client.Contracts();
      
      foreach (Contract contract in contracts)
      {
        ContractsList.Items.Add(contract.name);
      }
    }

    private void ContractsList_SelectedIndexChanged(object sender, EventArgs e)
    {
      StationsList.Items.Clear();
      String contractName = (String) ContractsList.SelectedItem;
      Station[] stations = client.StationsOfTheCity(contractName);

      foreach (Station station in stations)
      {
        StationsList.Items.Add(station.name);
      }
    }

    private void StationsList_SelectedIndexChanged(object sender, EventArgs e)
    {
      String stationName = (String)StationsList.SelectedItem;
      int bikes = client.NumberOfBikesAvailable(stationName);

      BikesNumberlabel.Text = bikes.ToString();
    }
  }

}
