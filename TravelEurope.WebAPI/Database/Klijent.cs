using System;
using System.Collections.Generic;

namespace TravelEurope.WebAPI.Database
{
    public partial class Klijent
    {
        public Klijent()
        {
            Rezervacija = new HashSet<Rezervacija>();
        }

        public int KlijentId { get; set; }
        public string BrojPasosa { get; set; }
        public string BrVozackeDozvole { get; set; }

        public Korisnici KlijentNavigation { get; set; }
        public ICollection<Rezervacija> Rezervacija { get; set; }
    }
}
