using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class Carriers : BaseDTO
    {
        public int IdCarriers { get; set; }
        public string Name { get; set; }
        public string CarRegistration { get; set; }
        public string VehicleType { get; set; }
        public int Ability { get; set; }

        public void Log()
        {

        }
    }
}
