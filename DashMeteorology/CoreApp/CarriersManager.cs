using DataAccess;
using DataAccess.CRUD;
using DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;

namespace CoreApp
{
    public class CarriersManager
    {
        private readonly ITarget _carriersAdapter;
        private CarriersCRUDFactory carriersAdapter;

        public CarriersManager(ITarget carriersAdapter)
        {
            _carriersAdapter = carriersAdapter;
        }

        public CarriersManager(CarriersCRUDFactory carriersAdapter)
        {
            this.carriersAdapter = carriersAdapter;
        }

        public void Create(Carriers carriers) 
        {
            if (carriers.Name == null)
            {
                throw new ArgumentException("Name is required.");
            }
            var allowedCondition = new List<string> {"Hino", "Walking", "Motorbike", "Hilux" };
            if (!allowedCondition.Contains(carriers.VehicleType))
            {
                throw new ArgumentException("The type of vehicle must be; Hino, Walking, Motorbike, Hilux");
            }

            if (carriers.VehicleType == null)
            {
                throw new ArgumentException("Vehicle type is required.");
            }

            if (carriers.Ability <= 0)
            {
                throw new ArgumentException("Ability must be a positive number.");
            }

            var cm = new CarriersCRUDFactory();
            cm.Create(carriers);
        }

        public void Delete(Carriers carriers)
        {
            if(carriers.Id == null)
            {
                throw new Exception("The Id cannot be null");
            }
            var cm = new CarriersCRUDFactory();
            cm.Delete(carriers);
            
        }

        public void Update(Carriers carriers)
        {
            if(carriers.Id == null)
            {
                throw new Exception("The Id cannot be null");
            }
            var cm = new CarriersCRUDFactory();
            cm.Update(carriers);

        }

        public object? RetrieveAll()
        {
            var vc = new CarriersCRUDFactory();
            return vc.RetrieveAll<Carriers>();
        }
    }

}
