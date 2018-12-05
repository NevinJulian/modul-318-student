using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;


namespace Nevins_SBB_App
{
    public partial class DisplayConnections : Form
    {
        private Connections connections;

        public DisplayConnections(string to, string from, string date, string time)
        {
            Transport transport = new Transport();
            try
            {
                connections = transport.GetConnectionsByDate(from, to, date, time);
            }
            catch(Newtonsoft.Json.JsonSerializationException)
            {
                MessageBox.Show("Es wurden keine Koordinaten zu einer angegebenen Staion gefunden!\n Bitt andere Station eingeben.");
                connections = null;
            }
            InitializeComponent();

        }

        private void DisplayConnection_Shown(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();

            foreach (Connection connection in connections.ConnectionList)
            {
                ConnectionViewModel viewModel = new ConnectionViewModel();
                viewModel.Von = connection.From.Station.Name;
                viewModel.Nach = connection.To.Station.Name;
                viewModel.Abfahrtszeit = DateTime.Parse(connection.From.Departure);
                viewModel.Dauer = DateTime.ParseExact(connection.Duration.Substring(3, connection.Duration.Length - 3), "HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None).TimeOfDay.ToString();
                viewModel.Plattform = connection.From.Platform;
                viewModel.Verspätung = connection.From.Delay;
                bindingSource.Add(viewModel);
                txtconnectionto.Text = connection.To.Station.Name;
                txtconnectionfrom.Text = connection.From.Station.Name;
            }

            gridView.AutoSize = true;
            gridView.DataSource = bindingSource;
        }

        private void gridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string location = $"maps/dir/{txtconnectionfrom.Text}/{txtconnectionto.Text}";
            System.Diagnostics.Process.Start($"http://google.com/{location}/");
        }
    }
}
