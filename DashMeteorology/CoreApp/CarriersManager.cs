using DataAccess;
using DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoreApp
{
    public class CarriersManager
    {

        public void Create(Carriers carriers) 
        {
            if (string.IsNullOrWhiteSpace(carriers.Name))
            {
                throw new ArgumentException("Name is required.");
            }

            if (string.IsNullOrWhiteSpace(carriers.CarRegistration))
            {
                throw new ArgumentException("Car registration is required.");
            }

            if (string.IsNullOrWhiteSpace(carriers.VehicleType))
            {
                throw new ArgumentException("Vehicle type is required.");
            }

            if (carriers.Ability <= 0)
            {
                throw new ArgumentException("Ability must be a positive number.");
            }
        }

        public void Delete(Carriers carriers)
        {
            /*var cd = new CurrentDataCRUDFactory(); cd.Delete(currentData)*/
            throw new NotImplementedException();
        }

        public object? RetrieveAll()
        {
            /*var ct = new CurrentDataCRUDFactory();

            return ct.RetrieveAll<CurrentDataDTO>();*/
            throw new NotImplementedException();
        }

        public void Update(Carriers carriers)
        {

            throw new NotImplementedException();
        }
    }

}
