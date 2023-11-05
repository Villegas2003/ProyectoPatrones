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
    public class HistoryCRUDFactory : CrudFactory
    {
        public HistoryCRUDFactory()
        {
            _dao = SqlDao.GetInstance();
        }

        public override void Create(BaseDTO baseDTO)
        {
            var history = baseDTO as HistoryDTO;

            var sqlOperation = new SqlOperation { ProcedureName = "CRE_HISTORY" };
            sqlOperation.AddDateTimeParam("H_Date", (DateTime)history.Date);
            sqlOperation.AddFloatParam("H_MaxTemperature", (float)history.MaxTemperature);
            sqlOperation.AddFloatParam("H_MinTemperature", (float)history.MinTemperature);
            sqlOperation.AddVarcharParam("H_Condition", history.Condition);

            _dao.ExecuteProcedure(sqlOperation);
        }
        public override void Delete(BaseDTO baseDTO)
        {
            var history = baseDTO as HistoryDTO;

            var sqlOperation = new SqlOperation { ProcedureName = "DEL_HISTORY" };
            sqlOperation.AddIntParam("H_HistoryId", history.HistoryId);

            _dao.ExecuteProcedure(sqlOperation);
        }

        public override void Update(BaseDTO baseDTO)
        {
            var history = baseDTO as HistoryDTO;

            var sqlOperation = new SqlOperation { ProcedureName = "UPD_HISTORY" };
            sqlOperation.AddIntParam("H_HistoryId", history.HistoryId);
            sqlOperation.AddDateTimeParam("H_Date", (DateTime)history.Date);
            sqlOperation.AddFloatParam("H_MaxTemperature", (float)history.MaxTemperature);
            sqlOperation.AddFloatParam("H_MinTemperature", (float)history.MinTemperature);
            sqlOperation.AddVarcharParam("H_Condition", history.Condition);

            _dao.ExecuteProcedure(sqlOperation);
        }

        public override T Retrieve<T>()
        {
            throw new NotImplementedException();
        }



        public override List<T> RetrieveAll<T>()
        {
            var lstHistory = new List<T>();

            var sqlOperation = new SqlOperation { ProcedureName = "RET_ALL_HISTORY" };

            //Devuelve la lista de diccionarios
            var lstResults = _dao.ExecuteQueryProcedure(sqlOperation);

            if (lstResults.Count > 0)
            {
                foreach (var row in lstResults)
                {
                    var historyDTO = BuildHistory<T>(row);
                    lstHistory.Add(historyDTO);
                }
            }

            return lstHistory;
        }

        private T BuildHistory<T>(Dictionary<string, object> row)
        {
            var historyDTO = new HistoryDTO()
            {
                Id = (int)row["HistoryId"],
                Date = (DateTime)row["Date"],
                MaxTemperature = (float)row["MaxTemperature"],
                MinTemperature = (float)row["MinTemperature"],
                Condition = (string)row["Condition"]
            };
            return (T)Convert.ChangeType(historyDTO, typeof(T));    
        }
    }
}
