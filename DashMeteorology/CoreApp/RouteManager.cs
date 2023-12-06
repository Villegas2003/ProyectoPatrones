using DataAccess;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using DataAccess.CRUD;

namespace CoreApp
{
    public class RouteManager
    {
        private readonly ITarget _routeAdapter;
        private RouteCRUDFactory routeAdapter;

        public RouteManager(ITarget routeAdapter)
        {
            _routeAdapter = routeAdapter;
        }

        public RouteManager(RouteCRUDFactory routeAdapter)
        {
            this.routeAdapter = routeAdapter;
        }

        public void Create(Route route)
        {
            if (route.Origin == null)
            {
                throw new ArgumentException("Route origin is required.");
            }

            if (route.Distance == null)
            {
                throw new ArgumentException("Route distance is required.");
            }

            if (!Regex.IsMatch(route.Distance, @"^\d+(\.\d{1,2})?$"))
            {
                throw new ArgumentException("Distance must be a valid number with up to 2 decimal places.");
            }

            if (route.TransportUnit == null)
            {
                throw new ArgumentException("Transport unit is required.");
            }

            if (route.Startpoint == null)
            {
                throw new ArgumentException("Starting point is required.");
            }

            if (route.Finalpoint == null)
            {
                throw new ArgumentException("Final point is required.");
            }
            var rm = new RouteCRUDFactory();
            rm.Create(route);
        }

        public void Delete(Route route)
        {
            if (route.Id == null)
            {
                throw new Exception("The Id cannot be null");
            }
            var rm = new RouteCRUDFactory();
            rm.Delete(route);
        }

        public void Update(Route route)
        {
            if (route.Id == null)
            {
                throw new Exception("The Id cannot be null");
            }
            var rm = new RouteCRUDFactory();
            rm.Update(route);
        }

        public object? RetrieveAll()
        {
            throw new Exception();
           /* var ct = new ForeCastCRUDFactory();
            return ct.RetrieveAll<Route>();*/
        }

    }
}
