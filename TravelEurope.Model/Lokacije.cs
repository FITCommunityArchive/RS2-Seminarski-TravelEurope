using System;
using System.Collections.Generic;

namespace TravelEurope.Model
{
    public partial class Lokacije
    {
        public int LokacijaId { get; set; }
        public string Naziv { get; set; }
        public int DrzavaId { get; set; }
        public Drzave Drzava { get; set; }
    }
}
