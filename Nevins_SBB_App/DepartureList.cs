using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SwissTransport;

namespace Nevins_SBB_App
{
    public partial class DepartureList : Form
    {
       
        private StationBoardRoot stationBoard;

        public DepartureList(string from)
        {
            try
            {
                Transport transport = new Transport();
                Stations stations = transport.GetStations(from);
                stationBoard = transport.GetStationBoard(from, stations.StationList[0].Id);
                InitializeComponent();
            }
            catch (WebException)
            {
                MessageBox.Show("Die Appliktion benötigt eine laufende Internetverbindung!");
            }
            catch (JsonSerializationException)
            {
                MessageBox.Show("Es wurden keine Koordinaten zu einer angegebenen Staion gefunden!\n Bitt andere Station eingeben.");
            }
        }

        private void DepartureList_Shown(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();

            foreach (StationBoard sb in stationBoard.Entries)
            {
                DepartureListViewModel viewModel = new DepartureListViewModel();
                viewModel.Von = stationBoard.Station.Name;
                viewModel.Nach = sb.To;
                viewModel.Abfahrtszeit = sb.Stop.Departure;
                //viewModel.Duration = DateTime.ParseExact(stationBoard.Duration.Substring(3, stationBoard.Duration.Length - 3), "HH:mm:ss", stationBoard.InvariantCulture, DateTimeStyles.None).TimeOfDay.ToString();
                //viewModel.Platform = sb.Number;
                //viewModel.Delay = stationBoard.From.Delay;
                viewModel.Linie = sb.Name;
                viewModel.Bahn = sb.Operator;
                bindingSource.Add(viewModel);
            }

            gridView.AutoSize = true;
            gridView.DataSource = bindingSource;
            txtlistfrom.Text = stationBoard.Station.Name;
        }

        private void gridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string location = $"maps/dir/{txtlistfrom.Text}/{gridView.CurrentRow.Cells[2].Value.ToString()}";
            System.Diagnostics.Process.Start($"http://google.com/{location}/");
        }
    }
}
