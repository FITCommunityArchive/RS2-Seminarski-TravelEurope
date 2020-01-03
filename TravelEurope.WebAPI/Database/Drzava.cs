using System;
using System.Collections.Generic;

namespace TravelEurope.WebAPI.Database
{
    public partial class Drzava
    {
        public Drzava()
        {
            Grad = new HashSet<Grad>();
            Lokacija = new HashSet<Lokacija>();
            TuristRuta = new HashSet<TuristRuta>();
        }

        public int DrzavaId { get; set; }
        public string Naziv { get; set; }

        public ICollection<Grad> Grad { get; set; }
        public ICollection<Lokacija> Lokacija { get; set; }
        public ICollection<TuristRuta> TuristRuta { get; set; }
    }
}
