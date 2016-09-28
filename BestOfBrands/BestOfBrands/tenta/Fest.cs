using System;
using System.Collections.Generic;

namespace BestOfBrands.tenta
{
    public class Fest
    {
        public string Namn { get; set; }

        public string Beskrivning { get; set; }

        public DateTime Starttid { get; set; }

        public DateTime Sluttid { get; set; }

        public double Lokalkostnad { get; set; }

        public string Plats { get; set; }

        public Deltagare Värd { get; set; }

        public List<Deltagare> Deltagare { get; set; } = new List<Deltagare>();

        public Fest(string namn, string beskrivning, DateTime starttid, DateTime sluttid, double lokalkostnad, string plats, Deltagare värd)
        {
            Namn = namn;
            Beskrivning = beskrivning;
            Starttid = starttid;
            Sluttid = sluttid;
            Lokalkostnad = lokalkostnad;
            Plats = plats;
            Värd = värd;
        }

        public void NyDeltagare(Deltagare deltagare)
        {
            Deltagare.Add(deltagare);
        }

        public int AntalDeltagare()
        {
            return Deltagare.Count;
        }
    }
}