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
    public class CurrentDataCRUDFactory : CrudFactory
    {

        public CurrentDataCRUDFactory()
        {
            _dao = SqlDao.GetInstance();
        }

        public override void Create(BaseDTO baseDTO)
        {
            var current = baseDTO as CurrentDataDTO;

            var sqlOperation = new SqlOperation { ProcedureName = "CRE_CURRENTDATA" };
            sqlOperation.AddDateTimeParam("CD_TimeStamp", (DateTime)current.TimeStamp);
            sqlOperation.AddFloatParam("CD_Temperature", (float)current.Temperature);
            sqlOperation.AddIntParam("CD_Humidity", (int)current.Humidity);
            sqlOperation.AddVarcharParam("CD_Condition", current.Condition);
            sqlOperation.AddFloatParam("CD_WindSpeed", (float)current.WindSpeed);

            _dao.ExecuteProcedure(sqlOperation);
        }

        public override void Delete(BaseDTO baseDTO)
        {
            var current = baseDTO as CurrentDataDTO;

            var sqlOperation = new SqlOperation { ProcedureName = "DEL_CURRENTDATA" };
            sqlOperation.AddIntParam("CD_DataId", current.DataId);

            _dao.ExecuteProcedure(sqlOperation);
        }

        public override void Update(BaseDTO baseDTO)
        {
            var current = baseDTO as CurrentDataDTO;

            var sqlOperation = new SqlOperation { ProcedureName = "UP_CURRENTDATA" };
            sqlOperation.AddIntParam("CD_DataId", current.DataId);
            sqlOperation.AddDateTimeParam("CD_TimeStamp", (DateTime)current.TimeStamp);
            sqlOperation.AddFloatParam("CD_Temperature", (float)current.Temperature);
            sqlOperation.AddIntParam("CD_Condition", (int)current.Humidity);
            sqlOperation.AddFloatParam("CD_WindSpeed", (float)current.WindSpeed);
        }

        public override T Retrieve<T>()
        {
            throw new NotImplementedException();
        }



        public override List<T> RetrieveAll<T>()
        {
            var lstCurrentData = new List<T>();

            var sqlOperation = new SqlOperation { ProcedureName = "RET_ALL_CURRENT" };

            //Devuelve la lista de diccionarios
            var lstResults = _dao.ExecuteQueryProcedure(sqlOperation);

            if (lstResults.Count > 0)
            {
                foreach (var row in lstResults)
                {
                    var currentDTO = BuildCurrent<T>(row);
                    lstCurrentData.Add(currentDTO);
                }
            }

            return lstCurrentData;
        }

        private T BuildCurrent<T>(Dictionary<string, object> row)
        {
            var currentDTO = new CurrentDataDTO()
            {
                Id = (int)row["DataId"],
                TimeStamp = (DateTime)row["TimeStamp"],
                Temperature = (float)row["Temperature"],
                Humidity = (int)row["Humidity"],
                Condition = (string)row["Condition"],
                WindSpeed = (float)row["WindSpeed"]
            };
            return (T)Convert.ChangeType(currentDTO, typeof(T));
        }
    }
}
