using System;
using System.Collections.Generic;

namespace TravelEurope.Model
{
    public partial class StatusVozaca
    {
        public int StatusVozacaId { get; set; }
        public bool Dostupan { get; set; }
        public override string ToString()
        {
            return Dostupan.ToString();
        }
    }
}
