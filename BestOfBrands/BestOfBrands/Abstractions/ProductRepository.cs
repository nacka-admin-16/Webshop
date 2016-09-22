using System;
using System.IO;
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
    }
}