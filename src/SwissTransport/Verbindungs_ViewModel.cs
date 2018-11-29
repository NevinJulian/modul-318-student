using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransport
{
    public class Verbindungs_ViewModel
    {
        public string From { get; set; }
        public string To { get; set; }
        public DateTime departerTime { get; set; }
        public string Duration { get; set; }
        public string Platform { get; set; }
        public int? Delay { get; set; }
    }
}
