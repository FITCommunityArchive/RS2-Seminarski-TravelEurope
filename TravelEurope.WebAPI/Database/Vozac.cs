using System;
using System.Collections.Generic;

namespace TravelEurope.WebAPI.Database
{
    public partial class Vozac
    {
        public Vozac()
        {
            Rezervacija = new HashSet<Rezervacija>();
        }

        public int VozacId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrVozackeDozvole { get; set; }
        public int StatusVozacaId { get; set; }

        public StatusVozaca StatusVozaca { get; set; }
        public ICollection<Rezervacija> Rezervacija { get; set; }
    }
}
