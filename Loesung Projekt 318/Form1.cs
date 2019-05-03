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
using System.Diagnostics;
using System.Device.Location;
namespace Loesung_Projekt_318
{
	public partial class Form1 : Form
	{
		#region Membervariablen

		List<string> fromStationId = new List<string>();
		List<Station> stationList = new List<Station>();
		Transport transport = new Transport();
		string departureTime = null;
		string departureDate = null;
		bool isArrivalTime = true;
		
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
			SetDepartureDate();
			SetDepartureTime();
			lvConnections.Items.Clear();
			lvConnections.Items.AddRange(GetConnection(cmbFromStation.Text, cmbToStation.Text));
		}

		//Die Geschriebene Eingabe von  FromTextbox im FromCombobox zeigen
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

		//From und To Combobox Eingaben vertauschen
		private void OnReverseClick(object sender, EventArgs e)
		{
			//Überprüfung ob die Combox Leer sind
			if (cmbFromStation.Items.Count == 0 && cmbToStation.Items.Count == 0)
				MessageBox.Show("Keine Stationen zum tauschen");
			else
			{
				string FromTausch = cmbFromStation.SelectedItem.ToString();
				txtFromStation.Text = cmbToStation.SelectedItem.ToString();
				txtToStation.Text = FromTausch;
			}
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
			else
				MessageBox.Show("Geben sie eine Vonstation ein");
		}

		//Senden von Email
		private void OnClickSendEmail(object sender, EventArgs e)
		{
			if (lvConnections.Items.Count != 0)
			{
				ListViewItem ItemMail = lvConnections.Items[0];
				string MailBody = null;

				for (int i = 0; i <= ItemMail.SubItems.Count - 1; i++)
				{
					MailBody += ItemMail.SubItems[i].Text + " ";
				}
				var url = "mailto:Email@Provider.com?Subjekt=SwissTransport%20APP%202019&body=Verbindung: " + MailBody;
				Process.Start(url);
			}
			else
				MessageBox.Show("Bitte wählen sie eine Verbindung");
		}

		//Mapabrufen
		private void OnClickOpenMap(object sender, EventArgs e)
		{
			string url = "https://www.google.com/maps/dir///@-0.2128512,-78.5060957,21z?hl=de-DE";
			Process.Start(url);
		}

		//Form 1 Schliesen
		private void OnClickClose(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region Funktionen
		//Alle From Stationen abrufen 
		private void GetFromStation(string location, ComboBox cmbStation)
		{
			Stations station = transport.GetStations(location);
			List<string> fromStationList = new List<string>();

			//Für jedes Item im Objekt stion wird in der Liste fromStation eingespeichert
			foreach (var item in station.StationList)
			{
				if (!string.IsNullOrEmpty(item.Name))
					fromStationList.Add(item.Name);
			}

			// Jedes element der fromStationList Liste wird im Combobox cmbStation der Funktion GetFromStation gespeichert
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

			//Für jedes Item im Objekt stion wird in der Liste fromStation eingespeichert
			foreach (var item in station.StationList)
			{
				if (!string.IsNullOrEmpty(item.Name))
					toStationList.Add(item.Name);
			}
			// Jedes element der fromStationList Liste wird im Combobox cmbStation der Funktion GetStation gespeichert
			foreach (var item in toStationList)
			{
				cmbStation.Items.Add(item);
			}
			if (cmbStation.Items.Count > 0)
				cmbStation.SelectedIndex = 0;
		}

		//Verbindung
		private ListViewItem[] GetConnection(string fromStation, string toStation)
		{
			Connections ConnectionListView;
			try
			{
				ConnectionListView = transport.GetConnections(fromStation, toStation, departureTime, departureDate, isArrivalTime);
			}
			catch (Exception e)
			{
				ListViewItem[] errorListItemView = new ListViewItem[1];
				errorListItemView[0] = new ListViewItem("Fehler:\n");
				errorListItemView[0].SubItems.Add(e.Message);
				return errorListItemView;

			}
			//Alle verbindungen werden in der listView Liste gespeichert und entsprechend formatiert
			ListViewItem[] listView = new ListViewItem[ConnectionListView.ConnectionList.Count];
			for (int i = 0; i < ConnectionListView.ConnectionList.Count; i++)
			{
				listView[i] = new ListViewItem(ConnectionListView.ConnectionList[i].From.Station.Name);
				listView[i].SubItems.Add(ConnectionListView.ConnectionList[i].To.Station.Name);
				listView[i].SubItems.Add(DateTime.Parse(ConnectionListView.ConnectionList[i].From.Departure).ToShortTimeString());
				listView[i].SubItems.Add(DateTime.Parse(ConnectionListView.ConnectionList[i].To.Arrival).ToShortTimeString());
				listView[i].SubItems.Add(TimeSpan.Parse(ConnectionListView.ConnectionList[i].Duration.Substring(3)).TotalMinutes.ToString() + " Min");

			}
			return listView;
		}

		//Stationen für Abfahrtstafel
		public ListViewItem[] GetStationBoard(string fromStation)
		{
			Stations stations = transport.GetStations(fromStation);
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
			//All die Stationen die in der Abfahrtstafel angeyeigt werden sollen, werden im stationListView gespeicher und entsprechend formatiert
			ListViewItem[] stationListView = new ListViewItem[stationBoard.Entries.Count];
			int i = 0;
			foreach(StationBoard item in stationBoard.Entries)
			{
				stationListView[i] = new ListViewItem(item.Name);
				stationListView[i].SubItems.Add(item.Stop.Departure.ToShortTimeString());
				stationListView[i].SubItems.Add(item.To);
				i++;
			}
			return stationListView;
		}
		#endregion

		#region Methoden Set und Get für Membervariablen

		//Formatierung der DepartureTime variable und der DepartureDate Variable
		private void SetDepartureTime()
		{
			departureTime = (tpFromTime.Value.Hour) + ":" + tpFromTime.Value.Minute;
		}
		private void SetDepartureDate()
		{
			departureDate = tpFromDate.Value.Year + "-" + tpFromDate.Value.Month + "-" + tpFromDate.Value.Day;
		}
		#endregion

		
	}
}
