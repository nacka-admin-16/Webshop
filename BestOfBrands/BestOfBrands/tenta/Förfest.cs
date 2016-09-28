using System;

namespace BestOfBrands.tenta
{
    public class Förfest : Fest
    {
        public bool MedtagEgenDryck { get; set; }

        public Förfest(string namn, string beskrivning, DateTime starttid, DateTime sluttid, double lokalkostnad, string plats, Deltagare värd) : base(namn, beskrivning, starttid, sluttid, lokalkostnad, plats, värd)
        {
        }

        public override double Inträde()
        {
            return Lokalkostnad*0.9;
        }
    }
}