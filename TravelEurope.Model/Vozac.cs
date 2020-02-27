using System;
using System.Collections.Generic;

namespace TravelEurope.Model
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

        public override string ToString()
        {
            var atif = Ime + " " + Prezime;
            return atif.ToString();
        }
        public string BrVozackeDozvole { get; set; }
        public int StatusVozacaId { get; set; }

        public StatusVozaca StatusVozaca { get; set; }
        public ICollection<Rezervacija> Rezervacija { get; set; }
    }
}
