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
      this.contractsLabel = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.LoadContractsbutton = new System.Windows.Forms.Button();
      this.ContractsList = new System.Windows.Forms.ListBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.gMap = new GMap.NET.WindowsForms.GMapControl();
      this.BikesNumberlabel = new System.Windows.Forms.Label();
      this.Bikeslabel = new System.Windows.Forms.Label();
      this.panel3 = new System.Windows.Forms.Panel();
      this.StationsList = new System.Windows.Forms.ListBox();
      this.stationsLabel = new System.Windows.Forms.Label();
      this.panel4 = new System.Windows.Forms.Panel();
      this.perfLabel = new System.Windows.Forms.Label();
      this.JCDlabel = new System.Windows.Forms.Label();
      this.mapLabel = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel4.SuspendLayout();
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
      // panel1
      // 
      this.panel1.Controls.Add(this.LoadContractsbutton);
      this.panel1.Controls.Add(this.ContractsList);
      this.panel1.Controls.Add(this.contractsLabel);
      this.panel1.Location = new System.Drawing.Point(0, 36);
      this.panel1.Name = "panel1";
      this.panel1.Padding = new System.Windows.Forms.Padding(5);
      this.panel1.Size = new System.Drawing.Size(282, 414);
      this.panel1.TabIndex = 4;
      // 
      // LoadContractsbutton
      // 
      this.LoadContractsbutton.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.LoadContractsbutton.Font = new System.Drawing.Font("Playbill", 30F);
      this.LoadContractsbutton.Location = new System.Drawing.Point(5, 364);
      this.LoadContractsbutton.Name = "LoadContractsbutton";
      this.LoadContractsbutton.Size = new System.Drawing.Size(272, 45);
      this.LoadContractsbutton.TabIndex = 5;
      this.LoadContractsbutton.Text = "Load";
      this.LoadContractsbutton.UseVisualStyleBackColor = true;
      this.LoadContractsbutton.Click += new System.EventHandler(this.LoadContractsbutton_Click);
      // 
      // ContractsList
      // 
      this.ContractsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ContractsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ContractsList.FormattingEnabled = true;
      this.ContractsList.ItemHeight = 24;
      this.ContractsList.Location = new System.Drawing.Point(5, 56);
      this.ContractsList.Name = "ContractsList";
      this.ContractsList.Size = new System.Drawing.Size(272, 292);
      this.ContractsList.TabIndex = 4;
      this.ContractsList.SelectedIndexChanged += new System.EventHandler(this.ContractsList_SelectedIndexChanged);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.mapLabel);
      this.panel2.Controls.Add(this.gMap);
      this.panel2.Controls.Add(this.BikesNumberlabel);
      this.panel2.Controls.Add(this.Bikeslabel);
      this.panel2.Location = new System.Drawing.Point(568, 36);
      this.panel2.Name = "panel2";
      this.panel2.Padding = new System.Windows.Forms.Padding(5);
      this.panel2.Size = new System.Drawing.Size(232, 414);
      this.panel2.TabIndex = 5;
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
      // BikesNumberlabel
      // 
      this.BikesNumberlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.BikesNumberlabel.Font = new System.Drawing.Font("Playbill", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BikesNumberlabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
      this.BikesNumberlabel.Location = new System.Drawing.Point(5, 56);
      this.BikesNumberlabel.Name = "BikesNumberlabel";
      this.BikesNumberlabel.Size = new System.Drawing.Size(222, 126);
      this.BikesNumberlabel.TabIndex = 6;
      this.BikesNumberlabel.Text = "0";
      this.BikesNumberlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
      // panel3
      // 
      this.panel3.Controls.Add(this.StationsList);
      this.panel3.Controls.Add(this.stationsLabel);
      this.panel3.Location = new System.Drawing.Point(288, 36);
      this.panel3.Name = "panel3";
      this.panel3.Padding = new System.Windows.Forms.Padding(5);
      this.panel3.Size = new System.Drawing.Size(274, 414);
      this.panel3.TabIndex = 6;
      // 
      // StationsList
      // 
      this.StationsList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.StationsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.StationsList.FormattingEnabled = true;
      this.StationsList.HorizontalScrollbar = true;
      this.StationsList.IntegralHeight = false;
      this.StationsList.ItemHeight = 24;
      this.StationsList.Location = new System.Drawing.Point(5, 56);
      this.StationsList.Name = "StationsList";
      this.StationsList.Size = new System.Drawing.Size(264, 353);
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
      // panel4
      // 
      this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.panel4.Controls.Add(this.JCDlabel);
      this.panel4.Controls.Add(this.perfLabel);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel4.Location = new System.Drawing.Point(0, 0);
      this.panel4.Name = "panel4";
      this.panel4.Padding = new System.Windows.Forms.Padding(5);
      this.panel4.Size = new System.Drawing.Size(800, 30);
      this.panel4.TabIndex = 7;
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
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.panel4);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(816, 489);
      this.MinimumSize = new System.Drawing.Size(816, 489);
      this.Name = "Form1";
      this.Text = "Velib Gateway Client";
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.ResumeLayout(false);

        }

    #endregion
    private System.Windows.Forms.Label contractsLabel;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel panel4;
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
  }
}

