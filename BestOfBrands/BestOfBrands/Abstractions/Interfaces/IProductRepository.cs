using System.Collections.Generic;
using BestOfBrands.Abstractions.Entitites;

namespace BestOfBrands.Abstractions.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();

        List<Product> GetAllShirts();
    }
}