using System;
using System.Collections.Generic;
using System.Text;
using TravelEurope.Model;

namespace TravelEurope.Mobile.Models
{
    public class TuristRuteMobile
    {
        public int TuristRutaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int DrzavaId { get; set; }
        public Drzava Drzava { get; set; }
        public int TuristickiVodicId { get; set; }
        public TuristickiVodic TuristickiVodic { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public float OcjenaKriticara { get; set; }
        public float OcjenaKorisnika { get; set; }
        public override string ToString()
        {
            return Naziv.ToString();
        }
    }
}
