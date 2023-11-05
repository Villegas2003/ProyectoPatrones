 using DataAccess;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp
{
    public class CitieManager
    {
        public void Create(CitieDTO citie)
        {
            /*if(CityExist(citie.Name, citie.Country)) 
            {
                throw new Exception("La ciudad ya existe en la base de datos.");
            }*/
            if(citie.Latitude < -90 || citie.Latitude > 90)
            {
                throw new Exception("La latitud debe estar en el rango de -90 a 90.");
            }
            if(citie.Longitude < -180 || citie.Longitude > 180)
            {
                throw new Exception("La longitud debe estar en el rango de -180 a 180.");
            }
            if(citie.Latitude == null || citie.Longitude == null)
            {
                throw new Exception("La latitud y longitud no puede ser nula.");
            }

            var ct = new CityCRUDFactory();
            ct.Create(citie);

        }

        public void Delete(CitieDTO citie)
        {
            if(citie.CityId == null)
            {
                throw new Exception("El id no puede ser null");
            }

            var ct = new CityCRUDFactory();
            ct.Delete(citie);
        }

        public void Update(CitieDTO citie)
        {
            var ct = new CityCRUDFactory();
            ct.Update(citie);
        }
        public object? RetrieveAll()
        {
            var ct = new CityCRUDFactory();

            return ct.RetrieveAll<CitieDTO>();
        }
    }
}
