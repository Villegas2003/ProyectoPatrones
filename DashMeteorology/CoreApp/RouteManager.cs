using DataAccess;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace CoreApp
{
    public class RouteManager
    {

        public void Create(Route route)
        {
            if (string.IsNullOrWhiteSpace(route.Name))
            {
                throw new ArgumentException("Route name is required.");
            }

            if (string.IsNullOrWhiteSpace(route.Distance))
            {
                throw new ArgumentException("Route distance is required.");
            }

            if (!Regex.IsMatch(route.Distance, @"^\d+(\.\d{1,2})?$"))
            {
                throw new ArgumentException("Distance must be a valid number with up to 2 decimal places.");
            }

            if (string.IsNullOrWhiteSpace(route.TransportUnit))
            {
                throw new ArgumentException("Transport unit is required.");
            }

            if (string.IsNullOrWhiteSpace(route.Startpoint))
            {
                throw new ArgumentException("Starting point is required.");
            }

            if (string.IsNullOrWhiteSpace(route.Finalpoint))
            {
                throw new ArgumentException("Final point is required.");
            }
            /*var fc = new ForeCastCRUDFactory();
            fc.Create(foreCast);*/
        }

        public void Delete(Route route)
        {
            /*var fc = new ForeCastCRUDFactory();
            fc.Delete(foreCast);*/
        }

        public void Update(Route route)
        {
            /*var fc = new ForeCastCRUDFactory();
            fc.Update(foreCast);*/
        }

        public object? RetrieveAll()
        {
            throw new Exception();
           /* var ct = new ForeCastCRUDFactory();
            return ct.RetrieveAll<Route>();*/
        }

    }
}
