using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loesung_Projekt_318
{
	public partial class Abfahrtstafel : Form
	{
		public Abfahrtstafel()
		{
			InitializeComponent();
		}

		#region Events
		//Schliest Fenster
		private void OnClickClose(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region Funktionen
		public void SetcmbFromStation(string station)
		{
			lblFromStation.Text = station;
		}

		public void SetListItemView()
		{
			livStationboard.Items.Clear();
			Form1 form1 = new Form1();
			livStationboard.Items.AddRange(form1.GetStationBoard(lblFromStation.Text));
		}
		#endregion


	}
}
