using System;

namespace BestOfBrands.tenta.Arv
{
    public abstract class BasePage
    {
        public string Rubrik { get; set; }

        public string Ingress { get; set; }
       
        public Guid SidId
        {
            get { return Guid.NewGuid(); }            
        }
    }
}