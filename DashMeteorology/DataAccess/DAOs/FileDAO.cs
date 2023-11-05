using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{

    //Data Acces Object: Escriba en un arrchivo de texto
    public class FileDAO
    {
        private string _filePath;

        public FileDAO(string fileName)
        {
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName + ".txt");

            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
            }
        }
        //Guarda un objeto en un archivo de texto

        public void SaveObject(object obj)
        {
            //Convertir el objeto a formato JSON
            string jsonUser = JsonConvert.SerializeObject(obj);

            //Escribir el objeto JSON en el archivo de texto
            using (StreamWriter file = File.AppendText(_filePath))
            {
                file.WriteLine(jsonUser);
            }
        }

        public List<T> RetrieveAll<T>()
        {

            var lst = new List<T>();

            //Leer todas las líneas del archivo de tecto
            string[] lineas = File.ReadAllLines(_filePath);

            foreach (string linea in lineas)
            {

                //Deserializar cada linea en u objeto correspondiente 
                var obj = JsonConvert.DeserializeObject<T>(linea);

                //Agregar el objeto a la lista
                lst.Add(obj);
            }

            return lst;
        }

    }
}
