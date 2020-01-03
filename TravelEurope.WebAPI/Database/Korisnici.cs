using System;
using System.Collections.Generic;

namespace TravelEurope.WebAPI.Database
{
    public partial class Korisnici
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }

        public string Adresa { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public int GradId { get; set; }
        public string Ime { get; set; }
        public string Jmbg { get; set; }
        public string Prezime { get; set; }
        public byte[] Slika { get; set; }
        public string Spol { get; set; }
        public string Telefon { get; set; }

        public Grad Grad { get; set; }
        public Administrator Administrator { get; set; }
        public Klijent Klijent { get; set; }
        public Radnik Radnik { get; set; }

    }
}
