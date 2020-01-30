using System;
using System.Collections.Generic;

namespace TravelEurope.WebAPI.Database
{
    public partial class RuteKategorije
    {
        public int RuteKategorijeId { get; set; }

        public int KategorijaId { get; set; }
        public Kategorija Kategorija { get; set; }

        public int TuristRutaId { get; set; }
        public TuristRuta TuristRuta { get; set; }
    }
}