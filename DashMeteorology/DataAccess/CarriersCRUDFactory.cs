using DataAccess.CRUD;
using DataAccess.DAOs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CarriersCRUDFactory : CrudFactory
    {

        public CarriersCRUDFactory()
        {
            _dao = SqlDao.GetInstance();
        }

        public override void Create(BaseDTO baseDTO)
        {
            var carriers = baseDTO as Carriers;

            var sqlOperation = new SqlOperation { ProcedureName = "CRE_CARRIERS" };
            sqlOperation.AddVarcharParam("R_ORIGIN", carriers.Name);
            sqlOperation.AddVarcharParam("C_VEHICLE", carriers.CarRegistration);
            sqlOperation.AddVarcharParam("C_TYPE", carriers.VehicleType);
            sqlOperation.AddIntParam("C_Ability", carriers.Ability);

            _dao.ExecuteProcedure(sqlOperation);

        }
        public override void Update(BaseDTO baseDTO)
        {
            var carriers = baseDTO as Carriers;

            var sqlOperation = new SqlOperation { ProcedureName = "UP_CARRIERS" };
            sqlOperation.AddIntParam("C_IdCarriers", carriers.Id);
            sqlOperation.AddVarcharParam("R_ORIGIN", carriers.Name);
            sqlOperation.AddVarcharParam("C_VEHICLE", carriers.CarRegistration);
            sqlOperation.AddVarcharParam("C_TYPE", carriers.VehicleType);
            sqlOperation.AddIntParam("C_Ability", carriers.Ability);

            _dao.ExecuteProcedure(sqlOperation);

        }

        public override void Delete(BaseDTO baseDTO)
        {
            var carriers = baseDTO as Carriers;

            var sqlOperation = new SqlOperation { ProcedureName = "DELETE_ROUTE" };
            sqlOperation.AddIntParam("C_IdCarriers", carriers.Id);

            _dao.ExecuteProcedure(sqlOperation);

        }

        public override T Retrieve<T>()
        {
            throw new NotImplementedException();
        }

        public override List<T> RetrieveAll<T>()
        {
            throw new NotImplementedException();
        }
    }
}
