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
    public partial class SBBApp : Form
    {
        private Transport transport = new Transport();
        private Stations sta = new Stations();

        public SBBApp()
        {
            InitializeComponent();
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void btnsearchconnection_Click(object sender, EventArgs e)
        { 
            string to = txtConnectionTo.Text;
            string from = txtConnectionFrom.Text;
            var departDate = dateTimePicker.Value;
            string formattedDate = departDate.Year + "-" + departDate.Month + "-" + departDate.Day;
            string time = txtTime.Text;
            DisplayConnections ausgabe_Verbindung = new DisplayConnections(to, from, formattedDate, time);
            ausgabe_Verbindung.ShowDialog();
            
        }

        private void SBBApp_Shown(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Now;
            if (txtConnectionFrom.Text == "" || txtConnectionTo.Text == "")
            {
                btnSearchConnection.Enabled = false;
            }
            listConnectionFrom.Hide();
            listConnectionTo.Hide();
            listPlaceFrom.Hide();
        }

        private void bntcreatelist_Click(object sender, EventArgs e)
        {
            DepartureList abfahrtsliste_Ausgabe = new DepartureList(txtPlaceFrom.Text);
            abfahrtsliste_Ausgabe.ShowDialog();
        }

        private void txtconnectionfrom_TextChanged(object sender, EventArgs e)
        {
            list_Fill(listConnectionFrom, txtConnectionFrom);

            if (txtConnectionFrom.Text == "" || txtConnectionTo.Text == "")
            {
                btnSearchConnection.Enabled = false;
            }
            else if (txtConnectionFrom.Text != "" && txtConnectionTo.Text != "")
            {
                btnSearchConnection.Enabled = true;
            }
            try
            {
                foreach (var station in sta.StationList)
                {
                    try
                    {
                        listConnectionFrom.Items.Add(station.Name);
                    }
                    catch (System.ArgumentNullException)
                    {
                        MessageBox.Show("Die Stationsfelder dürfen nicht leer sein!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bitte Gültige Station eingeben!");
                        txtConnectionFrom.Text = "";
                    }
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("In der Liste der Vorschläge der eingegeben Station hat es keine Einträge!");
            }
        }

        private void txtconnectionto_TextChanged(object sender, EventArgs e)
        {
            list_Fill(listConnectionTo, txtConnectionTo);

            if (txtConnectionFrom.Text == "" || txtConnectionTo.Text == "")
            {
                btnSearchConnection.Enabled = false;
            }
            else if (txtConnectionFrom.Text != "" && txtConnectionTo.Text != "")
            {
                btnSearchConnection.Enabled = true;
            }
            try
            {
                foreach (var station in sta.StationList)
                {
                    try
                    {
                        listConnectionTo.Items.Add(station.Name);
                    }
                    catch (System.ArgumentNullException)
                    {
                        MessageBox.Show("Die Stationsfelder dürfen nicht leer sein!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bitte Gültige Station eingeben!");
                        txtConnectionTo.Text = "";
                    }
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("In der Liste der Vorschläge der eingegeben Station hat es keine Einträge!");
            }

        }

        private void txtplacefrom_TextChanged(object sender, EventArgs e)
        {
            list_Fill(listPlaceFrom, txtPlaceFrom);

            if (txtPlaceFrom.Text == "")
            {
                btnSearchConnection.Enabled = false;
            }
            else if(txtPlaceFrom.Text != "")
            {
                btnSearchConnection.Enabled = true;
            }
            try
            {
                foreach (var station in sta.StationList)
                {
                    try
                    {
                        listPlaceFrom.Items.Add(station.Name);
                    }
                    catch (System.ArgumentNullException)
                    {
                        MessageBox.Show("Die Stationsfelder dürfen nicht leer sein!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bitte Gültige Station eingeben!");
                        txtPlaceFrom.Text = "";
                    }
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("In der Liste der Vorschläge der eingegeben Station hat es keine Einträge!");
            }

        }

        private void list_Fill(ListBox List, TextBox Textbox)
        {
            try
            {
                Transport trans = new Transport();
                List.Show();

                List.Items.Clear();

                sta = trans.GetStations(Textbox.Text);

                Cursor.Current = Cursors.WaitCursor;
                Application.DoEvents();
            }
            catch (JsonSerializationException)
            {
                MessageBox.Show("Es wurden keine Koordinaten zu einer angegebenen Staion gefunden!\n Bitt andere Station eingeben.");
            }
            catch (WebException)
            {
                MessageBox.Show("Die Appliktion benötigt eine laufende Internetverbindung!");
            }
        }

        private void listconnectionfrom_DoubleClick(object sender, EventArgs e)
        {
            list_DoubleClick(listConnectionFrom, txtConnectionFrom);
        }

        private void listconnectionto_DoubleClick(object sender, EventArgs e)
        {
            list_DoubleClick(listConnectionTo, txtConnectionTo);
        }

        private void listplacefrom_DoubleClick(object sender, EventArgs e)
        {
            list_DoubleClick(listPlaceFrom, txtPlaceFrom);
        }

        private void list_DoubleClick(ListBox List, TextBox Textbox)
        {
            Textbox.Text = Convert.ToString(List.SelectedItem);
            List.Hide();
        }

        private void ListFromKeyControll(object sender, KeyEventArgs e)
        {
            ListKeyControll(listConnectionFrom, e);
        }

        private void ListKeyControll(ListBox list, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                list.SelectedIndex += 1;
            }
            else if(e.KeyCode == Keys.Down)
            {
                list.SelectedIndex -= 1;
            }
        }
    }
}
