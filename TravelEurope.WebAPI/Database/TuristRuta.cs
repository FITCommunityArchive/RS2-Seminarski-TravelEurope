using System;
using System.Collections.Generic;

namespace TravelEurope.WebAPI.Database
{
    public partial class TuristRuta
    {
        public TuristRuta()
        {
            Rezervacija = new HashSet<Rezervacija>();
        }

        public int TuristRutaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int TuristickiVodicId { get; set; }
        public int DrzavaId { get; set; }

        public Drzava Drzava { get; set; }
        public TuristickiVodic TuristickiVodic { get; set; }
        public ICollection<Rezervacija> Rezervacija { get; set; }
    }
}