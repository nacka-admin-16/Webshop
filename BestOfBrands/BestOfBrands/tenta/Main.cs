using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BestOfBrands.tenta
{
    public class Main
    {
        public void CreateFest()
        {
            //övning 6
            //Fest fest = new Fest();
            //Deltagare deltagare = new Deltagare();

            //fest.Värd = deltagare;

            //övning 7
            var värd = new Deltagare
            {
                Förnamn = "Isabella",
                Efternamn = "Alström",
                Ålder = 25
            };

            var deltagare1 = new Deltagare
            {
                Förnamn = "Carl",
                Efternamn = "Schéle",
                Ålder = 25
            };

            var deltagare2 = new Deltagare
            {
                Förnamn = "Marcus",
                Efternamn = "Hult",
                Ålder = 27
            };

            Fest fest = new Fest("Tentapub", "Vi ska dricka alkohol", new DateTime(2016, 10, 13), new DateTime(2016, 10, 14), 3000, "Humlegården", värd);

            //fest.Deltagare = new List<Deltagare>();

            fest.NyDeltagare(deltagare1);
            fest.NyDeltagare(deltagare2);

            fest.AntalDeltagare();

            
        }
    }
}