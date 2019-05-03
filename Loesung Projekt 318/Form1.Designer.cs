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
			this.lblChange = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnReverseStations = new System.Windows.Forms.Button();
			this.btnMail = new System.Windows.Forms.Button();
			this.btnMap = new System.Windows.Forms.Button();
			this.btnDeleteStation = new System.Windows.Forms.Button();
			this.transportBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// lblVonStation
			// 
			resources.ApplyResources(this.lblVonStation, "lblVonStation");
			this.lblVonStation.Name = "lblVonStation";
			// 
			// txtFromStation
			// 
			resources.ApplyResources(this.txtFromStation, "txtFromStation");
			this.txtFromStation.Name = "txtFromStation";
			this.txtFromStation.TextChanged += new System.EventHandler(this.OnFromTextChanged);
			// 
			// cmbFromStation
			// 
			resources.ApplyResources(this.cmbFromStation, "cmbFromStation");
			this.cmbFromStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbFromStation.FormattingEnabled = true;
			this.cmbFromStation.Name = "cmbFromStation";
			this.cmbFromStation.SelectedIndexChanged += new System.EventHandler(this.SelectedFromStation);
			// 
			// txtToStation
			// 
			resources.ApplyResources(this.txtToStation, "txtToStation");
			this.txtToStation.Name = "txtToStation";
			this.txtToStation.TextChanged += new System.EventHandler(this.OnTextToChanged);
			// 
			// cmbToStation
			// 
			resources.ApplyResources(this.cmbToStation, "cmbToStation");
			this.cmbToStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbToStation.FormattingEnabled = true;
			this.cmbToStation.Name = "cmbToStation";
			this.cmbToStation.SelectedIndexChanged += new System.EventHandler(this.OnSelectedToStation);
			// 
			// lblNachStation
			// 
			resources.ApplyResources(this.lblNachStation, "lblNachStation");
			this.lblNachStation.Name = "lblNachStation";
			// 
			// lblDatum
			// 
			resources.ApplyResources(this.lblDatum, "lblDatum");
			this.lblDatum.Name = "lblDatum";
			// 
			// tpFromDate
			// 
			resources.ApplyResources(this.tpFromDate, "tpFromDate");
			this.tpFromDate.Checked = false;
			this.tpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.tpFromDate.Name = "tpFromDate";
			// 
			// lblZeit
			// 
			resources.ApplyResources(this.lblZeit, "lblZeit");
			this.lblZeit.Name = "lblZeit";
			// 
			// tpFromTime
			// 
			resources.ApplyResources(this.tpFromTime, "tpFromTime");
			this.tpFromTime.Checked = false;
			this.tpFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.tpFromTime.Name = "tpFromTime";
			this.tpFromTime.ShowUpDown = true;
			// 
			// btnSearchForConnections
			// 
			resources.ApplyResources(this.btnSearchForConnections, "btnSearchForConnections");
			this.btnSearchForConnections.BackColor = System.Drawing.Color.White;
			this.btnSearchForConnections.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearchForConnections.Name = "btnSearchForConnections";
			this.btnSearchForConnections.UseVisualStyleBackColor = false;
			this.btnSearchForConnections.Click += new System.EventHandler(this.OnClickSearchConnection);
			// 
			// lblConnections
			// 
			resources.ApplyResources(this.lblConnections, "lblConnections");
			this.lblConnections.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.lblConnections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblConnections.Name = "lblConnections";
			// 
			// lvConnections
			// 
			resources.ApplyResources(this.lvConnections, "lvConnections");
			this.lvConnections.BackColor = System.Drawing.Color.WhiteSmoke;
			this.lvConnections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
			this.lvConnections.FullRowSelect = true;
			this.lvConnections.Name = "lvConnections";
			this.lvConnections.TileSize = new System.Drawing.Size(168, 30);
			this.lvConnections.UseCompatibleStateImageBehavior = false;
			this.lvConnections.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			resources.ApplyResources(this.columnHeader1, "columnHeader1");
			// 
			// columnHeader3
			// 
			resources.ApplyResources(this.columnHeader3, "columnHeader3");
			// 
			// columnHeader2
			// 
			resources.ApplyResources(this.columnHeader2, "columnHeader2");
			// 
			// columnHeader4
			// 
			resources.ApplyResources(this.columnHeader4, "columnHeader4");
			// 
			// columnHeader5
			// 
			resources.ApplyResources(this.columnHeader5, "columnHeader5");
			// 
			// lblDelete
			// 
			resources.ApplyResources(this.lblDelete, "lblDelete");
			this.lblDelete.Name = "lblDelete";
			// 
			// btnDepartureBoard
			// 
			resources.ApplyResources(this.btnDepartureBoard, "btnDepartureBoard");
			this.btnDepartureBoard.BackColor = System.Drawing.Color.White;
			this.btnDepartureBoard.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDepartureBoard.Name = "btnDepartureBoard";
			this.btnDepartureBoard.UseVisualStyleBackColor = false;
			this.btnDepartureBoard.Click += new System.EventHandler(this.OnClickAbfahrtTafel);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// lblSendEmail
			// 
			resources.ApplyResources(this.lblSendEmail, "lblSendEmail");
			this.lblSendEmail.Name = "lblSendEmail";
			// 
			// lblChange
			// 
			resources.ApplyResources(this.lblChange, "lblChange");
			this.lblChange.Name = "lblChange";
			// 
			// btnClose
			// 
			resources.ApplyResources(this.btnClose, "btnClose");
			this.btnClose.BackColor = System.Drawing.Color.White;
			this.btnClose.Name = "btnClose";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.OnClickClose);
			// 
			// btnReverseStations
			// 
			resources.ApplyResources(this.btnReverseStations, "btnReverseStations");
			this.btnReverseStations.BackColor = System.Drawing.Color.White;
			this.btnReverseStations.BackgroundImage = global::Loesung_Projekt_318.Properties.Resources.reverse;
			this.btnReverseStations.Name = "btnReverseStations";
			this.btnReverseStations.UseVisualStyleBackColor = false;
			this.btnReverseStations.Click += new System.EventHandler(this.OnReverseClick);
			// 
			// btnMail
			// 
			resources.ApplyResources(this.btnMail, "btnMail");
			this.btnMail.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnMail.BackgroundImage = global::Loesung_Projekt_318.Properties.Resources.icons8_secured_letter_100;
			this.btnMail.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMail.Name = "btnMail";
			this.btnMail.UseVisualStyleBackColor = false;
			this.btnMail.Click += new System.EventHandler(this.OnClickSendEmail);
			// 
			// btnMap
			// 
			resources.ApplyResources(this.btnMap, "btnMap");
			this.btnMap.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnMap.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMap.Name = "btnMap";
			this.btnMap.UseVisualStyleBackColor = false;
			this.btnMap.Click += new System.EventHandler(this.OnClickOpenMap);
			// 
			// btnDeleteStation
			// 
			resources.ApplyResources(this.btnDeleteStation, "btnDeleteStation");
			this.btnDeleteStation.BackColor = System.Drawing.Color.White;
			this.btnDeleteStation.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeleteStation.Name = "btnDeleteStation";
			this.btnDeleteStation.UseVisualStyleBackColor = false;
			this.btnDeleteStation.Click += new System.EventHandler(this.OnClickDelete);
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.IndianRed;
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
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
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

