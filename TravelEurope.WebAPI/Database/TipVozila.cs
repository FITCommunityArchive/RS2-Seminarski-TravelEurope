using System;
using System.Collections.Generic;

namespace TravelEurope.WebAPI.Database
{
    public partial class TipVozila
    {
        public int TipId { get; set; }
        public string Naziv { get; set; }
        public IEnumerable<Vozilo> Vozilo { get; internal set; }

        public override string ToString()
        {
            return Naziv.ToString();
        }
    }
}
