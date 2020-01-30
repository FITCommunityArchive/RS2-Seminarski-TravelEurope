using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TravelEurope.Model.Requests
{
    public class TuristickeRuteInsertRequest
    {
        [Required]
        public string Naziv { get; set; }
        public string Opis { get; set; }
        [Required]
        public int TuristickiVodicId { get; set; }
        [Required]
        public int DrzavaId { get; set; }
    }
}
