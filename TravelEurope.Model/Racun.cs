using System;
using System.Collections.Generic;

namespace TravelEurope.Model
{
    public partial class Racun
    {
        public Racun()
        {
            RezervacijaNavigation = new HashSet<Rezervacija>();
        }

        public int RacunId { get; set; }
        public int RezervacijaId { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public int TrajanjeRentanjaDani { get; set; }
        public int NacinPlacanjaId { get; set; }
        public int CijenaUslugeSaPdvom { get; set; }

        public NacinPlacanja NacinPlacanja { get; set; }
        public Rezervacija Rezervacija { get; set; }
        public ICollection<Rezervacija> RezervacijaNavigation { get; set; }
    }
}
