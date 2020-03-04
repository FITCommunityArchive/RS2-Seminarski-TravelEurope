using AutoMapper;
using TravelEurope.Model.Requests;
using TravelEurope.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Services
{
    public class PreporukaService : IPreporukaService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        private int pozitivnaOcjena = 3;
        private int brojRezultata = 5;

        public PreporukaService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public List<Model.TuristRute> GetPreporuceneTuristRute()
        {
            int KorisnikId = Security.BasicAuthenticationHandler.PrijavljeniKorisnik.KorisniciId;

            try
            {
                if (KorisnikId == 0)
                {
                    throw new Exception();
                }

                List<Ocjene> listaOcjena = _context.Ocjene.Where(x => x.KorisnikId == KorisnikId)
                    .Include(m => m.TuristRuta.Izdavac)
                    .Include(m => m.TuristRuta.Developer)
                    .ToList();

                List<Ocjene> listaPozitivnihOcjena = listaOcjena
                    .Where(x => x.Ocjena >= pozitivnaOcjena)
                    .ToList();

                if (listaPozitivnihOcjena.Count() > 0)
                {
                    List<Kategorije> jedinstveneKategorije = new List<Kategorije>();
                    foreach (var item in listaPozitivnihOcjena)
                    {
                        var TuristRutaKategorije = _context.TuristRuteKategorije.Where(m => m.TuristRutaId == item.TuristRutaId)
                            .Select(g => g.Kategorija)
                            .ToList();

                        foreach (var Kategorija in TuristRutaKategorije)
                        {
                            // Add only unique items to the list (no duplicates)
                            bool dodaj = true;
                            for (int i = 0; i < jedinstveneKategorije.Count; i++)
                            {
                                if (Kategorija.Naziv == jedinstveneKategorije[i].Naziv)
                                {
                                    dodaj = false;
                                }
                            }

                            if (dodaj)
                            {
                                jedinstveneKategorije.Add(Kategorija);
                            }
                        }
                    }

                    List<TuristRute> konacnaLista = new List<TuristRute>();
                    foreach (var item in jedinstveneKategorije)
                    {
                        var TuristRuteUKategoriji = _context.TuristRuteKategorije
                            .Where(g => g.KategorijaId == item.KategorijaId)
                            .Select(x => x.TuristRuta)
                            .ToList();

                        foreach (var TuristRuta in TuristRuteUKategoriji)
                        {
                            bool dodaj = true;
                            for (int i = 0; i < konacnaLista.Count; i++)
                            {
                                if (TuristRuta.Naziv == konacnaLista[i].Naziv)
                                {
                                    dodaj = false;
                                }

                            }

                            foreach (var ocjena in listaOcjena)
                            {
                                if(TuristRuta.Naziv == ocjena.TuristRuta.Naziv)
                                {
                                    dodaj = false;
                                }
                            }

                            if (dodaj)
                            {
                                konacnaLista.Add(TuristRuta);
                            }
                        }
                    }

                    konacnaLista = konacnaLista.OrderBy(media => Guid.NewGuid()).Take(brojRezultata).ToList();

                    // ucitavanje slika za svaku igru
                    List<Model.TuristRute> listaIgara = _mapper.Map<List<Model.TuristRute>>(konacnaLista);
                    foreach (var item in listaIgara)
                    {
                        var querySlika = _context.RuteSlike.AsQueryable();

                        querySlika = querySlika.Where(x => x.TuristRutaId == item.TuristRutaId);

                        var entitySlika = querySlika.FirstOrDefault();

                        if (entitySlika != null)
                        {
                            item.SlikaThumb = entitySlika.SlikaThumb;
                        }
                    }
                    return listaIgara;
                }
                throw new Exception();
            }
            catch
            {
                var lista = _context.TuristRute.OrderBy(media => Guid.NewGuid()).Take(brojRezultata).ToList();

                // ucitavanje slika za svaku igru
                List<Model.TuristRute> listaIgara = _mapper.Map<List<Model.TuristRute>>(lista);
                foreach (var item in listaIgara)
                {
                    var querySlika = _context.RuteSlike.AsQueryable();

                    querySlika = querySlika.Where(x => x.TuristRutaId == item.TuristRutaId);

                    var entitySlika = querySlika.FirstOrDefault();

                    if (entitySlika != null)
                    {
                        item.SlikaThumb = entitySlika.SlikaThumb;
                    }
                }
                return listaIgara;
            }
        }
    }
}
