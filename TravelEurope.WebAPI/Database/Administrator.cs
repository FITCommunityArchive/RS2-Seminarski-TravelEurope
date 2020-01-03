using System;
using System.Collections.Generic;

namespace TravelEurope.WebAPI.Database
{
    public partial class Administrator
    {
        public int AdministratorId { get; set; }
        public string IzjavaZastitaPodataka { get; set; }

        public Korisnici AdministratorNavigation { get; set; }
    }
}
