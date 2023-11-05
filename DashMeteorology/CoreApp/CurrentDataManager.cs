using DataAccess;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp
{
    public class CurrentDataManager
    {

        public void Create(CurrentDataDTO currentData) 
        {
            if(currentData.Temperature < -90 || currentData.Temperature > 60)
            {
                throw new Exception("La temperatura debe estar entre -90 y 60 grados.");
            }
            if(currentData.Humidity < 0 || currentData.Humidity > 100)
            {
                throw new Exception("La humedad debe estar entre 0 y 100 por ciento");
            }
            var allowedCondition = new List<string> {"Soleado", "Nublado", "Lluvioso" };
            if (!allowedCondition.Contains(currentData.Condition))
            {
                throw new Exception("La condicion ingresada no es valida.");
            }
            if(currentData.WindSpeed < 0 || currentData.WindSpeed > 300)
            {
                throw new Exception("La velocidad del viento debe estar entre 0 y 300 km/h.");
            }

            var cd = new CurrentDataCRUDFactory();
            cd.Create(currentData);
        }

        public void Delete(CurrentDataDTO currentData) 
        {
            if(currentData.DataId == null)
            {
                throw new Exception("El id no puede ser null");
            }
            var cd = new CurrentDataCRUDFactory();
            cd.Delete(currentData);
        }
        public void Update(CurrentDataDTO currentData)
        {
            var cd = new CurrentDataCRUDFactory();
            cd.Update(currentData);
        }

        public object? RetrieveAll()
        {
            var ct = new CurrentDataCRUDFactory();

            return ct.RetrieveAll<CurrentDataDTO>();
        }





        public bool Exist(int dataId)
        {
            throw new NotImplementedException();
        }



        public Task UpdateAsync(CurrentDataDTO currentData)
        {
            throw new NotImplementedException();
        }
    }
}
