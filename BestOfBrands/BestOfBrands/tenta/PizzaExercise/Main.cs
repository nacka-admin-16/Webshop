using System.Collections.Generic;
using System.Linq;

namespace BestOfBrands.tenta.PizzaExercise
{
    public class Main
    {
        public int GetPriceOfOrder()
        {
            var ingredienserFörVesuvio = new List<Ingrediens>
            {
                new Ingrediens { Namn = "ost" },
                new Ingrediens { Namn = "tomat" },
                new Ingrediens { Namn = "skinka" }
            };

            var vesuvio = new Pizza("Vesuvio", 70, ingredienserFörVesuvio);

            var ingredienserFörCapriciossa = new List<Ingrediens>
            {
                new Ingrediens { Namn = "ost" },
                new Ingrediens { Namn = "tomat" },
                new Ingrediens { Namn = "skinka" },
                new Ingrediens { Namn = "champinjoner" }
            };
  
            var capriciossa = new Pizza("Capriciossa", 75, ingredienserFörCapriciossa);

            var order = new Order();
            order.Pizzas.Add(vesuvio);
            order.Pizzas.Add(capriciossa);

            var pris = order.Pizzas.Sum(pizza => pizza.Pris);

            return pris;
        }
    }
}