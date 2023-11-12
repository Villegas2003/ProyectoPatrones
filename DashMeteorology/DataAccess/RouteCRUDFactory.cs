using DataAccess.CRUD;
using DataAccess.DAOs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RouteCRUDFactory : CrudFactory
    {
        public RouteCRUDFactory() 
        {
            _dao = SqlDao.GetInstance();
        }

        public override void Create(BaseDTO baseDTO)
        {
            var route = baseDTO as Route;

            var sqlOperation = new SqlOperation { ProcedureName = "CRE_ROUTE" };
            sqlOperation.AddVarcharParam("R_ORIGIN", route.Name);
            sqlOperation.AddVarcharParam("R_DESTINATION", route.Destination);
            sqlOperation.AddVarcharParam("R_DISTANCE", route.Distance);
            sqlOperation.AddVarcharParam("R_TRANSPORTUNITE", route.TransportUnit);
            sqlOperation.AddVarcharParam("R_STARPOINT", route.Startpoint);
            sqlOperation.AddVarcharParam("R_FINALPOINT", route.Finalpoint);

            _dao.ExecuteProcedure(sqlOperation);

        }
        public override void Update(BaseDTO baseDTO)
        {
            var route = baseDTO as Route;

            var sqlOperation = new SqlOperation { ProcedureName = "UP_ROUTE" };
            sqlOperation.AddIntParam("R_IDROUTE", route.Id);
            sqlOperation.AddVarcharParam("R_ORIGIN", route.Name);
            sqlOperation.AddVarcharParam("R_DESTINATION", route.Destination);
            sqlOperation.AddVarcharParam("R_DISTANCE", route.Distance);
            sqlOperation.AddVarcharParam("R_TRANSPORTUNITE", route.TransportUnit);
            sqlOperation.AddVarcharParam("R_STARPOINT", route.Startpoint);
            sqlOperation.AddVarcharParam("R_FINALPOINT", route.Finalpoint);

            _dao.ExecuteProcedure(sqlOperation);

        }

        public override void Delete(BaseDTO baseDTO)
        {
            var route = baseDTO as Route;

            var sqlOperation = new SqlOperation { ProcedureName = "DELETE_ROUTE" };
            sqlOperation.AddIntParam("R_IDROUTE", route.Id);

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
