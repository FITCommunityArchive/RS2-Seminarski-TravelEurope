using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TravelEurope.Model.Requests
{
    public class RuteSlikeInsertRequest
    {
        [Required]
        public string Naziv { get; set; }
    }
}
