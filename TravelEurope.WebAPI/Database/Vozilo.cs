using System;
using System.Collections.Generic;

namespace TravelEurope.WebAPI.Database
{
    public partial class Vozilo
    {
        public Vozilo()
        {
            Rezervacija = new HashSet<Rezervacija>();
        }

        public int VoziloId { get; set; }
        public string Naziv { get; set; }
        public int TipVozilaId { get; set; }
        public DateTime GodinaProizvodnje { get; set; }
        public int MarkaVozilaId { get; set; }
        public int StatusVozilaId { get; set; }
        public int VrstaGorivaId { get; set; }
        public int BrojSjedista { get; set; }
        public string Boja { get; set; }
        public int BrojVrata { get; set; }
        public byte[] Slika { get; set; }

        public MarkaVozila MarkaVozila { get; set; }
        public StatusVozila StatusVozila { get; set; }
        public TipVozila TipVozila { get; set; }
        public VrstaGoriva VrstaGoriva { get; set; }
        public ICollection<Rezervacija> Rezervacija { get; set; }
    }
}
