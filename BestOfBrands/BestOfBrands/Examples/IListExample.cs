using System.Collections.Generic;
using BestOfBrands.Entitites;

namespace BestOfBrands.Examples
{
    public interface IListExample
    {
        List<Product> GetProducts();

        double GetTotalPrice();
    }
}
