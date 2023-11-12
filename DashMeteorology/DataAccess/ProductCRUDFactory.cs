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
    public class ProductCRUDFactory : CrudFactory
    {

        public ProductCRUDFactory()
        {
            _dao = SqlDao.GetInstance();
        }

        public override void Create(BaseDTO baseDTO)
        {
            var product = baseDTO as Product;

            var sqlOperation = new SqlOperation { ProcedureName = "CRE_PRODUCT" };
            sqlOperation.AddVarcharParam("P_NAME", product.Name);
            sqlOperation.AddIntParam("P_PRICE", product.Price);
            sqlOperation.AddVarcharParam("P_PARTS", product.Parts);
            sqlOperation.AddVarcharParam("P_CATEGORY", product.Category);

            _dao.ExecuteProcedure(sqlOperation);

        }
        public override void Update(BaseDTO baseDTO)
        {
            var product = baseDTO as Product;

            var sqlOperation = new SqlOperation { ProcedureName = "UP_PRODUCT" };
            sqlOperation.AddIntParam("P_IdProduct", product.Id);
            sqlOperation.AddVarcharParam("P_NAME", product.Name);
            sqlOperation.AddIntParam("P_PRICE", product.Price);
            sqlOperation.AddVarcharParam("P_PARTS", product.Parts);
            sqlOperation.AddVarcharParam("P_CATEGORY", product.Category);

            _dao.ExecuteProcedure(sqlOperation);

        }

        public override void Delete(BaseDTO baseDTO)
        {
            var product = baseDTO as Product;

            var sqlOperation = new SqlOperation { ProcedureName = "DELETE_PRODUCT" };
            sqlOperation.AddIntParam("P_IdProduct", product.Id);

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
