using AutoMapper;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Korisnici, Model.Korisnici>();
            CreateMap<Database.Administrator, Model.Administrator>();
            CreateMap<Database.Klijent, Model.Klijent>();
            CreateMap<Database.Radnik, Model.Radnik>();
            
            CreateMap<Database.Drzava, Model.Drzava>();
            CreateMap<Database.Grad, Model.Grad>();
            CreateMap<Database.Lokacija, Model.Lokacija>();
            CreateMap<Database.MarkaVozila, Model.MarkaVozila>();
            CreateMap<Database.NacinPlacanja, Model.NacinPlacanja>();
            CreateMap<Database.Racun, Model.Racun>();
            CreateMap<Database.Rezervacija, Model.Rezervacija>();
            CreateMap<Database.StatusVozaca, Model.StatusVozaca>();
            CreateMap<Database.StatusVozila, Model.StatusVozila>();
            CreateMap<Database.TipVozila, Model.TipVozila>();
            CreateMap<Database.TuristRuta, Model.TuristRuta>();
            CreateMap<Database.TuristickiVodic, Model.TuristickiVodic>();
            CreateMap<Database.Vozac, Model.Vozac>();
            CreateMap<Database.Vozilo, Model.Vozilo>();
            CreateMap<Database.VrstaGoriva, Model.VrstaGoriva>();
            CreateMap<Database.StraniJezik, Model.StraniJezik>();
            CreateMap<Database.TipVozila, Model.TipVozila>();
            CreateMap<Database.MarkaVozila, Model.MarkaVozila>();
            CreateMap<Database.StatusVozila, Model.StatusVozila>();
            CreateMap<Database.VrstaGoriva, Model.VrstaGoriva>();
            CreateMap<Database.Kategorija, Model.Kategorija>();
            CreateMap<Database.RuteKategorije, Model.RuteKategorije>();
            CreateMap<Database.RuteSlike, Model.RuteSlike>();



            CreateMap<Database.Administrator, Model.Administrator>().ReverseMap();
            CreateMap<Database.Klijent, Model.Klijent>().ReverseMap();
            CreateMap<Database.Radnik, Model.Radnik>().ReverseMap();

            CreateMap<Database.Korisnici, Model.Requests.KorisniciInsertRequest>().ReverseMap();
            CreateMap<Database.Korisnici, Model.Requests.KorisniciUpdateRequest>().ReverseMap();

            CreateMap<Database.Drzava, Model.Requests.DrzavaInsertRequest>().ReverseMap();
            CreateMap<Database.Grad, Model.Requests.GradInsertRequest>().ReverseMap();

            CreateMap<Database.TuristRuta, Model.Requests.TuristickeRuteInsertRequest>().ReverseMap();
            CreateMap<Database.TuristickiVodic, Model.Requests.TuristickiVodicInsertRequest>().ReverseMap();

            CreateMap<Database.Vozilo, Model.Requests.VoziloInsertRequest>().ReverseMap();
            CreateMap<Database.Vozac, Model.Requests.VozacInsertRequest>().ReverseMap();



        }
    }
}
