using DataAccess.DAOs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.CRUD
{
    public interface ITarget { 

        public abstract void Create(BaseDTO baseDTO);
        public abstract void Update(BaseDTO baseDTO);
        public abstract void Delete(BaseDTO baseDTO);
        public abstract T Retrieve<T>();
        public abstract List<T> RetrieveAll<T>();
    }
}
