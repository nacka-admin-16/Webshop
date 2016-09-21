using System;
using System.Collections.Generic;
using BestOfBrands.Abstractions.Entitites;
using BestOfBrands.Abstractions.Interfaces;

namespace BestOfBrands.Abstractions
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllShirts()
        {
            throw new NotImplementedException();
        }
    }
}