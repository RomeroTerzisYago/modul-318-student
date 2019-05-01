using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace Loesung_Projekt_318
{
	public partial class Form1 : Form
	{
		#region Membervariablen

		//Membervariablen
		List<string> fromStationId = new List<string>();
		List<Station> stationList = new List<Station>();
		Transport transport = new Transport();
		string departureTime = null;
		string departureDate = null;
		int isArrivalTime = 1;
		#endregion

		#region Initialization des Forms
		public Form1()
		{
			InitializeComponent();
			
		}
		#endregion

		#region Events
		//Löschen von Eingaben in den Textboxen und inhalt von Comboxen
		private void OnClickDelete(object sender, EventArgs e)
		{
			cmbToStation.Items.Clear();
			cmbToStation.Text = "";
			txtToStation.Clear();
			cmbFromStation.Items.Clear();
			cmbFromStation.Text = "";
			txtFromStation.Clear();
		}

		//Zeigt Verbindungen in der ListView
		private void OnClickSearchConnection(object sender, EventArgs e)
		{
			SetIsArrivalTime();
			SetDepartureDate();
			SetDepartureTime();
			lvConnections.Items.Clear();
			lvConnections.Items.AddRange(GetConnection(cmbFromStation.Text, cmbToStation.Text));

		}

		//Die Geschriebene Eingabe von  From Textbox im From Combobox zeigen
		private void OnFromTextChanged(object sender, EventArgs e)
		{
			cmbFromStation.Items.Clear();
			GetFromStation(txtFromStation.Text, cmbFromStation);
		}

		//Die Geschriebene Eingabe von  To Textbox im From Combobox zeigen
		private void OnTextToChanged(object sender, EventArgs e)
		{
			cmbToStation.Items.Clear();
			GetToStation(txtToStation.Text, cmbToStation);
		}

		//Abfahrt Tafel Anzeigen 
		private void OnClickAbfahrtTafel(object sender, EventArgs e)
		{
			if(cmbFromStation.SelectedIndex != -1)
			{
				Abfahrtstafel abfahrtstafelForm = new Abfahrtstafel();
				abfahrtstafelForm.SetcmbFromStation(cmbFromStation.Text);
				abfahrtstafelForm.SetListItemView();
				abfahrtstafelForm.ShowDialog();
			}
		}
		#endregion

		#region Funktionen
		//Alle From Stationen abrufen 
		private void GetFromStation(string location, ComboBox cmbStation)
		{
			Stations station = transport.GetStations(location);
			List<string> fromStationList = new List<string>();

			foreach (var item in station.StationList)
			{
				if (!string.IsNullOrEmpty(item.Name))
					fromStationList.Add(item.Name);
			}
			foreach (var item in fromStationList)
			{
				cmbStation.Items.Add(item);
			}
			if (cmbStation.Items.Count > 0)
				cmbStation.SelectedIndex = 0;
		}

		//Alle To Stationen abrufen
		private void GetToStation(string location, ComboBox cmbStation)
		{
			Stations station = transport.GetStations(location);
			List<string> toStationList = new List<string>();

			foreach (var item in station.StationList)
			{
				if (!string.IsNullOrEmpty(item.Name))
					toStationList.Add(item.Name);
			}
			foreach (var item in toStationList)
			{
				cmbStation.Items.Add(item);
			}
			if (cmbStation.Items.Count > 0)
				cmbStation.SelectedIndex = 0;
		}

		//VerbindunG
		private ListViewItem[] GetConnection(string fromStation, string toStation)
		{
			Connections ConnectionListView = transport.GetConnections(fromStation, toStation);
			try
			{
				ConnectionListView = transport.GetConnections(fromStation, toStation);
			}
			catch (Exception e)
			{
				ListViewItem[] errorListItemView = new ListViewItem[1];
				errorListItemView[0] = new ListViewItem("Fehler:\n");
				errorListItemView[0].SubItems.Add(e.Message);
				return errorListItemView;

			}
			ListViewItem[] listView = new ListViewItem[ConnectionListView.ConnectionList.Count];
			for (int i = 0; i < ConnectionListView.ConnectionList.Count; i++)
			{
				listView[i] = new ListViewItem(ConnectionListView.ConnectionList[i].From.Station.Name);
				listView[i].SubItems.Add(ConnectionListView.ConnectionList[i].To.Station.Name);
				listView[i].SubItems.Add(DateTime.Parse(ConnectionListView.ConnectionList[i].From.Departure).ToShortTimeString());
			
			}
			if (listView == null)
			{
				listView[0] = new ListViewItem("Es sind keine Verbindungen vorhanden");
			}
			return listView;
		}
		public ListViewItem[] GetStationBoard(string fromStation)
		{
			Stations stations = new Stations();
			stations = transport.GetStations(fromStation);
			string stationId = stations.StationList.First().Id;
			StationBoardRoot stationBoard = null;
			try
			{
				stationBoard = transport.GetStationBoard(fromStation, stationId);
			}
			catch (Exception e)
			{
				ListViewItem[] errorListView = new ListViewItem[1];
				errorListView[0] = new ListViewItem("Fehler:\n");
				errorListView[0].SubItems.Add(e.Message);
				return errorListView;
			}
			ListViewItem[] stationListView = new ListViewItem[stationBoard.Entries.Count];
			int i = 0;
			foreach(StationBoard item in stationBoard.Entries)
			{
				stationListView[i] = new ListViewItem(item.Name);
				stationListView[i].SubItems.Add(item.Stop.Departure.ToShortTimeString());
				stationListView[i].SubItems.Add(item.To);
				i++;
			}
			if (stationListView == null)
				stationListView[0] = new ListViewItem("Keine Abfahrtstafel vorhanden");
			return stationListView;
		}

		#endregion

		#region Methoden Set und Get für Membervariablen
		private void SetDepartureTime()
		{
			departureTime = (tpFromTime.Value.Hour) + ":" + tpFromTime.Value.Minute;
		}
		private void SetDepartureDate()
		{
			departureDate = tpFromDate.Value.Year + "-" + tpFromDate.Value.Month + "-" + tpFromDate.Value.Day;
		}
		private void SetIsArrivalTime()
		{
			if (optIsArrival.Checked == true)
				isArrivalTime = 1;
			else if (optIsDeparture.Checked == true)
				isArrivalTime = 0;
		}
		#endregion
	}
}
