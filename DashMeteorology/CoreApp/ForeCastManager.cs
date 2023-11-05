using DataAccess;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp
{
    public class ForeCastManager
    {
        public void Create(ForeCastDTO foreCast)
        {
            if(foreCast.MinTemperature < -90)
            {
                throw new Exception("La temepratura minma no puede ser menor a 90.");
            }
            if(foreCast.MaxTemperature > 60)
            {
                throw new Exception("La temperatura no puede ser superior a 60 grados.");
            }

            var allowedCondition = new List<string> {"Soleado", "Nublado", "Lluvioso"};
            if(!allowedCondition.Contains(foreCast.Condition)) 
            {
                throw new Exception("La condicion no es valida.");
            }

            var fc = new ForeCastCRUDFactory();
            fc.Create(foreCast);
        }

        public void Delete(ForeCastDTO foreCast)
        {
            if(foreCast.ForeCastId == null)
            {
                throw new Exception("El id no puede ser null.");
            }
            var fc = new ForeCastCRUDFactory();
            fc.Delete(foreCast);
        }

        public void Update(ForeCastDTO foreCast)
        {
            if (foreCast.ForeCastId == null)
            {
                throw new Exception("El id no puede ser null.");
            }
            var fc = new ForeCastCRUDFactory();
            fc.Update(foreCast);
        }

        public object? RetrieveAll()
        {
            var ct = new ForeCastCRUDFactory();
            return ct.RetrieveAll<ForeCastDTO>();
        }

        public bool Exist(int foreCastId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ForeCastDTO foreCast)
        {
            throw new NotImplementedException();
        }
    }
}
