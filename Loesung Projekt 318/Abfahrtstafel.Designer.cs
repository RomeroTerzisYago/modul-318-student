namespace Loesung_Projekt_318
{
	partial class Abfahrtstafel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abfahrtstafel));
			this.lblStation = new System.Windows.Forms.Label();
			this.lblFromStation = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.livStationboard = new System.Windows.Forms.ListView();
			this.colLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colDeparture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// lblStation
			// 
			this.lblStation.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.lblStation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.lblStation, "lblStation");
			this.lblStation.Name = "lblStation";
			// 
			// lblFromStation
			// 
			this.lblFromStation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.lblFromStation, "lblFromStation");
			this.lblFromStation.Name = "lblFromStation";
			// 
			// btnClose
			// 
			resources.ApplyResources(this.btnClose, "btnClose");
			this.btnClose.Name = "btnClose";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.OnClickClose);
			// 
			// livStationboard
			// 
			this.livStationboard.AutoArrange = false;
			this.livStationboard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.colLine,
			this.colDeparture,
			this.colTo});
			resources.ApplyResources(this.livStationboard, "livStationboard");
			this.livStationboard.Name = "livStationboard";
			this.livStationboard.UseCompatibleStateImageBehavior = false;
			this.livStationboard.View = System.Windows.Forms.View.Details;
			// 
			// colLine
			// 
			resources.ApplyResources(this.colLine, "colLine");
			// 
			// colDeparture
			// 
			resources.ApplyResources(this.colDeparture, "colDeparture");
			// 
			// colTo
			// 
			resources.ApplyResources(this.colTo, "colTo");
			// 
			// Abfahrtstafel
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.IndianRed;
			this.Controls.Add(this.lblStation);
			this.Controls.Add(this.lblFromStation);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.livStationboard);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Abfahrtstafel";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblStation;
		private System.Windows.Forms.Label lblFromStation;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.ListView livStationboard;
		private System.Windows.Forms.ColumnHeader colLine;
		private System.Windows.Forms.ColumnHeader colDeparture;
		private System.Windows.Forms.ColumnHeader colTo;
	}
}