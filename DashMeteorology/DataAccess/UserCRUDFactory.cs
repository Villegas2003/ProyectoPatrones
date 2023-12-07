using DataAccess.CRUD;
using DataAccess.DAOs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserCRUDFactory : CrudFactory
    {
        public UserCRUDFactory() 
        {
            _dao = SqlDao.GetInstance();
        }

        public override void Create(BaseDTO baseDTO)
        {
            var user = baseDTO as User;

            var sqlOperation = new SqlOperation { ProcedureName = "CRE_USER" };
            sqlOperation.AddIntParam("U_CEDULA", user.cedula);
            sqlOperation.AddVarcharParam("U_NAME", user.name);
            sqlOperation.AddVarcharParam("U_EMAIL", user.email);
            sqlOperation.AddVarcharParam("U_PASSWORD", user.password);

            _dao.ExecuteProcedure(sqlOperation);
        }

        public override void Update(BaseDTO baseDTO)
        {
            var user = baseDTO as User;

            var sqlOperation = new SqlOperation { ProcedureName = "UP_USER" };
            sqlOperation.AddIntParam("U_CEDULA", user.cedula);
            sqlOperation.AddVarcharParam("U_NAME", user.name);
            sqlOperation.AddVarcharParam("U_EMAIL", user.email);
            sqlOperation.AddVarcharParam("U_PASSWORD", user.password);

            _dao.ExecuteProcedure(sqlOperation);
        }

        public override void Delete(BaseDTO baseDTO)
        {
            var user = baseDTO as User;
            var sqlOperation = new SqlOperation { ProcedureName= "DEL_USERS" };
            sqlOperation.AddIntParam("U_CEDULA", user.cedula);

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
