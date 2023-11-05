using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class ForeCastDTO : BaseDTO
    {
        public int ForeCastId { get; set; }
        public DateTime? Date { get; set; }
        public float? MaxTemperature { get; set; }
        public float? MinTemperature { get; set; }
        public string? Condition { get; set; }
        public int CityId { get; set; }
    }
}
