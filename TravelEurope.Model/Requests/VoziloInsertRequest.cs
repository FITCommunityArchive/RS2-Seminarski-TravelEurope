using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TravelEurope.Model.Requests
{
    public class VoziloInsertRequest
    {
        [Required]
        public string Naziv { get; set; }
        [Required]
        public int TipVozilaId { get; set; }
        public int GodinaProizvodnje { get; set; }
        [Required]
        public int MarkaVozilaId { get; set; }
        [Required]
        public int StatusVozilaId { get; set; }
        [Required]
        public int VrstaGorivaId { get; set; }
        public int BrojSjedista { get; set; }
        public string Boja { get; set; }
        public int BrojVrata { get; set; }
    }
}
