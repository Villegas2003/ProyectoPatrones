using DataAccess.CRUD;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserCRUDAdapter : ITarget
    {
        private readonly CarriersCRUDFactory _carriersCRUDAFactory;

        public UserCRUDAdapter()
        {
            _carriersCRUDAFactory = new CarriersCRUDFactory();
        }

        public void Create(BaseDTO baseDTO)
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
        }

        public List<T> RetrieveAll<T>()
        {
            throw new NotImplementedException();
        }

        public void Update(BaseDTO baseDTO)
        {
            throw new NotImplementedException();
        }
    }
}
