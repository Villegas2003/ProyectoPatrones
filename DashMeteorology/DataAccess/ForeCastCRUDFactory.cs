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
    public class ForeCastCRUDFactory : CrudFactory
    {

        public ForeCastCRUDFactory()
        {
            _dao = SqlDao.GetInstance();
        }

        public override void Create(BaseDTO baseDTO)
        {
            var fore = baseDTO as ForeCastDTO;

            var sqlOperation = new SqlOperation { ProcedureName = "CRE_ForeCast" };
            sqlOperation.AddDateTimeParam("FC_Date", (DateTime)fore.Date);
            sqlOperation.AddFloatParam("FC_MaxTemperature", (float)fore.MaxTemperature);
            sqlOperation.AddFloatParam("FC_MinTemperature", (float)fore.MinTemperature);
            sqlOperation.AddVarcharParam("FC_Condition", fore.Condition);

            _dao.ExecuteProcedure(sqlOperation);
        }
        public override void Delete(BaseDTO baseDTO)
        {
            var fore = baseDTO as ForeCastDTO;

            var sqlOperation = new SqlOperation { ProcedureName = "DEL_ForeCast" };
            sqlOperation.AddIntParam("FC_ForeCastId", fore.ForeCastId);
            _dao.ExecuteProcedure(sqlOperation);
        }

        public override void Update(BaseDTO baseDTO)
        {
            var fore = baseDTO as ForeCastDTO;

            var sqlOperation = new SqlOperation { ProcedureName = "UPD_FORECAST" };
            sqlOperation.AddIntParam("FC_ForeCastId", fore.ForeCastId);
            sqlOperation.AddDateTimeParam("FC_Date", (DateTime)fore.Date);
            sqlOperation.AddFloatParam("FC_MaxTemperature", (float)fore.MaxTemperature);
            sqlOperation.AddFloatParam("FC_MinTemperature", (float)fore.MinTemperature);
            sqlOperation.AddVarcharParam("FC_Condition", fore.Condition);

            _dao.ExecuteProcedure(sqlOperation);
        }

        public override T Retrieve<T>()
        {
            throw new NotImplementedException();
        }



        public override List<T> RetrieveAll<T>()
        {
            var lstFore = new List<T>();

            var sqlOperation = new SqlOperation { ProcedureName = "RET_ALL_FORE" };

            //Devuelve la lista de diccionarios
            var lstResults = _dao.ExecuteQueryProcedure(sqlOperation);

            if (lstResults.Count > 0)
            {
                foreach (var row in lstResults)
                {
                    var foreDTO = BuildFore<T>(row);
                    lstFore.Add(foreDTO);
                }
            }

            return lstFore;
        }

        private T BuildFore<T>(Dictionary<string, object> row)
        {
            var foreDTO = new ForeCastDTO()
            {
                Id = (int)row["ForecastId"],
                CityId = (int)row["CityId"],
                Date = (DateTime)row["Date"],
                MaxTemperature = (float)row["MaxTemperature"],
                MinTemperature = (float)row["MinTemperature"],
                Condition = (string)row["Condition"]
            };
            return (T)Convert.ChangeType(foreDTO, typeof(T));
        }
    }
}
