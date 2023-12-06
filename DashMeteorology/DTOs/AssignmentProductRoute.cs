using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class AssignmentProductRoute : BaseDTO
    {
        public Route Route { get; set; }
        public Product Product { get; set; }
    }
}
