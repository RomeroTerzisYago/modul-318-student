namespace Loesung_Projekt_318
{
	partial class Maps
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
			this.panelSearch = new System.Windows.Forms.Panel();
			this.panelMap = new System.Windows.Forms.Panel();
			this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.panelSearch.SuspendLayout();
			this.panelMap.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelSearch
			// 
			this.panelSearch.Controls.Add(this.button1);
			this.panelSearch.Controls.Add(this.textBox2);
			this.panelSearch.Controls.Add(this.textBox1);
			this.panelSearch.Location = new System.Drawing.Point(12, 2);
			this.panelSearch.Name = "panelSearch";
			this.panelSearch.Size = new System.Drawing.Size(269, 508);
			this.panelSearch.TabIndex = 0;
			// 
			// panelMap
			// 
			this.panelMap.Controls.Add(this.gMapControl1);
			this.panelMap.Location = new System.Drawing.Point(303, 7);
			this.panelMap.Name = "panelMap";
			this.panelMap.Size = new System.Drawing.Size(548, 508);
			this.panelMap.TabIndex = 1;
			// 
			// gMapControl1
			// 
			this.gMapControl1.Bearing = 0F;
			this.gMapControl1.CanDragMap = true;
			this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
			this.gMapControl1.GrayScaleMode = false;
			this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
			this.gMapControl1.LevelsKeepInMemmory = 5;
			this.gMapControl1.Location = new System.Drawing.Point(0, 0);
			this.gMapControl1.MarkersEnabled = true;
			this.gMapControl1.MaxZoom = 2;
			this.gMapControl1.MinZoom = 2;
			this.gMapControl1.MouseWheelZoomEnabled = true;
			this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
			this.gMapControl1.Name = "gMapControl1";
			this.gMapControl1.NegativeMode = false;
			this.gMapControl1.PolygonsEnabled = true;
			this.gMapControl1.RetryLoadTile = 0;
			this.gMapControl1.RoutesEnabled = true;
			this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
			this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
			this.gMapControl1.ShowTileGridLines = false;
			this.gMapControl1.Size = new System.Drawing.Size(545, 508);
			this.gMapControl1.TabIndex = 0;
			this.gMapControl1.Zoom = 0D;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(42, 71);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(171, 22);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(42, 154);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(171, 22);
			this.textBox2.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(88, 236);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Maps
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(875, 522);
			this.Controls.Add(this.panelMap);
			this.Controls.Add(this.panelSearch);
			this.Name = "Maps";
			this.Text = "Maps";
			this.panelSearch.ResumeLayout(false);
			this.panelSearch.PerformLayout();
			this.panelMap.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelSearch;
		private System.Windows.Forms.Panel panelMap;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private GMap.NET.WindowsForms.GMapControl gMapControl1;
	}
}