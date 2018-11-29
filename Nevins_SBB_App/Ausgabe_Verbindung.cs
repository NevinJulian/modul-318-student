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


namespace Nevins_SBB_App
{
    public partial class Ausgabe_Verbindung : Form
    {
        private Connections connections;

        public Ausgabe_Verbindung(string to, string from, string date, string time)
        {
            Transport transport = new Transport();
            connections = transport.GetConnectionsByDate(from, to, date, time);
            
            InitializeComponent();

        }

        private void Ausgabe_Verbindung_Shown(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();

            foreach (Connection connection in connections.ConnectionList)
            {
                Verbindungs_ViewModel viewModel = new Verbindungs_ViewModel();
                viewModel.From = connection.From.Station.Name;
                viewModel.To = connection.To.Station.Name;
                viewModel.departerTime = DateTime.Parse(connection.From.Departure);
                viewModel.Duration = connection.Duration;
                viewModel.Platform = connection.From.Platform;
                viewModel.Delay = connection.From.Delay;
                bindingSource.Add(viewModel);
            }

            gridView.AutoSize = true;
            gridView.DataSource = bindingSource;
        }
    }
}
