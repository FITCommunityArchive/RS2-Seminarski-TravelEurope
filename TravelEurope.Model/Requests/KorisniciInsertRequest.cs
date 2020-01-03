using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TravelEurope.Model.Requests
{
    public class KorisniciInsertRequest
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Adresa { get; set; }
        [Required]
        public DateTime DatumRodjenja { get; set; }
        [Required]
        public int GradId { get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Jmbg { get; set; }
        [Required]
        public string Prezime { get; set; }
        public byte[] Slika { get; set; }
        [Required]
        public string Spol { get; set; }
        [Required]
        public string Telefon { get; set; }

        [Required]
        [MinLength(3)]
        public string Password { get; set; }
        [Required]
        public string PasswordConfirmation { get; set; }

        public Administrator Administrator { get; set; }
        public Klijent Klijent { get; set; }
        public Radnik Radnik { get; set; }
    }
}
