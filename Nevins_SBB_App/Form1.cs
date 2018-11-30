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
    public partial class SBB_Fahrplan : Form
    {
        private Transport transport = new Transport();
        private AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();

        public SBB_Fahrplan()
        {
            InitializeComponent();
        }

        private void btnsearchconnection_Click(object sender, EventArgs e)
        {
            string to = txtconnectionto.Text;
            string from = txtconnectionfrom.Text;
            var departDate = dateTimePicker1.Value;
            string formattedDate = departDate.Year + "-" + departDate.Month + "-" + departDate.Day;
            string time = txtTime.Text;
            Ausgabe_Verbindung ausgabe_Verbindung = new Ausgabe_Verbindung(to, from, formattedDate, time);
            ausgabe_Verbindung.ShowDialog();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            if (txtconnectionfrom.Text == "" || txtconnectionto.Text == "")
            {
                btnsearchconnection.Enabled = false;
            }
        }

        private void bntcreatelist_Click(object sender, EventArgs e)
        {
            Abfahrtsliste_ausgabe abfahrtsliste_Ausgabe = new Abfahrtsliste_ausgabe(txtplacefrom.Text);
            abfahrtsliste_Ausgabe.ShowDialog();
        }

        private void bntgooglemaps_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.ch/maps/place/46°58'26.3\"N + 8°22'45.4\"E");
        }

        private void txtconnectionfrom_TextChanged(object sender, EventArgs e)
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            Stations sta = new Stations();
            Transport trans = new Transport();

            coll.Clear();

            sta = trans.GetStations(txtconnectionfrom.Text);

            foreach(var station in sta.StationList)
            {
                coll.Add(station.Name);
            }

            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            txtconnectionfrom.AutoCompleteCustomSource = coll;

            if (txtconnectionfrom.Text != "" || txtconnectionto.Text != "")
            {
                btnsearchconnection.Enabled = true;
            }
        }

        private void txtconnectionto_TextChanged(object sender, EventArgs e)
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            Stations sta = new Stations();
            Transport trans = new Transport();

            coll.Clear();

            sta = trans.GetStations(txtconnectionto.Text);

            foreach (var station in sta.StationList)
            {
                coll.Add(station.Name);
            }

            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            txtconnectionto.AutoCompleteCustomSource = coll;

            if (txtconnectionfrom.Text != "" || txtconnectionto.Text != "")
            {
                btnsearchconnection.Enabled = true;
            }
        }

        private void txtplacefrom_TextChanged(object sender, EventArgs e)
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            Stations sta = new Stations();
            Transport trans = new Transport();

            coll.Clear();

            sta = trans.GetStations(txtplacefrom.Text);

            foreach (var station in sta.StationList)
            {
                coll.Add(station.Name);
            }

            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            txtplacefrom.AutoCompleteCustomSource = coll;
        }

    }
}
