using AutoMapper;
using TravelEurope.Model.Requests;
using TravelEurope.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TravelEurope.WebAPI.Services
{
    public class RezervacijaService : IRezervacijaService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public RezervacijaService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Rezervacija> Get(RezervacijaSearchRequest request)
        {
            var query = _context.Rezervacija.Include(b=>b.TuristRuta).Include(c=>c.Klijent).Include(d=>d.Radnik).AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.TuristRuta.Naziv.ToLower().Contains(request.Naziv.ToLower()));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Rezervacija>>(list);
        }
        public Model.Rezervacija GetById(int id)
        {
            var query = _context.Rezervacija.AsQueryable();

            query = query.Where(x => x.RezervacijaId == id);

            var entity = query.FirstOrDefault();

            return _mapper.Map<Model.Rezervacija>(entity);
        }
    }
}
