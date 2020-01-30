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
        public override string ToString()
        {
            return Naziv.ToString();
        }
        public ICollection<Vozilo> Vozilo { get; set; }
    }
}
