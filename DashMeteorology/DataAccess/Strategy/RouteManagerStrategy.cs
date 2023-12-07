using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Strategy
{
    public class RouteManagerStrategy : IManagerStrategy<Route>
    {
        public void Create(Route route)
        {
            throw new NotImplementedException();
        }

        public void Update(Route route)
        {
            throw new NotImplementedException();
        }

        public void Delete(Route route)
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
