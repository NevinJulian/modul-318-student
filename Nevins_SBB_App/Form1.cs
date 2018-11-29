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
    public partial class Form1 : Form
    {
        private Transport transport = new Transport();
        private AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();

        public Form1()
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


        }

        private void txtconnectionfrom_KeyUp(object sender, KeyEventArgs e)
        {
            var test = 22;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            MyCollection.Clear();
            var stations = transport.GetStations(textBox1.Text);
            foreach (var item in stations.StationList)
            {
                MyCollection.Add(item.Name);
            }

            textBox1.AutoCompleteCustomSource = MyCollection;
        }

    }
}
