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
      this.panel2 = new System.Windows.Forms.Panel();
      this.BikesNumberlabel = new System.Windows.Forms.Label();
      this.Bikeslabel = new System.Windows.Forms.Label();
      this.panel3 = new System.Windows.Forms.Panel();
      this.stationsLabel = new System.Windows.Forms.Label();
      this.panel4 = new System.Windows.Forms.Panel();
      this.ContractsList = new System.Windows.Forms.ListBox();
      this.StationsList = new System.Windows.Forms.ListBox();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
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
      this.panel1.Controls.Add(this.ContractsList);
      this.panel1.Controls.Add(this.contractsLabel);
      this.panel1.Location = new System.Drawing.Point(0, 46);
      this.panel1.Name = "panel1";
      this.panel1.Padding = new System.Windows.Forms.Padding(5);
      this.panel1.Size = new System.Drawing.Size(282, 404);
      this.panel1.TabIndex = 4;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.BikesNumberlabel);
      this.panel2.Controls.Add(this.Bikeslabel);
      this.panel2.Location = new System.Drawing.Point(562, 46);
      this.panel2.Name = "panel2";
      this.panel2.Padding = new System.Windows.Forms.Padding(5);
      this.panel2.Size = new System.Drawing.Size(238, 404);
      this.panel2.TabIndex = 5;
      // 
      // BikesNumberlabel
      // 
      this.BikesNumberlabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.BikesNumberlabel.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BikesNumberlabel.Location = new System.Drawing.Point(5, 56);
      this.BikesNumberlabel.Name = "BikesNumberlabel";
      this.BikesNumberlabel.Size = new System.Drawing.Size(228, 343);
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
      this.Bikeslabel.Size = new System.Drawing.Size(228, 51);
      this.Bikeslabel.TabIndex = 5;
      this.Bikeslabel.Text = "Bikes";
      this.Bikeslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.StationsList);
      this.panel3.Controls.Add(this.stationsLabel);
      this.panel3.Location = new System.Drawing.Point(283, 46);
      this.panel3.Name = "panel3";
      this.panel3.Padding = new System.Windows.Forms.Padding(5);
      this.panel3.Size = new System.Drawing.Size(279, 404);
      this.panel3.TabIndex = 6;
      // 
      // stationsLabel
      // 
      this.stationsLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.stationsLabel.Font = new System.Drawing.Font("Playbill", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.stationsLabel.Location = new System.Drawing.Point(5, 5);
      this.stationsLabel.Name = "stationsLabel";
      this.stationsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.stationsLabel.Size = new System.Drawing.Size(269, 51);
      this.stationsLabel.TabIndex = 4;
      this.stationsLabel.Text = "Stations";
      this.stationsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // panel4
      // 
      this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel4.Location = new System.Drawing.Point(0, 0);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(800, 46);
      this.panel4.TabIndex = 7;
      // 
      // ContractsList
      // 
      this.ContractsList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ContractsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ContractsList.FormattingEnabled = true;
      this.ContractsList.ItemHeight = 24;
      this.ContractsList.Location = new System.Drawing.Point(5, 56);
      this.ContractsList.Name = "ContractsList";
      this.ContractsList.Size = new System.Drawing.Size(272, 343);
      this.ContractsList.TabIndex = 4;
      this.ContractsList.SelectedIndexChanged += new System.EventHandler(this.ContractsList_SelectedIndexChanged);
      // 
      // StationsList
      // 
      this.StationsList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.StationsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.StationsList.FormattingEnabled = true;
      this.StationsList.HorizontalScrollbar = true;
      this.StationsList.ItemHeight = 24;
      this.StationsList.Location = new System.Drawing.Point(5, 56);
      this.StationsList.Name = "StationsList";
      this.StationsList.Size = new System.Drawing.Size(269, 343);
      this.StationsList.TabIndex = 5;
      this.StationsList.SelectedIndexChanged += new System.EventHandler(this.StationsList_SelectedIndexChanged);
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
      this.Name = "Form1";
      this.Text = "Velib Gateway Client";
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
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
  }
}

