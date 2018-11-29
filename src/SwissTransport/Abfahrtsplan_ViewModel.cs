using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransport
{
    public class Abfahrtsplan_ViewModel
    {
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Departure { get; set; }
        public string Name { get; set; }
        public string Operator { get; set; }
    }
}
