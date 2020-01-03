using System;
using System.Collections.Generic;

namespace TravelEurope.Model
{
    public partial class VrstaGoriva
    {
        public VrstaGoriva()
        {
            Vozilo = new HashSet<Vozilo>();
        }

        public int GorivoId { get; set; }
        public string Naziv { get; set; }

        public ICollection<Vozilo> Vozilo { get; set; }
    }
}
