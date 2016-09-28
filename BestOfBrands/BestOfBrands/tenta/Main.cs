using System;

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
            //Fest fest = new Fest("Tentapub", "Vi ska dricka alkohol", new DateTime(2016, 10, 13), new DateTime(2016, 10, 14), 3000, "Humlegården", värd);

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

            //övning 8
            Förfest förfest = new Förfest("Förfest", "Vi ska dricka alkohol", new DateTime(2016, 10, 13), new DateTime(2016, 10, 14), 3000, "Humlegården", värd);
            förfest.NyDeltagare(deltagare1);
            förfest.NyDeltagare(deltagare2);
            förfest.Inträde();

            Halloweenfest halloweenfest = new Halloweenfest("Halloween", "Vi ska dricka alkohol", new DateTime(2016, 10, 13), new DateTime(2016, 10, 14), 30000, "Humlegården", värd);
            halloweenfest.NyDeltagare(deltagare1);
            halloweenfest.NyDeltagare(deltagare2);
            halloweenfest.Inträde();            
        }
    }
}