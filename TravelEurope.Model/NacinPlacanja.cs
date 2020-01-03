using System;
using System.Collections.Generic;

namespace TravelEurope.Model
{
    public partial class NacinPlacanja
    {
        public NacinPlacanja()
        {
            Racun = new HashSet<Racun>();
        }

        public int NacinPlacanjaId { get; set; }
        public string Naziv { get; set; }

        public ICollection<Racun> Racun { get; set; }
    }
}
