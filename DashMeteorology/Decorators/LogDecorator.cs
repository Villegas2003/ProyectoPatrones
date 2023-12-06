using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorators
{
    public class LogDecorator : DTOBase
    {
        private readonly IDTO _dto;

        public LogDecorator(IDTO dto)
        {
            _dto = dto;
        }

        public override void Log()
        {
            throw new NotImplementedException("Regsitro de DTO");
        }
    }
}
