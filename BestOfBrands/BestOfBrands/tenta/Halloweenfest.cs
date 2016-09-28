using System;

namespace BestOfBrands.tenta
{
    public class Halloweenfest : Fest
    {
        public bool Utklädnad { get; set; }

        public Halloweenfest(string namn, string beskrivning, DateTime starttid, DateTime sluttid, double lokalkostnad, string plats, Deltagare värd): base(namn, beskrivning, starttid, sluttid, lokalkostnad, plats, värd)
        {
        }

        public override double Inträde()
        {
            return Lokalkostnad * 1.15;
        }
    }
}