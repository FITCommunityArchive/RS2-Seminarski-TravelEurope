using System;
using System.Collections.Generic;

namespace TravelEurope.WebAPI.Database
{
    public partial class TipVozila
    {
        public TipVozila()
        {
            Vozilo = new HashSet<Vozilo>();
        }

        public int TipId { get; set; }
        public string Naziv { get; set; }

        public ICollection<Vozilo> Vozilo { get; set; }
    }
}
