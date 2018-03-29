namespace VelibGateway_Client
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.contractsLabel = new System.Windows.Forms.Label();
      this.contractsPanel = new System.Windows.Forms.Panel();
      this.searchContract = new System.Windows.Forms.Button();
      this.contractTextBox = new System.Windows.Forms.TextBox();
      this.LoadContractsbutton = new System.Windows.Forms.Button();
      this.ContractsList = new System.Windows.Forms.ListBox();
      this.bikesPanel = new System.Windows.Forms.Panel();
      this.BikesNumberlabel = new System.Windows.Forms.Label();
      this.mapLabel = new System.Windows.Forms.Label();
      this.gMap = new GMap.NET.WindowsForms.GMapControl();
      this.Bikeslabel = new System.Windows.Forms.Label();
      this.stationsPanel = new System.Windows.Forms.Panel();
      this.searchStation = new System.Windows.Forms.Button();
      this.stationTextBox = new System.Windows.Forms.TextBox();
      this.StationsList = new System.Windows.Forms.ListBox();
      this.stationsLabel = new System.Windows.Forms.Label();
      this.header = new System.Windows.Forms.Panel();
      this.JCDlabel = new System.Windows.Forms.Label();
      this.perfLabel = new System.Windows.Forms.Label();
      this.contractsPanel.SuspendLayout();
      this.bikesPanel.SuspendLayout();
      this.stationsPanel.SuspendLayout();
      this.header.SuspendLayout();
      this.SuspendLayout();
      // 
      // contractsLabel
      // 
      this.contractsLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.contractsLabel.Font = new System.Drawing.Font("Playbill", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.contractsLabel.Location = new System.Drawing.Point(5, 5);
      this.contractsLabel.Name = "contractsLabel";
      this.contractsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.contractsLabel.Size = new System.Drawing.Size(272, 51);
      this.contractsLabel.TabIndex = 3;
      this.contractsLabel.Text = "Contracts";
      this.contractsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // contractsPanel
      // 
      this.contractsPanel.Controls.Add(this.searchContract);
      this.contractsPanel.Controls.Add(this.contractTextBox);
      this.contractsPanel.Controls.Add(this.LoadContractsbutton);
      this.contractsPanel.Controls.Add(this.ContractsList);
      this.contractsPanel.Controls.Add(this.contractsLabel);
      this.contractsPanel.Location = new System.Drawing.Point(0, 36);
      this.contractsPanel.Name = "contractsPanel";
      this.contractsPanel.Padding = new System.Windows.Forms.Padding(5);
      this.contractsPanel.Size = new System.Drawing.Size(282, 414);
      this.contractsPanel.TabIndex = 4;
      // 
      // searchContract
      // 
      this.searchContract.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.searchContract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.searchContract.Cursor = System.Windows.Forms.Cursors.Hand;
      this.searchContract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.searchContract.Font = new System.Drawing.Font("Microsoft Office Preview Font", 9F);
      this.searchContract.Location = new System.Drawing.Point(230, 78);
      this.searchContract.Name = "searchContract";
      this.searchContract.Size = new System.Drawing.Size(47, 20);
      this.searchContract.TabIndex = 7;
      this.searchContract.Text = "V";
      this.searchContract.UseVisualStyleBackColor = false;
      this.searchContract.Click += new System.EventHandler(this.searchContract_Click);
      // 
      // contractTextBox
      // 
      this.contractTextBox.Location = new System.Drawing.Point(5, 78);
      this.contractTextBox.Name = "contractTextBox";
      this.contractTextBox.Size = new System.Drawing.Size(219, 20);
      this.contractTextBox.TabIndex = 6;
      this.contractTextBox.Text = "Enter contract name";
      // 
      // LoadContractsbutton
      // 
      this.LoadContractsbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.LoadContractsbutton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.LoadContractsbutton.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.LoadContractsbutton.Font = new System.Drawing.Font("Playbill", 30F);
      this.LoadContractsbutton.Location = new System.Drawing.Point(5, 364);
      this.LoadContractsbutton.Name = "LoadContractsbutton";
      this.LoadContractsbutton.Size = new System.Drawing.Size(272, 45);
      this.LoadContractsbutton.TabIndex = 5;
      this.LoadContractsbutton.Text = "Load";
      this.LoadContractsbutton.UseVisualStyleBackColor = false;
      this.LoadContractsbutton.Click += new System.EventHandler(this.LoadContractsbutton_Click);
      // 
      // ContractsList
      // 
      this.ContractsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ContractsList.BackColor = System.Drawing.Color.White;
      this.ContractsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ContractsList.FormattingEnabled = true;
      this.ContractsList.ItemHeight = 24;
      this.ContractsList.Location = new System.Drawing.Point(5, 104);
      this.ContractsList.Name = "ContractsList";
      this.ContractsList.Size = new System.Drawing.Size(272, 244);
      this.ContractsList.TabIndex = 4;
      this.ContractsList.SelectedIndexChanged += new System.EventHandler(this.ContractsList_SelectedIndexChanged);
      // 
      // bikesPanel
      // 
      this.bikesPanel.Controls.Add(this.BikesNumberlabel);
      this.bikesPanel.Controls.Add(this.mapLabel);
      this.bikesPanel.Controls.Add(this.gMap);
      this.bikesPanel.Controls.Add(this.Bikeslabel);
      this.bikesPanel.Location = new System.Drawing.Point(568, 36);
      this.bikesPanel.Name = "bikesPanel";
      this.bikesPanel.Padding = new System.Windows.Forms.Padding(5);
      this.bikesPanel.Size = new System.Drawing.Size(232, 414);
      this.bikesPanel.TabIndex = 5;
      // 
      // BikesNumberlabel
      // 
      this.BikesNumberlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.BikesNumberlabel.BackColor = System.Drawing.Color.Transparent;
      this.BikesNumberlabel.Font = new System.Drawing.Font("Playbill", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BikesNumberlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.BikesNumberlabel.Image = ((System.Drawing.Image)(resources.GetObject("BikesNumberlabel.Image")));
      this.BikesNumberlabel.Location = new System.Drawing.Point(5, 56);
      this.BikesNumberlabel.Name = "BikesNumberlabel";
      this.BikesNumberlabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.BikesNumberlabel.Size = new System.Drawing.Size(222, 126);
      this.BikesNumberlabel.TabIndex = 6;
      this.BikesNumberlabel.Text = "0";
      this.BikesNumberlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // mapLabel
      // 
      this.mapLabel.Font = new System.Drawing.Font("Playbill", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mapLabel.Location = new System.Drawing.Point(5, 182);
      this.mapLabel.Name = "mapLabel";
      this.mapLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.mapLabel.Size = new System.Drawing.Size(222, 51);
      this.mapLabel.TabIndex = 8;
      this.mapLabel.Text = "Map";
      this.mapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // gMap
      // 
      this.gMap.Bearing = 0F;
      this.gMap.CanDragMap = true;
      this.gMap.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
      this.gMap.GrayScaleMode = false;
      this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
      this.gMap.LevelsKeepInMemmory = 5;
      this.gMap.Location = new System.Drawing.Point(5, 230);
      this.gMap.MarkersEnabled = true;
      this.gMap.MaxZoom = 2;
      this.gMap.MinZoom = 2;
      this.gMap.MouseWheelZoomEnabled = true;
      this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
      this.gMap.Name = "gMap";
      this.gMap.NegativeMode = false;
      this.gMap.PolygonsEnabled = true;
      this.gMap.RetryLoadTile = 0;
      this.gMap.RoutesEnabled = true;
      this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
      this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
      this.gMap.ShowTileGridLines = false;
      this.gMap.Size = new System.Drawing.Size(222, 179);
      this.gMap.TabIndex = 7;
      this.gMap.Zoom = 0D;
      // 
      // Bikeslabel
      // 
      this.Bikeslabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.Bikeslabel.Font = new System.Drawing.Font("Playbill", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Bikeslabel.Location = new System.Drawing.Point(5, 5);
      this.Bikeslabel.Name = "Bikeslabel";
      this.Bikeslabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.Bikeslabel.Size = new System.Drawing.Size(222, 51);
      this.Bikeslabel.TabIndex = 5;
      this.Bikeslabel.Text = "Bikes";
      this.Bikeslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // stationsPanel
      // 
      this.stationsPanel.Controls.Add(this.searchStation);
      this.stationsPanel.Controls.Add(this.stationTextBox);
      this.stationsPanel.Controls.Add(this.StationsList);
      this.stationsPanel.Controls.Add(this.stationsLabel);
      this.stationsPanel.Location = new System.Drawing.Point(288, 36);
      this.stationsPanel.Name = "stationsPanel";
      this.stationsPanel.Padding = new System.Windows.Forms.Padding(5);
      this.stationsPanel.Size = new System.Drawing.Size(274, 414);
      this.stationsPanel.TabIndex = 6;
      // 
      // searchStation
      // 
      this.searchStation.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.searchStation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.searchStation.Cursor = System.Windows.Forms.Cursors.Hand;
      this.searchStation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.searchStation.Font = new System.Drawing.Font("Microsoft Office Preview Font", 9F);
      this.searchStation.Location = new System.Drawing.Point(222, 79);
      this.searchStation.Name = "searchStation";
      this.searchStation.Size = new System.Drawing.Size(47, 20);
      this.searchStation.TabIndex = 8;
      this.searchStation.Text = "V";
      this.searchStation.UseVisualStyleBackColor = false;
      this.searchStation.Click += new System.EventHandler(this.searchStation_Click);
      // 
      // stationTextBox
      // 
      this.stationTextBox.Location = new System.Drawing.Point(5, 79);
      this.stationTextBox.Name = "stationTextBox";
      this.stationTextBox.Size = new System.Drawing.Size(211, 20);
      this.stationTextBox.TabIndex = 8;
      this.stationTextBox.Text = "Enter station name";
      // 
      // StationsList
      // 
      this.StationsList.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.StationsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.StationsList.FormattingEnabled = true;
      this.StationsList.HorizontalScrollbar = true;
      this.StationsList.IntegralHeight = false;
      this.StationsList.ItemHeight = 24;
      this.StationsList.Location = new System.Drawing.Point(5, 104);
      this.StationsList.Name = "StationsList";
      this.StationsList.Size = new System.Drawing.Size(264, 305);
      this.StationsList.TabIndex = 5;
      this.StationsList.SelectedIndexChanged += new System.EventHandler(this.StationsList_SelectedIndexChanged);
      // 
      // stationsLabel
      // 
      this.stationsLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.stationsLabel.Font = new System.Drawing.Font("Playbill", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.stationsLabel.Location = new System.Drawing.Point(5, 5);
      this.stationsLabel.Name = "stationsLabel";
      this.stationsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.stationsLabel.Size = new System.Drawing.Size(264, 51);
      this.stationsLabel.TabIndex = 4;
      this.stationsLabel.Text = "Stations";
      this.stationsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // header
      // 
      this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.header.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.header.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("header.BackgroundImage")));
      this.header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.header.Controls.Add(this.JCDlabel);
      this.header.Controls.Add(this.perfLabel);
      this.header.Location = new System.Drawing.Point(0, 0);
      this.header.Name = "header";
      this.header.Padding = new System.Windows.Forms.Padding(5);
      this.header.Size = new System.Drawing.Size(800, 30);
      this.header.TabIndex = 7;
      // 
      // JCDlabel
      // 
      this.JCDlabel.AutoSize = true;
      this.JCDlabel.Dock = System.Windows.Forms.DockStyle.Left;
      this.JCDlabel.Font = new System.Drawing.Font("Playbill", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.JCDlabel.ForeColor = System.Drawing.SystemColors.Window;
      this.JCDlabel.Location = new System.Drawing.Point(5, 5);
      this.JCDlabel.Name = "JCDlabel";
      this.JCDlabel.Size = new System.Drawing.Size(88, 21);
      this.JCDlabel.TabIndex = 1;
      this.JCDlabel.Text = "JC-Decaux Velib";
      // 
      // perfLabel
      // 
      this.perfLabel.AutoSize = true;
      this.perfLabel.Dock = System.Windows.Forms.DockStyle.Right;
      this.perfLabel.Location = new System.Drawing.Point(795, 5);
      this.perfLabel.Name = "perfLabel";
      this.perfLabel.Size = new System.Drawing.Size(0, 13);
      this.perfLabel.TabIndex = 0;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.header);
      this.Controls.Add(this.stationsPanel);
      this.Controls.Add(this.bikesPanel);
      this.Controls.Add(this.contractsPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(816, 489);
      this.MinimumSize = new System.Drawing.Size(816, 489);
      this.Name = "Form1";
      this.Text = "Velib Gateway Client";
      this.contractsPanel.ResumeLayout(false);
      this.contractsPanel.PerformLayout();
      this.bikesPanel.ResumeLayout(false);
      this.stationsPanel.ResumeLayout(false);
      this.stationsPanel.PerformLayout();
      this.header.ResumeLayout(false);
      this.header.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Label contractsLabel;
    private System.Windows.Forms.Panel contractsPanel;
    private System.Windows.Forms.Panel bikesPanel;
    private System.Windows.Forms.Panel stationsPanel;
    private System.Windows.Forms.Panel header;
    private System.Windows.Forms.Label stationsLabel;
    private System.Windows.Forms.Label Bikeslabel;
    private System.Windows.Forms.Label BikesNumberlabel;
    private System.Windows.Forms.ListBox ContractsList;
    private System.Windows.Forms.ListBox StationsList;
    private GMap.NET.WindowsForms.GMapControl gMap;
    private System.Windows.Forms.Button LoadContractsbutton;
    private System.Windows.Forms.Label perfLabel;
    private System.Windows.Forms.Label JCDlabel;
    private System.Windows.Forms.Label mapLabel;
    private System.Windows.Forms.Button searchContract;
    private System.Windows.Forms.TextBox contractTextBox;
    private System.Windows.Forms.Button searchStation;
    private System.Windows.Forms.TextBox stationTextBox;
  }
}

