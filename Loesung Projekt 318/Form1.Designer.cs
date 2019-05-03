namespace Loesung_Projekt_318
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.lblVonStation = new System.Windows.Forms.Label();
			this.txtFromStation = new System.Windows.Forms.TextBox();
			this.cmbFromStation = new System.Windows.Forms.ComboBox();
			this.txtToStation = new System.Windows.Forms.TextBox();
			this.cmbToStation = new System.Windows.Forms.ComboBox();
			this.lblNachStation = new System.Windows.Forms.Label();
			this.lblDatum = new System.Windows.Forms.Label();
			this.tpFromDate = new System.Windows.Forms.DateTimePicker();
			this.lblZeit = new System.Windows.Forms.Label();
			this.tpFromTime = new System.Windows.Forms.DateTimePicker();
			this.btnSearchForConnections = new System.Windows.Forms.Button();
			this.lblConnections = new System.Windows.Forms.Label();
			this.lvConnections = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lblDelete = new System.Windows.Forms.Label();
			this.btnDepartureBoard = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblSendEmail = new System.Windows.Forms.Label();
			this.btnReverseStations = new System.Windows.Forms.Button();
			this.btnMail = new System.Windows.Forms.Button();
			this.btnMap = new System.Windows.Forms.Button();
			this.btnDeleteStation = new System.Windows.Forms.Button();
			this.transportBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lblChange = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// lblVonStation
			// 
			this.lblVonStation.AutoSize = true;
			this.lblVonStation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVonStation.Location = new System.Drawing.Point(54, 35);
			this.lblVonStation.Name = "lblVonStation";
			this.lblVonStation.Size = new System.Drawing.Size(53, 24);
			this.lblVonStation.TabIndex = 21;
			this.lblVonStation.Text = "Von:";
			// 
			// txtFromStation
			// 
			this.txtFromStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			this.txtFromStation.Location = new System.Drawing.Point(126, 32);
			this.txtFromStation.Margin = new System.Windows.Forms.Padding(4);
			this.txtFromStation.Name = "txtFromStation";
			this.txtFromStation.Size = new System.Drawing.Size(425, 27);
			this.txtFromStation.TabIndex = 22;
			this.txtFromStation.TextChanged += new System.EventHandler(this.OnFromTextChanged);
			// 
			// cmbFromStation
			// 
			this.cmbFromStation.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmbFromStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbFromStation.FormattingEnabled = true;
			this.cmbFromStation.Location = new System.Drawing.Point(126, 81);
			this.cmbFromStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbFromStation.Name = "cmbFromStation";
			this.cmbFromStation.Size = new System.Drawing.Size(425, 28);
			this.cmbFromStation.TabIndex = 23;
			// 
			// txtToStation
			// 
			this.txtToStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			this.txtToStation.Location = new System.Drawing.Point(126, 138);
			this.txtToStation.Margin = new System.Windows.Forms.Padding(4);
			this.txtToStation.Name = "txtToStation";
			this.txtToStation.Size = new System.Drawing.Size(425, 27);
			this.txtToStation.TabIndex = 24;
			this.txtToStation.TextChanged += new System.EventHandler(this.OnTextToChanged);
			// 
			// cmbToStation
			// 
			this.cmbToStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbToStation.FormattingEnabled = true;
			this.cmbToStation.Location = new System.Drawing.Point(126, 182);
			this.cmbToStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbToStation.Name = "cmbToStation";
			this.cmbToStation.Size = new System.Drawing.Size(425, 28);
			this.cmbToStation.TabIndex = 26;
			// 
			// lblNachStation
			// 
			this.lblNachStation.AutoSize = true;
			this.lblNachStation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNachStation.Location = new System.Drawing.Point(48, 138);
			this.lblNachStation.Name = "lblNachStation";
			this.lblNachStation.Size = new System.Drawing.Size(71, 24);
			this.lblNachStation.TabIndex = 25;
			this.lblNachStation.Text = "Nach: ";
			// 
			// lblDatum
			// 
			this.lblDatum.AutoSize = true;
			this.lblDatum.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDatum.Location = new System.Drawing.Point(48, 263);
			this.lblDatum.Name = "lblDatum";
			this.lblDatum.Size = new System.Drawing.Size(66, 19);
			this.lblDatum.TabIndex = 32;
			this.lblDatum.Text = "Datum:";
			// 
			// tpFromDate
			// 
			this.tpFromDate.Checked = false;
			this.tpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.tpFromDate.Location = new System.Drawing.Point(133, 260);
			this.tpFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tpFromDate.Name = "tpFromDate";
			this.tpFromDate.Size = new System.Drawing.Size(212, 27);
			this.tpFromDate.TabIndex = 33;
			// 
			// lblZeit
			// 
			this.lblZeit.AutoSize = true;
			this.lblZeit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblZeit.Location = new System.Drawing.Point(369, 262);
			this.lblZeit.Name = "lblZeit";
			this.lblZeit.Size = new System.Drawing.Size(51, 24);
			this.lblZeit.TabIndex = 40;
			this.lblZeit.Text = "Zeit:";
			// 
			// tpFromTime
			// 
			this.tpFromTime.Checked = false;
			this.tpFromTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tpFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.tpFromTime.Location = new System.Drawing.Point(426, 262);
			this.tpFromTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tpFromTime.Name = "tpFromTime";
			this.tpFromTime.ShowUpDown = true;
			this.tpFromTime.Size = new System.Drawing.Size(137, 27);
			this.tpFromTime.TabIndex = 39;
			// 
			// btnSearchForConnections
			// 
			this.btnSearchForConnections.BackColor = System.Drawing.Color.White;
			this.btnSearchForConnections.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearchForConnections.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnSearchForConnections.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearchForConnections.Location = new System.Drawing.Point(126, 350);
			this.btnSearchForConnections.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSearchForConnections.Name = "btnSearchForConnections";
			this.btnSearchForConnections.Size = new System.Drawing.Size(219, 47);
			this.btnSearchForConnections.TabIndex = 44;
			this.btnSearchForConnections.Text = "Verbindung Suchen";
			this.btnSearchForConnections.UseVisualStyleBackColor = false;
			this.btnSearchForConnections.Click += new System.EventHandler(this.OnClickSearchConnection);
			// 
			// lblConnections
			// 
			this.lblConnections.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.lblConnections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblConnections.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConnections.Location = new System.Drawing.Point(58, 442);
			this.lblConnections.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblConnections.Name = "lblConnections";
			this.lblConnections.Size = new System.Drawing.Size(1045, 37);
			this.lblConnections.TabIndex = 45;
			this.lblConnections.Text = "Verbindungen:";
			this.lblConnections.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lvConnections
			// 
			this.lvConnections.BackColor = System.Drawing.Color.WhiteSmoke;
			this.lvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
			this.lvConnections.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lvConnections.Location = new System.Drawing.Point(58, 483);
			this.lvConnections.Margin = new System.Windows.Forms.Padding(4);
			this.lvConnections.Name = "lvConnections";
			this.lvConnections.Size = new System.Drawing.Size(1045, 151);
			this.lvConnections.TabIndex = 46;
			this.lvConnections.TileSize = new System.Drawing.Size(168, 30);
			this.lvConnections.UseCompatibleStateImageBehavior = false;
			this.lvConnections.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Von";
			this.columnHeader1.Width = 200;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Nach";
			this.columnHeader3.Width = 200;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Abfahrt";
			this.columnHeader2.Width = 171;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Ankunft";
			this.columnHeader4.Width = 129;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Dauer";
			this.columnHeader5.Width = 129;
			// 
			// lblDelete
			// 
			this.lblDelete.AutoSize = true;
			this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDelete.Location = new System.Drawing.Point(861, 36);
			this.lblDelete.Name = "lblDelete";
			this.lblDelete.Size = new System.Drawing.Size(140, 24);
			this.lblDelete.TabIndex = 47;
			this.lblDelete.Text = "Inhalt löschen";
			// 
			// btnDepartureBoard
			// 
			this.btnDepartureBoard.BackColor = System.Drawing.Color.White;
			this.btnDepartureBoard.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDepartureBoard.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnDepartureBoard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDepartureBoard.Location = new System.Drawing.Point(414, 350);
			this.btnDepartureBoard.Margin = new System.Windows.Forms.Padding(4);
			this.btnDepartureBoard.Name = "btnDepartureBoard";
			this.btnDepartureBoard.Size = new System.Drawing.Size(163, 47);
			this.btnDepartureBoard.TabIndex = 49;
			this.btnDepartureBoard.Text = "Abfahrtstafel";
			this.btnDepartureBoard.UseVisualStyleBackColor = false;
			this.btnDepartureBoard.Click += new System.EventHandler(this.OnClickAbfahrtTafel);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(645, 223);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 24);
			this.label1.TabIndex = 51;
			this.label1.Text = "Ort anzeigen";
			// 
			// lblSendEmail
			// 
			this.lblSendEmail.AutoSize = true;
			this.lblSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSendEmail.Location = new System.Drawing.Point(849, 223);
			this.lblSendEmail.Name = "lblSendEmail";
			this.lblSendEmail.Size = new System.Drawing.Size(138, 24);
			this.lblSendEmail.TabIndex = 52;
			this.lblSendEmail.Text = "Email senden";
			// 
			// btnReverseStations
			// 
			this.btnReverseStations.BackColor = System.Drawing.Color.White;
			this.btnReverseStations.BackgroundImage = global::Loesung_Projekt_318.Properties.Resources.reverse;
			this.btnReverseStations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnReverseStations.Location = new System.Drawing.Point(635, 81);
			this.btnReverseStations.Name = "btnReverseStations";
			this.btnReverseStations.Size = new System.Drawing.Size(128, 74);
			this.btnReverseStations.TabIndex = 53;
			this.btnReverseStations.UseVisualStyleBackColor = false;
			this.btnReverseStations.Click += new System.EventHandler(this.OnReverseClick);
			// 
			// btnMail
			// 
			this.btnMail.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnMail.BackgroundImage = global::Loesung_Projekt_318.Properties.Resources.icons8_secured_letter_100;
			this.btnMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnMail.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMail.Location = new System.Drawing.Point(853, 272);
			this.btnMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnMail.Name = "btnMail";
			this.btnMail.Size = new System.Drawing.Size(124, 82);
			this.btnMail.TabIndex = 50;
			this.btnMail.UseVisualStyleBackColor = false;
			this.btnMail.Click += new System.EventHandler(this.OnClickSendEmail);
			// 
			// btnMap
			// 
			this.btnMap.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMap.BackgroundImage")));
			this.btnMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnMap.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMap.Location = new System.Drawing.Point(651, 272);
			this.btnMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnMap.Name = "btnMap";
			this.btnMap.Size = new System.Drawing.Size(124, 82);
			this.btnMap.TabIndex = 48;
			this.btnMap.UseVisualStyleBackColor = false;
			this.btnMap.Click += new System.EventHandler(this.OnClickOpenMap);
			// 
			// btnDeleteStation
			// 
			this.btnDeleteStation.BackColor = System.Drawing.Color.White;
			this.btnDeleteStation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteStation.BackgroundImage")));
			this.btnDeleteStation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnDeleteStation.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeleteStation.Location = new System.Drawing.Point(865, 81);
			this.btnDeleteStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDeleteStation.Name = "btnDeleteStation";
			this.btnDeleteStation.Size = new System.Drawing.Size(124, 74);
			this.btnDeleteStation.TabIndex = 43;
			this.btnDeleteStation.UseVisualStyleBackColor = false;
			this.btnDeleteStation.Click += new System.EventHandler(this.OnClickDelete);
			// 
			// lblChange
			// 
			this.lblChange.AutoSize = true;
			this.lblChange.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblChange.Location = new System.Drawing.Point(602, 36);
			this.lblChange.Name = "lblChange";
			this.lblChange.Size = new System.Drawing.Size(210, 24);
			this.lblChange.TabIndex = 54;
			this.lblChange.Text = "Von / Nach Tauschen";
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Location = new System.Drawing.Point(841, 690);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(252, 54);
			this.btnClose.TabIndex = 55;
			this.btnClose.Text = "Schliesen";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.OnClickClose);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.IndianRed;
			this.ClientSize = new System.Drawing.Size(1143, 756);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblChange);
			this.Controls.Add(this.btnReverseStations);
			this.Controls.Add(this.lblSendEmail);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnMail);
			this.Controls.Add(this.btnDepartureBoard);
			this.Controls.Add(this.btnMap);
			this.Controls.Add(this.lblDelete);
			this.Controls.Add(this.lvConnections);
			this.Controls.Add(this.lblConnections);
			this.Controls.Add(this.btnSearchForConnections);
			this.Controls.Add(this.btnDeleteStation);
			this.Controls.Add(this.lblZeit);
			this.Controls.Add(this.tpFromTime);
			this.Controls.Add(this.tpFromDate);
			this.Controls.Add(this.lblDatum);
			this.Controls.Add(this.txtToStation);
			this.Controls.Add(this.cmbToStation);
			this.Controls.Add(this.lblNachStation);
			this.Controls.Add(this.cmbFromStation);
			this.Controls.Add(this.txtFromStation);
			this.Controls.Add(this.lblVonStation);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Swisstransport Programm";
			((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.BindingSource transportBindingSource;
		private System.Windows.Forms.Label lblVonStation;
		private System.Windows.Forms.TextBox txtFromStation;
		private System.Windows.Forms.ComboBox cmbFromStation;
		private System.Windows.Forms.TextBox txtToStation;
		private System.Windows.Forms.ComboBox cmbToStation;
		private System.Windows.Forms.Label lblNachStation;
		private System.Windows.Forms.Label lblDatum;
		private System.Windows.Forms.DateTimePicker tpFromDate;
		private System.Windows.Forms.Label lblZeit;
		private System.Windows.Forms.DateTimePicker tpFromTime;
		private System.Windows.Forms.Button btnDeleteStation;
		private System.Windows.Forms.Button btnSearchForConnections;
		private System.Windows.Forms.Label lblConnections;
		private System.Windows.Forms.ListView lvConnections;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Label lblDelete;
		private System.Windows.Forms.Button btnMap;
		private System.Windows.Forms.Button btnDepartureBoard;
		private System.Windows.Forms.Button btnMail;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblSendEmail;
		private System.Windows.Forms.Button btnReverseStations;
		private System.Windows.Forms.Label lblChange;
		private System.Windows.Forms.Button btnClose;
	}
}

