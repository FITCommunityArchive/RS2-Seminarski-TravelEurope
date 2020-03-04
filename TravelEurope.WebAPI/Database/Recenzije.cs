using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Database
{
    public class Recenzije
    {
        [Key]
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
