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

        public PreporukaService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.TuristRute> GetById(int id)
        {
            int KorisnikId = Security.BasicAuthenticationHandler.PrijavljeniKorisnik.KorisniciId;

            try
            {
                if (KorisnikId == 0)
                {
                    throw new Exception();
                }

                TuristRute model = _context.TuristRute.Where(a => a.TuristRutaId == id).Include(b=>b.Kategorija).FirstOrDefault();

                List<TuristRute> isteKategorije = _context.TuristRute.Where(a => a.KategorijaId == model.KategorijaId).ToList();

                List<TuristRute> filterisanaListaBezIzabranog = new List<TuristRute>();

                foreach (var x in isteKategorije)
                {
                    if (x.TuristRutaId != model.TuristRutaId)
                    {
                        filterisanaListaBezIzabranog.Add(x);
                    }
                }

                List<Model.TuristRute> listaRuta = _mapper.Map<List<Model.TuristRute>>(filterisanaListaBezIzabranog);

                foreach (var item in listaRuta)
                {
                    var querySlika = _context.RuteSlike.AsQueryable();

                    querySlika = querySlika.Where(x => x.TuristRutaId == item.TuristRutaId);

                    var entitySlika = querySlika.FirstOrDefault();

                    if (entitySlika != null)
                    {
                        item.SlikaThumb = entitySlika.SlikaThumb;
                    }
                }
                return listaRuta;
            }
            catch
            {
                TuristRute model = _context.TuristRute.Where(a => a.TuristRutaId == id).Include(b => b.Kategorija).Include(c => c.Lokacija).Include(d => d.TuristickiVodic).FirstOrDefault();

                List<TuristRute> isteKategorije = _context.TuristRute.Where(a => a.KategorijaId == model.KategorijaId).ToList();

                List<TuristRute> filterisanaListaBezIzabranog = new List<TuristRute>();

                foreach (var x in isteKategorije)
                {
                    if (x.TuristRutaId != model.TuristRutaId)
                    {
                        filterisanaListaBezIzabranog.Add(x);
                    }
                }

                List<Model.TuristRute> listaRuta = _mapper.Map<List<Model.TuristRute>>(filterisanaListaBezIzabranog);

                // ucitavanje slika za svaku igru
                foreach (var item in listaRuta)
                {
                    var querySlika = _context.RuteSlike.AsQueryable();

                    querySlika = querySlika.Where(x => x.TuristRutaId == item.TuristRutaId);

                    var entitySlika = querySlika.FirstOrDefault();

                    if (entitySlika != null)
                    {
                        item.SlikaThumb = entitySlika.SlikaThumb;
                    }
                }
                return listaRuta;
            }
        }
    }
}
