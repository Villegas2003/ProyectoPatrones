using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class CurrentDataDTO : BaseDTO
    {
        public int DataId { get; set; }
        public DateTime? TimeStamp { get; set; }//Fecha y hora de registro
        public float? Temperature { get; set; }
        public int? Humidity { get; set; }
        public string? Condition { get; set; }
        public float? WindSpeed { get; set; }
    }
}
