using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Strategy
{
    public class CarriersManagerStrategy : IManagerStrategy<Carriers>
    {
        public void Create(Carriers carriers)
        {
            throw new NotImplementedException();
        }

        public void Update(Carriers carriers)
        {
            throw new NotImplementedException();
        }

        public void Delete(Carriers carriers)
        {
            throw new NotImplementedException();
        }

        public object? RetrieveAll()
        {
            throw new NotImplementedException();
            return null;
        }
    }
}
