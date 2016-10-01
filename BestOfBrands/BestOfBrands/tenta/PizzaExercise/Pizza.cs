using System.Collections.Generic;

namespace BestOfBrands.tenta.PizzaExercise
{
    public class Pizza
    {
        public string Namn { get; set; }

        public int Pris { get; set; }

        public List<Ingrediens> Ingredienser { get; set; } = new List<Ingrediens>();

        public Pizza(string namn, int pris, List<Ingrediens> ingredienser)
        {
            Namn = namn;
            Pris = pris;
            Ingredienser = ingredienser;
        }
    }
}