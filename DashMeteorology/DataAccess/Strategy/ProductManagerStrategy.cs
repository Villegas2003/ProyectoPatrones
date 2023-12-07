using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Strategy
{
    public class ProductManagerStrategy : IManagerStrategy<Product>
    {
        public void Create(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
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
