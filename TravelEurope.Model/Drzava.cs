using System;
using System.Collections.Generic;

namespace TravelEurope.Model
{
    public partial class Drzava
    {
        public int DrzavaId { get; set; }
        public string Naziv { get; set; }
        public override string ToString()
        {
            return Naziv.ToString();
        }
    }
}
