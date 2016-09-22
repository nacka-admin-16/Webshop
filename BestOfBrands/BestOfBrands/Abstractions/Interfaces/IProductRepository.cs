using System.Collections.Generic;
using BestOfBrands.Entitites;

namespace BestOfBrands.Abstractions.Interfaces
{
    public interface IProductRepository
    {
        bool CreateProduct(Product product);

        List<Product> GetProducts();
    }
}