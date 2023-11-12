using DTOs;
using Builder;
using Builder.IBuilder;

namespace Builder.Director
{
    public class Director
    {
        private IBuilderProduct productBuilder;

        public Director(IBuilderProduct productBuilder)
        {
            this.productBuilder = productBuilder;
        }

        public Product CrearProducto(string Name, int Price, string Parts, string Category)
        {
            return productBuilder
                .SetName(Name)
                .SetPrice(Price)
                .SetParts(Parts)
                .SetCategory(Category)
                .Build();
        }
    }
}