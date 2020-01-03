using System;
using System.Collections.Generic;

namespace TravelEurope.Model
{
    public partial class MarkaVozila
    {
        public MarkaVozila()
        {
            Vozilo = new HashSet<Vozilo>();
        }

        public int MarkaId { get; set; }
        public string Naziv { get; set; }

        public ICollection<Vozilo> Vozilo { get; set; }
    }
}
