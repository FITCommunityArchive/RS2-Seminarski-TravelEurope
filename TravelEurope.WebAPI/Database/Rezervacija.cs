using System;
using System.Collections.Generic;

namespace TravelEurope.WebAPI.Database
{
    public partial class Rezervacija
    {
        public Rezervacija()
        {
            Racun = new HashSet<Racun>();
        }

        public int RezervacijaId { get; set; }
        public DateTime DatumPreuzimanja { get; set; }
        public DateTime DatumVracanja { get; set; }
        public double CijenaUslugePoDanu { get; set; }
        public double CijenaOsiguranja { get; set; }
        public int KlijentId { get; set; }
        public int RadnikId { get; set; }
        public int? VozacId { get; set; }
        public int? VoziloId { get; set; }
        public int? TuristRutaId { get; set; }
        public int? RacunId { get; set; }

        public Klijent Klijent { get; set; }
        public Radnik Radnik { get; set; }
        public TuristRuta TuristRuta { get; set; }
        public Vozac Vozac { get; set; }
        public Vozilo Vozilo { get; set; }

        public Racun RacunNavigation { get; set; }
        public ICollection<Racun> Racun { get; set; }
    }
}