 using DataAccess;
using DataAccess.CRUD;
using DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp
{
    public class ProductManager
    {
        private readonly ITarget _productAdapter;
        private ProductCRUDFactory productAdapter;

        public ProductManager(ITarget productAdapter)
        {
            _productAdapter = productAdapter;
        }

        public ProductManager(ProductCRUDFactory productAdapter)
        {
            this.productAdapter = productAdapter;
        }

        public void Create(Product product)
        {
            if(product.Price == null)
            {
                throw new Exception("The price of the product cannot be zero");
            }
            var allowedCondition = new List<string> {"Books", "Technology", "Clothes", "Toys" };
            if (!allowedCondition.Contains(product.Category))
            {
                throw new Exception("The category is incorrect, it must be books, tecnology, clothing or toys");
            }

            var pm = new ProductCRUDFactory();
            pm.Create(product);

        }

        public void Delete(Product product)
        {
            var pm = new ProductCRUDFactory();
            pm.Delete(product);
        }

        public void Update(Product product)
        {
            var pm = new ProductCRUDFactory();
            pm.Update(product);
        }
        public object? RetrieveAll()
        {

            throw new Exception("Hola mundo;)");
            var pm = new ProductCRUDFactory();
            
            return pm.RetrieveAll<Product>();
        }
    }
}
