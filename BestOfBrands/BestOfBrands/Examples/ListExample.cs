using System.Collections.Generic;
using System.Linq;
using BestOfBrands.Entitites;
using BestOfBrands.Extensions;

namespace BestOfBrands.Examples
{
    public class ListExample : IListExample
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            var product1 = new Product();
            product1.Name = "Jacka";
            product1.Description = "En jacka i ankdun";
            product1.Price = 299;
        
            var product2 = new Product
            {
                Name = "Tröja",
                Description = "Tröjan har en röd tomte på baksidan",
                Price = 199
            };

            var product3 = new Product
            {
                Name = "Mössa",
                Description = "En bävermössa",
                Price = 799
            };
           
            products.AddMany(product1, product2, product3);

            return products;
        }        

        public double GetTotalPrice()
        {
            return GetProducts().Sum(x => x.Price);
        }
    }
}