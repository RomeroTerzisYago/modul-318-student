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
	public partial class Maps : Form
	{
		private List<string> Rute = new List<string>();
		public Maps()
		{
			InitializeComponent();
		}

		private void OnClickClose(object sender, EventArgs e)
		{
			this.Close();
		}

		private void OnMapsLoad(object sender, EventArgs e)
		{
			webMap.Navigate("https://www.google.com/maps");
		}
	}
}
