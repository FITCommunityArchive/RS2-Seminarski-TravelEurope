using System;
using System.Collections.Generic;

namespace TravelEurope.WebAPI.Database
{
    public partial class Grad
    {
        public Grad()
        {
            AspNetUsers = new HashSet<Korisnici>();
        }

        public int GradId { get; set; }
        public string Naziv { get; set; }
        public int DrzavaId { get; set; }
        public Drzava Drzava { get; set; }
        public ICollection<Korisnici> AspNetUsers { get; set; }
    }
}
