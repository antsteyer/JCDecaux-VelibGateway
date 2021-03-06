﻿using System;
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
    private ServiceClient client; // client of the SOAP Service
    private Station[] stations; // Stocked to find the position of a station
    private System.Diagnostics.Stopwatch watch; // Used to calculate the execution time of each request
    private List<String> contractsName;
    private List<String> stationsName;

    public Form1()
    {
      InitializeComponent();
      JCDlabel.Text += " v.1.0.1";

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
      contractsName = new List<string>();
      watch = System.Diagnostics.Stopwatch.StartNew();
      Contract[] contracts = client.Contracts();
      watch.Stop();
      foreach (Contract contract in contracts)
      {
        ContractsList.Items.Add(contract.name);
        contractsName.Add(contract.name);
      }
      
      perfLabel.Text = "Time to load Contracts : "+watch.ElapsedMilliseconds+" ms.";
    }

    private void ContractsList_SelectedIndexChanged(object sender, EventArgs e)
    {
      StationsList.Items.Clear();
      stationsName = new List<String>();
      String contractName = (String) ContractsList.SelectedItem;
      watch = System.Diagnostics.Stopwatch.StartNew();
      stations = client.StationsOfTheCity(contractName);
      watch.Stop();
      foreach (Station station in stations)
      {
        StationsList.Items.Add(station.name);
        stationsName.Add(station.name);
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
      
      // Zoom reset
      gMap.Zoom = 17;
      // Update map with the position of the station
      gMap.Position = new PointLatLng(p.lat,p.lng);

      BikesNumberlabel.Text = bikes.ToString();
      
    }

    private void searchContract_Click(object sender, EventArgs e)
    {
      if((contractTextBox.Text.Length != 0) && (ContractsList.Items.Count != 0))
      {
        List<String> temp = new List<String>();
        foreach(String item in contractsName)
        {
          if(item.Contains(contractTextBox.Text))
          {
            temp.Add(item);
          }
        }
        ContractsList.Items.Clear();
        foreach(String item in temp)
        {
          ContractsList.Items.Add(item);
        }
      }
      else
      {
        ContractsList.Items.Clear();
        foreach (String item in contractsName)
        {
          ContractsList.Items.Add(item);
        }
      }
    }

    private void searchStation_Click(object sender, EventArgs e)
    {
      if ((stationTextBox.Text.Length != 0) && (StationsList.Items.Count != 0))
      {
        List<String> temp = new List<String>();
        foreach (String item in stationsName)
        {
          if (item.Contains(stationTextBox.Text.ToUpper()))
          {
            temp.Add(item);
          }
        }
        StationsList.Items.Clear();
        foreach (String item in temp)
        {
          StationsList.Items.Add(item);
        }
      }
      else
      {
        StationsList.Items.Clear();
        foreach (String item in stationsName)
        {
          StationsList.Items.Add(item);
        }
      }
    }
  }

}
