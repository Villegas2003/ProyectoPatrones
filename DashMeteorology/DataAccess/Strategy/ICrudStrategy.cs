using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Strategy
{
    public interface ICrudStrategy
    {
        void Create(BaseDTO baseDTO);
        void Update(BaseDTO baseDTO);
        void Delete(BaseDTO baseDTO);
        T Retrieve<T>();
        List<T> RetrieveAll<T>();
    }
}
