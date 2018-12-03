using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransport
{
    public class DepartureListViewModel
    {
        public string Von { get; set; }
        public string Nach { get; set; }
        public DateTime Abfahrtszeit { get; set; }
        public string Linie { get; set; }
        public string Bahn { get; set; }
    }
}
