using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using VelibGateway_Client.VelibServiceReference;

namespace VelibGateway_Client
{
  public partial class Form1 : Form
  {
    private ServiceClient client;
    private Station[] stations;

    public Form1()
    {
      InitializeComponent();

      // Initialize Map
      gMap.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;
      gMap.MinZoom = 1;
      gMap.MaxZoom = 100;
      gMap.Zoom = 17;

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
      stations = client.StationsOfTheCity(contractName);

      foreach (Station station in stations)
      {
        StationsList.Items.Add(station.name);
      }
    }

    private void StationsList_SelectedIndexChanged(object sender, EventArgs e)
    {
      String stationName = (String)StationsList.SelectedItem;
      int bikes = client.NumberOfBikesAvailable(stationName);
      Position p = new Position();
      foreach (Station station in stations)
      {
        if(station.name.Equals(stationName))
        {
          p = station.position;
        }
      }
      
      gMap.Position = new PointLatLng(p.lat,p.lng);

      BikesNumberlabel.Text = bikes.ToString();
    }
  }

}
