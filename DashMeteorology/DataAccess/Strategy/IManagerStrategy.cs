using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Strategy
{
    public interface IManagerStrategy<T>
    {
        void Create(T item);
        void Update(T item);
        void Delete(T item);
        object? RetrieveAll();
    }
}
