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
    public class VoziloService : IVoziloService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public VoziloService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Vozilo> Get(VoziloSearchRequest request)
        {
            var query = _context.Vozilo.Include(a=>a.TipVozila).Include(b=>b.MarkaVozila).Include(c=>c.StatusVozila).Include(d=>d.VrstaGoriva).AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().Contains(request.Naziv.ToLower()));
            }


            var list = query.ToList();

            return _mapper.Map<List<Model.Vozilo>>(list);
        }

        public Model.Vozilo Insert(VoziloInsertRequest request)
        {
            Database.Vozilo entity = _mapper.Map<Database.Vozilo>(request);
           
            _context.Vozilo.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Vozilo>(entity);
        }
        public Model.Vozilo GetById(int id)
        {
            var query = _context.Vozilo.AsQueryable();

            query = query.Where(x => x.VoziloId == id);

            var entity = query.FirstOrDefault();

            return _mapper.Map<Model.Vozilo>(entity);
        }

        public Model.Vozilo Update(int id, VoziloInsertRequest request)
        {
            Database.Vozilo entity = _context.Vozilo.Where(x => x.VoziloId == id).FirstOrDefault();

            _context.Vozilo.Attach(entity);
            _context.Vozilo.Update(entity);

            entity = _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Vozilo>(entity);

        }
    }
}
