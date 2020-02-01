using System;
using System.Collections.Generic;

namespace TravelEurope.Model
{
    public partial class TuristickiVodic
    {
        public int TuristickiVodicId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int StraniJezikId { get; set; }
        public StraniJezik StraniJezik { get; set; }
        public override string ToString()
        {
            string ip = Ime + " " + Prezime;/* + ", " + StraniJezik.Naziv;*/
            return ip.ToString();
        }
    }
}