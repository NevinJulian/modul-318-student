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
        private Stations sta = new Stations();

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
            listconnectionfrom.Hide();
            listconnectionto.Hide();
            listplacefrom.Hide();
            lblError.Hide();
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
            list_Fill(listconnectionfrom, txtconnectionfrom);

            if (txtconnectionfrom.Text == "" || txtconnectionto.Text == "")
            {
                btnsearchconnection.Enabled = false;
            }
            else if (txtconnectionfrom.Text != "" && txtconnectionto.Text != "")
            {
                btnsearchconnection.Enabled = true;
            }
        }

        private void txtconnectionto_TextChanged(object sender, EventArgs e)
        {
            list_Fill(listconnectionto, txtconnectionto);

            if (txtconnectionfrom.Text == "" || txtconnectionto.Text == "")
            {
                btnsearchconnection.Enabled = false;
            }
            else if (txtconnectionfrom.Text != "" && txtconnectionto.Text != "")
            {
                btnsearchconnection.Enabled = true;
            }
        }

        private void txtplacefrom_TextChanged(object sender, EventArgs e)
        {
            list_Fill(listplacefrom, txtplacefrom);

            if (txtplacefrom.Text == "")
            {
                btnsearchconnection.Enabled = false;
            }
            else if(txtplacefrom.Text != "")
            {
                btnsearchconnection.Enabled = true;
            }
        }

        private void list_Fill(ListBox list, TextBox textbox)
        {
            Transport trans = new Transport();
            list.Show();

            list.Items.Clear();

            sta = trans.GetStations(textbox.Text);

            if (sta.StationList.Count() == 0)
            {
                lblError.Text = "Bitte gültige Station eingeben!";
                list.Hide();
                lblError.Show();
            }
            else if (sta.StationList.Count() != 0)
            {
                foreach (var station in sta.StationList)
                {
                    list.Items.Add(station.Name);
                }
            }

            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
        }

        private void listconnectionfrom_DoubleClick(object sender, EventArgs e)
        {
            list_DoubleClick(listconnectionfrom, txtconnectionfrom);
        }

        private void listconnectionto_DoubleClick(object sender, EventArgs e)
        {
            list_DoubleClick(listconnectionto, txtconnectionto);
        }

        private void listplacefrom_DoubleClick(object sender, EventArgs e)
        {
            list_DoubleClick(listplacefrom, txtplacefrom);
        }

        private void list_DoubleClick(ListBox list, TextBox textbox)
        {
            textbox.Text = Convert.ToString(list.SelectedItem);
            list.Hide();
        }
    }
}
