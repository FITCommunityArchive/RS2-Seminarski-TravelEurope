using System;
using System.Collections.Generic;

namespace TravelEurope.Model
{
    public partial class Grad
    {
        public int GradId { get; set; }
        public string Naziv { get; set; }
        public int DrzavaId { get; set; }

        public Drzava Drzava { get; set; }
    }
}
