using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Database
{
    public class Ocjene
    {
        [Key]
        public int OcjenaId { get; set; }
        
        public Korisnici Korisnik { get; set; }
        public int KorisnikId { get; set; }

        public TuristRute TuristRuta { get; set; }
        public int TuristRutaId { get; set; }

        public int Ocjena { get; set; }
        public DateTime DatumOcjene { get; set; }
        public string Komentar { get; set; }
    }
}
