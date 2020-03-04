using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.Model
{
    public class Recenzije
    {
        public int RecenzijaId { get; set; }

        public Korisnici Korisnik { get; set; }
        public int KorisnikId { get; set; }

        public TuristRute TuristRuta { get; set; }
        public int TuristRutaId { get; set; }

        public int Ocjena { get; set; }
        public DateTime DatumRecenzije { get; set; }
        public string Sadrzaj { get; set; }

    }
}
