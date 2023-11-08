using DataAccess;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp
{
    public class AssignmentProductRouteManager
    {
        public void Create(AssignmentProductRoute assignmentProductRoute)
        {
            if (assignmentProductRoute == null)
            {
                throw new ArgumentNullException(nameof(assignmentProductRoute), "AssignmentProductRoute object is required.");
            }

            if (assignmentProductRoute.Route == null)
            {
                throw new ArgumentException("Route is required for the assignment.");
            }

            if (assignmentProductRoute.Product == null)
            {
                throw new ArgumentException("Product is required for the assignment.");
            }

            if (assignmentProductRoute.Route.Id == assignmentProductRoute.Product.Id)
            {
                throw new ArgumentException("Route and Product must have different IDs or unique identifiers.");
            }
            /*var ht = new HistoryCRUDFactory();
            ht.Create(history);*/
        }

        public void Delete(AssignmentProductRoute assignmentProductRoute)
        {
            /*var ct = new HistoryCRUDFactory();
            ct.Delete(history);*/
        }

        public void Update(AssignmentProductRoute assignmentProductRoute)
        {
            /*var ct = new HistoryCRUDFactory();
            ct.Update(history);*/
        }

        public object? RetrieveAll()
        {
            throw new Exception();
            /*var ct = new HistoryCRUDFactory();

            return ct.RetrieveAll<AssignmentProductRoute>();*/
        }
    }
}
