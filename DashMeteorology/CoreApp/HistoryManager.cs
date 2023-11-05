using DataAccess;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp
{
    public class HistoryManager
    {
        public void Create(HistoryDTO history) 
        {
            var ht = new HistoryCRUDFactory();
            ht.Create(history);
        }

        public void Delete(HistoryDTO history)
        {
            if (history.HistoryId == null)
            {
                throw new Exception("El id no puede ser null");
            }

            var ct = new HistoryCRUDFactory();
            ct.Delete(history);
        }

        public void Update(HistoryDTO history)
        {
            if (history.HistoryId == null)
            {
                throw new Exception("El id no puede ser null");
            }

            var ct = new HistoryCRUDFactory();
            ct.Update(history);
        }

        public object? RetrieveAll()
        {
            var ct = new HistoryCRUDFactory();

            return ct.RetrieveAll<HistoryDTO>();
        }
    }
}
