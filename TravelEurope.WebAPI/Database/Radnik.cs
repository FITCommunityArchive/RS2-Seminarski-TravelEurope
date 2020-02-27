using System;
using System.Collections.Generic;

namespace TravelEurope.WebAPI.Database
{
    public partial class Radnik
    {
        public Radnik()
        {
            Rezervacija = new HashSet<Rezervacija>();
        }

        public int RadnikId { get; set; }
        public string Pozicija { get; set; }
        public int GodineStaza { get; set; }

        public Korisnici RadnikNavigation { get; set; }
        public ICollection<Rezervacija> Rezervacija { get; set; }
    }
}