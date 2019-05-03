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
			this.panelMap = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.webMap = new System.Windows.Forms.WebBrowser();
			this.panelMap.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMap
			// 
			this.panelMap.Controls.Add(this.webMap);
			this.panelMap.Location = new System.Drawing.Point(12, 7);
			this.panelMap.Name = "panelMap";
			this.panelMap.Size = new System.Drawing.Size(1234, 695);
			this.panelMap.TabIndex = 1;
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Location = new System.Drawing.Point(1043, 753);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(160, 51);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Schliesen";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.OnClickClose);
			// 
			// webMap
			// 
			this.webMap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webMap.Location = new System.Drawing.Point(0, 0);
			this.webMap.MinimumSize = new System.Drawing.Size(20, 20);
			this.webMap.Name = "webMap";
			this.webMap.Size = new System.Drawing.Size(1234, 695);
			this.webMap.TabIndex = 0;
			this.webMap.Url = new System.Uri("", System.UriKind.Relative);
			// 
			// Maps
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.IndianRed;
			this.ClientSize = new System.Drawing.Size(1258, 817);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.panelMap);
			this.Name = "Maps";
			this.Text = "Maps";
			this.Load += new System.EventHandler(this.OnMapsLoad);
			this.panelMap.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelMap;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.WebBrowser webMap;
	}
}