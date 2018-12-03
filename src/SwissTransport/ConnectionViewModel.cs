using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransport
{
    public class ConnectionViewModel
    {
        public string Von { get; set; }
        public string Nach { get; set; }
        public DateTime Abfahrtszeit { get; set; }
        public string Dauer { get; set; }
        public string Plattform { get; set; }
        public int? Verspätung { get; set; }
    }
}
