using DataAccess.CRUD;
using DataAccess.DAOs;
using DTOs;


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
            sqlOperation.AddVarcharParam("C_Name", carriers.Name);
            sqlOperation.AddVarcharParam("C_VEHICLE", carriers.CarRegistration);
            sqlOperation.AddVarcharParam("C_TYPE", carriers.VehicleType);
            sqlOperation.AddIntParam("C_Ability", carriers.Ability);

            _dao.ExecuteProcedure(sqlOperation);

        }
        public override void Update(BaseDTO baseDTO)
        {
            var carriers = baseDTO as Carriers;

            var sqlOperation = new SqlOperation { ProcedureName = "UP_CARRIERS" };
            sqlOperation.AddIntParam("C_IdCarriers", carriers.IdCarriers);
            sqlOperation.AddVarcharParam("C_Name", carriers.Name);
            sqlOperation.AddVarcharParam("C_VEHICLE", carriers.CarRegistration);
            sqlOperation.AddVarcharParam("C_TYPE", carriers.VehicleType);
            sqlOperation.AddIntParam("C_Ability", carriers.Ability);

            _dao.ExecuteProcedure(sqlOperation);

        }

        public override void Delete(BaseDTO baseDTO)
        {
            var carriers = baseDTO as Carriers;

            var sqlOperation = new SqlOperation { ProcedureName = "DEL_CARRIERS" };
            sqlOperation.AddIntParam("C_IdCarriers", carriers.IdCarriers);

            _dao.ExecuteProcedure(sqlOperation);

        }

        public override T Retrieve<T>()
        {
            throw new NotImplementedException();
        }

       public override List<T> RetrieveAll<T>()
        {
            throw new Exception();
        }   
        //var lstCarriers = new List<T>();

        //    var sqlOperation = new SqlOperation { ProcedureName = "RET_ALL_CARRIER" };

        //    var lstResults = _dao.ExecuteQueryProcedure(sqlOperation);
        //    if(lstCarriers.Count > 0)
        //    {
        //        foreach(var row in lstResults)
        //        {
        //            var carrierDTO = BuildUser<T>(row);
        //            lstCarriers.Add(carrierDTO);
        //        }
        //    }

        //    return lstCarriers;
        //}

        //private T BuildUser<T>(Dictionary<string, object> row)
        //{
        //    var carrierDTO = new Carriers();
        //    {
        //        id = (int)row["IdCarriers"],
        //        Name = (string)row[]
        //    }
        //}
    }
}
