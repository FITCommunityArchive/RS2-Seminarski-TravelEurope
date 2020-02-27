using System;
using System.Collections.Generic;

namespace TravelEurope.Model
{
    public partial class Klijent
    {
        public int KlijentId { get; set; }
        public string BrojPasosa { get; set; }
        public string BrVozackeDozvole { get; set; }
        public string ImePrezime { get; set; }
        public override string ToString()
        {
            return (ImePrezime).ToString();
        }
    }
}
