using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp
{
    public class RouteManagerOpc
    {
        public void Create(RouteOpc route)
        {
            if (route.Price <= 0)
            {
                throw new Exception("The price of the product cannot be zero");
            }
            
            if (route.Approved)
            {
                throw new Exception("Product approval is denied");
            }

            if (route.Distance <= 0)
            {
                throw new Exception("The distance cannot be zero");
            }

            /*var ct = new ProductCRUDFactory();
            ct.Create(product);*/
        }

        public void Delete(RouteOpc route)
        {
            //Cambiar CRUDFACTORY
            /*var ct = new ProductCRUDFactory();
            ct.Delete(product);*/
        }
        public void Update(RouteOpc route)
        {
            //Cambiar CRUDFACTORY
            /*var ct = new ProductCRUDFactory();
            ct.Update(product);*/
        }
        public void RetrieveAll()
        {
            //Cambiar CRUDFACTORY
            throw new Exception("Hola mundo;)");
            /*var ct = new ProductCRUDFactory();
            
            return ct.RetrieveAll<Product>();*/
        }
    }
}
