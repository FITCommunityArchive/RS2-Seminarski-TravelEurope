using System;
using System.Collections.Generic;

namespace TravelEurope.Model
{
    public partial class Radnik : Korisnici
    {
        public int RadnikId { get; set; }
        public string Pozicija { get; set; }
        public int GodineStaza { get; set; }
        public string ImePrezime { get; set; }

        public override string ToString()
        {
            return ImePrezime.ToString();
        }
    }
}
