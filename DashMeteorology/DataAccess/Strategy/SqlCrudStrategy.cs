using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Strategy
{
    public class SqlCrudStrategy : ICrudStrategy
    {
        public void Create(BaseDTO baseDTO)
        {
            throw new NotImplementedException();
        }

        public void Update(BaseDTO baseDTO)
        {
            throw new NotImplementedException();
        }

        public void Delete(BaseDTO baseDTO)
        {
            throw new NotImplementedException();
        }

        public T Retrieve<T>()
        {
            throw new NotImplementedException();
            return default(T);
        }

        public List<T> RetrieveAll<T>()
        {
            throw new NotImplementedException();
            return new List<T>();
        }
    }
}
