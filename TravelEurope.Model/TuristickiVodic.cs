using System;
using System.Collections.Generic;

namespace TravelEurope.Model
{
    public partial class TuristickiVodic
    {
        public TuristickiVodic()
        {
            TuristRuta = new HashSet<TuristRuta>();
        }

        public int TuristickiVodicId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string StraniJezik { get; set; }

        public ICollection<TuristRuta> TuristRuta { get; set; }
    }
}
