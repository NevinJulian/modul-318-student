﻿using System;
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
            try
            {
                string to = txtConnectionTo.Text;
                string from = txtConnectionFrom.Text;
                var departDate = dateTimePicker.Value;
                string formattedDate = departDate.Year + "-" + departDate.Month + "-" + departDate.Day;
                string time = txtTime.Text;
                DisplayConnections ausgabe_Verbindung = new DisplayConnections(to, from, formattedDate, time);
                ausgabe_Verbindung.ShowDialog();
            }
            catch
            {

            }
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
            lblError.Hide();
            lblError2.Hide();
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

            if (sta.StationList.Count() == 0)
            {
                lblError.Text = "Bitte gültige Station eingeben!";
                listConnectionFrom.Hide();
                lblError.Show();
            }
            else if (sta.StationList.Count() != 0)
            {
                lblError.Hide();
                foreach (var station in sta.StationList)
                {
                    try
                    {
                        listConnectionFrom.Items.Add(station.Name);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bitte Gültige Station eingeben!");
                        txtConnectionFrom.Text = "";
                    }
                }
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

            if (sta.StationList.Count() == 0)
            {
                lblError.Text = "Bitte gültige Station eingeben!";
                listConnectionTo.Hide();
                lblError.Show();
            }
            else if (sta.StationList.Count() != 0)
            {
                lblError.Hide();
                foreach (var station in sta.StationList)
                {
                    try
                    {
                        listConnectionTo.Items.Add(station.Name);
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Bitte Gültige Station eingeben!");
                        txtConnectionTo.Text = "";
                    }
                }
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

            if (sta.StationList.Count() == 0)
            {
                lblError2.Text = "Bitte gültige Station eingeben!";
                listPlaceFrom.Hide();
                lblError2.Show();
            }
            else if (sta.StationList.Count() != 0)
            {
                lblError2.Hide();
                foreach (var station in sta.StationList)
                {
                    try
                    {
                        listPlaceFrom.Items.Add(station.Name);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bitte Gültige Station eingeben!");
                        txtConnectionTo.Text = "";
                    }
                }
            }
        }

        private void list_Fill(ListBox List, TextBox Textbox)
        {
            Transport trans = new Transport();
            List.Show();

            List.Items.Clear();

            sta = trans.GetStations(Textbox.Text);

            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
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