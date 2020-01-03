using System;
using System.Collections.Generic;

namespace TravelEurope.Model
{
    public partial class StatusVozaca
    {
        public StatusVozaca()
        {
            Vozac = new HashSet<Vozac>();
        }

        public int StatusVozacaId { get; set; }
        public bool Dostupan { get; set; }

        public ICollection<Vozac> Vozac { get; set; }
    }
}
