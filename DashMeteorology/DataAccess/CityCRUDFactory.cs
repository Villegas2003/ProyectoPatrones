using DataAccess.CRUD;
using DataAccess.DAOs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace DataAccess
{
    public class CityCRUDFactory : CrudFactory
    {
        public CityCRUDFactory() 
        {
            _dao = SqlDao.GetInstance();
        }

        public override void Create(BaseDTO baseDTO)
        {
            var citie = baseDTO as CitieDTO;

            var sqlOperation = new SqlOperation { ProcedureName = "CRE_CITY" };
            sqlOperation.AddVarcharParam("C_Name", citie.Name);
            sqlOperation.AddVarcharParam("C_COUNTRY", citie.Country);
            sqlOperation.AddFloatParam("C_LATITUDE", (float)citie.Latitude);
            sqlOperation.AddFloatParam("C_LONGITUDE", (float)citie.Longitude);

            _dao.ExecuteProcedure(sqlOperation);
        }
        public override void Delete(BaseDTO baseDTO)
        {
            var citie = baseDTO as CitieDTO;

            var sqlOperation = new SqlOperation { ProcedureName = "DEL_CITY" };
            sqlOperation.AddIntParam("C_CityId", citie.Id);

            _dao.ExecuteProcedure(sqlOperation);
        }

        public override T Retrieve<T>()
        {
            throw new NotImplementedException();
        }

        public override void Update(BaseDTO baseDTO)
        {
            var citie = baseDTO as CitieDTO;

            var sqlOperation = new SqlOperation { ProcedureName = "UP_CITY" };
            sqlOperation.AddIntParam("C_CityId", citie.Id);
            sqlOperation.AddVarcharParam("C_Name", citie.Name);
            sqlOperation.AddVarcharParam("C_COUNTRY", citie.Country);
            sqlOperation.AddFloatParam("C_LATITUDE", (float)citie.Latitude);
            sqlOperation.AddFloatParam("C_LONGITUDE", (float)citie.Longitude);

            _dao.ExecuteProcedure(sqlOperation);
        }


        public override List<T> RetrieveAll<T>()
        {
            var lstCities = new List<T>();

            var sqlOperation = new SqlOperation { ProcedureName = "RET_ALL_CITY" };

            //Devuelve la lista de diccionarios
            var lstResults = _dao.ExecuteQueryProcedure(sqlOperation);

            if (lstResults.Count > 0)
            {
                foreach (var row in lstResults)
                {
                    var cityDTO = BuildCity<T>(row);
                    lstCities.Add((T)Convert.ChangeType(cityDTO, typeof(T)));
                }
            }

            return lstCities;
        }
        private T BuildCity<T>(Dictionary<string, object> row)
        {

            var cityDTO = new CitieDTO()
            {
                Id = (int)row["CityId"],
                Name = (string)row["Name"],
                Country = (string)row["COUNTRY"],
                Latitude = (float)row["LATITUDE"],
                Longitude = (float)row["LONGITUDE"]
            };
            return (T)Convert.ChangeType(cityDTO, typeof(T));
        }
    }
}

