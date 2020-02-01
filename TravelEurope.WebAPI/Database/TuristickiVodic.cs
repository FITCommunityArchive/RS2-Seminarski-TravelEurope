using System;
using System.Collections.Generic;

namespace TravelEurope.WebAPI.Database
{
    public partial class TuristickiVodic
    {
        public int TuristickiVodicId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public StraniJezik StraniJezik { get; set; }
        public int StraniJezikId { get; set; }
    }
}