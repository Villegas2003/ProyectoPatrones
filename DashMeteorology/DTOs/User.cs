using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class User : BaseDTO
    {
        public int cedula {  get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public void Log()
        {

        }
    }
}
