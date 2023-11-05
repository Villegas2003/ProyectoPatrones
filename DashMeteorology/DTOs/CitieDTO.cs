using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class CitieDTO : BaseDTO
    {

        public CitieDTO()
        {
            Latitude = 0;
            Longitude = 0;
        }
        public int CityId { get; set; }
        public string? Name { get; set; }
        public string? Country { get; set; }
        public float? Latitude { get; set; }
        public float? Longitude { get; set; }
    }
}
