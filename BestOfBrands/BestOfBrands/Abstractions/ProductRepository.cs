using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using BestOfBrands.Abstractions.Interfaces;
using BestOfBrands.Configuration;
using BestOfBrands.Entitites;

namespace BestOfBrands.Abstractions
{
    public class ProductRepository : IProductRepository
    {
        public bool CreateProduct(Product item)
        {
            try
            {
                if (File.Exists(SiteConstants.PathToProductsXml()))
                {
                    var xDocument = XDocument.Load(SiteConstants.PathToProductsXml());
                    var product = xDocument.Element("Products");

                    if (product != null)
                    {
                        product.Add(new XElement("Product",
                            new XElement("Name", item.Name),
                            new XElement("Description", item.Description),
                            new XElement("Price", item.Price)));
                        
                        xDocument.Save(SiteConstants.PathToProductsXml());                        
                    }
                }
                else
                {
                    var product =
                        new XElement("Products",
                            new XElement("Product",
                                new XElement("Name", item.Name),
                                new XElement("Description", item.Description),
                                new XElement("Price", item.Price)));

                    using (var streamWriter = new StreamWriter(SiteConstants.PathToProductsXml(), true))
                    {
                        product.Save(streamWriter);
                    }
                }
               
                return true;
            }
            catch (Exception exception)
            {
                using (var streamWriter = new StreamWriter(SiteConstants.PathToExceptionLog(), true))
                {
                    streamWriter.WriteLine(DateTime.Now + " " + exception.Message);
                }

                return false;
            }
        }

        public List<Product> GetProducts()
        {
            try
            {
                var products = new List<Product>();
                var document = XDocument.Load(SiteConstants.PathToProductsXml());
                var elements = from i in document.Descendants("Product")
                               select new
                               {
                                    Name = i.Element("Name").Value,
                                    Description = i.Element("Description").Value,
                                    Price = i.Element("Price").Value
                               };

                foreach (var product in elements)
                {
                    var p = new Product
                    {
                        Name = product.Name,
                        Description = product.Description,
                        Price = Convert.ToDouble(product.Price)
                    };

                    products.Add(p);
                }

                return products;
            }
            catch (Exception exception)
            {
                using (var streamWriter = new StreamWriter(SiteConstants.PathToExceptionLog(), true))
                {
                    streamWriter.WriteLine(DateTime.Now + " " + exception.Message);
                }

                return new List<Product>();
            }            
        }
    }
}