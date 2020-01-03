using System;
using System.Collections.Generic;

namespace TravelEurope.Model
{
    public partial class StatusVozila
    {
        public StatusVozila()
        {
            Vozilo = new HashSet<Vozilo>();
        }

        public int StatusVozilaId { get; set; }
        public string Status { get; set; }
        public bool Ispravnost { get; set; }
        public bool Rezervisano { get; set; }

        public ICollection<Vozilo> Vozilo { get; set; }
    }
}
