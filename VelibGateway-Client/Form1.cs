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
    private System.Diagnostics.Stopwatch watch;

    public Form1()
    {
      InitializeComponent();

      // Initialize Map
      gMap.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;
      gMap.MinZoom = 1;
      gMap.MaxZoom = 100;
      gMap.Zoom = 17;

      // Initialize Service
      client = new ServiceClient();
      
    }

    private void LoadContractsbutton_Click(object sender, EventArgs e)
    {
      ContractsList.Items.Clear();
      watch = System.Diagnostics.Stopwatch.StartNew();
      Contract[] contracts = client.Contracts();
      watch.Stop();
      foreach (Contract contract in contracts)
      {
        ContractsList.Items.Add(contract.name);
      }
      perfLabel.Text = "Time to load Contracts : "+watch.ElapsedMilliseconds+" ms.";
    }

    private void ContractsList_SelectedIndexChanged(object sender, EventArgs e)
    {
      StationsList.Items.Clear();
      String contractName = (String) ContractsList.SelectedItem;
      watch = System.Diagnostics.Stopwatch.StartNew();
      stations = client.StationsOfTheCity(contractName);
      watch.Stop();
      foreach (Station station in stations)
      {
        StationsList.Items.Add(station.name);
      }
      perfLabel.Text = "Time to load Stations : " + watch.ElapsedMilliseconds + " ms.";
    }

    private void StationsList_SelectedIndexChanged(object sender, EventArgs e)
    {
      String stationName = (String)StationsList.SelectedItem;
      watch = System.Diagnostics.Stopwatch.StartNew();
      int bikes = client.NumberOfBikesAvailable(stationName);
      watch.Stop();
      Position p = new Position();
      foreach (Station station in stations)
      {
        if(station.name.Equals(stationName))
        {
          p = station.position;
        }
      }
      perfLabel.Text = "Time to load Bikes : " + watch.ElapsedMilliseconds + " ms.";
      gMap.Position = new PointLatLng(p.lat,p.lng);

      BikesNumberlabel.Text = bikes.ToString();
    }


  }

}
