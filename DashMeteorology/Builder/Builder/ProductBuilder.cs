using DTOs;
using Builder;
using Builder.IBuilder;

namespace Builder.Builder
{
    public class ProductBuilder : IBuilderProduct
    {
        private Product product = new Product();

        public IBuilderProduct SetName(string Name)
        {
            product.Name = Name;
            return this;
        }

        public IBuilderProduct SetPrice(int Price)
        {
            product.Price = Price;
            return this;
        }

        public IBuilderProduct SetParts(string Parts)
        {
            product.Parts = Parts;
            return this;
        }

        public IBuilderProduct SetCategory(string Category)
        {
            product.Category = Category;
            return this;
        }

        Product IBuilderProduct.Build()
        {
            return product;
        }
    }
}