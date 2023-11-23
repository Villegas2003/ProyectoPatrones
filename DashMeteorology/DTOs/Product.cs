using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class Product : BaseDTO
    {
       
        public string? Name { get; set; }
        public int Price { get; set; }
        public string? Parts { get; set; }
        public string? Category { get; set; }
    }
}
