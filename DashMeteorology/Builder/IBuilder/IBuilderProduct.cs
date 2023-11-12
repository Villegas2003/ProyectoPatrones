using DTOs;
using Builder;

namespace Builder.IBuilder
{
    public interface IBuilderProduct
    {
        IBuilderProduct SetName(String Name);
        IBuilderProduct SetPrice(int Price);
        IBuilderProduct SetParts(String Parts);
        IBuilderProduct SetCategory(String Category);
        Product Build();
    }
}