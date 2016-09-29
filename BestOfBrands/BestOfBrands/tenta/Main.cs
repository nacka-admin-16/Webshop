using System;

namespace BestOfBrands.tenta
{
    public class Main
    {
        //6.
        //Skapa en klass Fest som har egenskaperna(properties) Namn, Beskrivning, Starttid, Sluttid, Lokalkostnad och Plats.
        //Skapa ytterligare en klass Deltagare med egenskaperna Förnamn, Efternamn samt Ålder.
        //Lägg sedan till ytterligare en egenskap (property) som du döper till Värd i din Fest-klass.
        //Den skall vara av typen Deltagare. Skapa slutligen kod som instansierar en ny Fest och en ny Deltagare och lägger Deltagaren som värd till festen.

        //7.
        //Skapa en konstruktor till din Fest-klass. Den skall ta emot inparametrar och sätta värden på samtliga klassens egenskaper (properties)
        //vid instansiering. Lägg också till en ny egenskap som heter Deltagare som är en lista av deltagare som kommer att delta på Festen.
        //Skapa också en metod för att lägga till en ny Deltagare som deltagare på festen. Skapa dessutom en metod AntalDeltagare, som returnerar en siffra på antalet deltagare på festen.
        //Skapa slutligen kod som instansierar två Deltagare och lägger dem som Deltagare på din fest. Skapa även kod som skriver ut en siffra på antalet deltagare på festen.

        //8.
        //Gör din Fest-klass till en klass som bara kan ärvas.Lägg även till en abstrakt metod Inträde. Skapa sedan två subklasser som ärver från din Fest: Halloweenfest (med boolska egenskapen Utklädnad) och Förfest(med boolska egenskapen MedtagEgenDryck).
        //Implementera metoden Inträde i respektive subklass.För Halloweenfest skall inträdet vara 15 % pålägg på lokalkostnaden och för Förfest skall det vara 10 % mindre än lokalkostnaden.
        //Skapa slutligen kod som instansierar en Halloweenfest och en Förfest, samt två Deltagare som sätts som deltagare på respektive fest. Skapa även kod som sätter lokalkostnaden och räknar ut inträdesavgiften för respektive fest.

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