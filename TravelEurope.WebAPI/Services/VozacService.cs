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
    public class VozacService : IVozacService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public VozacService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Vozac> Get(VozacSearchRequest request)
        {
            var query = _context.Vozac.Include(a=>a.StatusVozaca).AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Ime.ToLower().Contains(request.Naziv.ToLower()));
            }


            var list = query.ToList();

            return _mapper.Map<List<Model.Vozac>>(list);
        }

        public Model.Vozac Insert(VozacInsertRequest request)
        {
            Database.Vozac entity = _mapper.Map<Database.Vozac>(request);
           
            _context.Vozac.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Vozac>(entity);
        }
        public Model.Vozac GetById(int id)
        {
            var query = _context.Vozac.AsQueryable();

            query = query.Where(x => x.VozacId == id);

            var entity = query.FirstOrDefault();

            return _mapper.Map<Model.Vozac>(entity);
        }

        public Model.Vozac Update(int id, VozacInsertRequest request)
        {
            Database.Vozac entity = _context.Vozac.Where(x => x.VozacId == id).FirstOrDefault();

            _context.Vozac.Attach(entity);
            _context.Vozac.Update(entity);

            entity = _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Vozac>(entity);

        }
    }
}
