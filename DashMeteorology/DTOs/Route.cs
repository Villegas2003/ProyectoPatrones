using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class Route : BaseDTO
    {
        public int IdRoute { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public String Distance { get; set; }
        public string TransportUnit { get; set; }
        public string Startpoint { get; set; }
        public string Finalpoint { get; set; }
    }
}
