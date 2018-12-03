using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nevins_SBB_App
{
    public partial class GoogleMaps : Form
    {
        public GoogleMaps(string Text)
        {
            InitializeComponent();

        }

        private void GoogleMaps_Shown(object sender, EventArgs e)
        {
            Stations sta = new Stations();
            Transport trans = new Transport();

            sta = trans.GetStations(Text);
            
            foreach(var station in sta.StationList)
            {
                
            }
        }
    }
}
