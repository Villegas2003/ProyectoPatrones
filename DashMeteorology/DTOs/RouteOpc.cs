using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class RouteOpc : BaseDTO
    {
        public string Origin {  get; set; }
        public string Destiny { get; set; }
        public double Distance {  get; set; }
        public double Price { get; set; }
        public Boolean Approved {  get; set; }
    }
}
