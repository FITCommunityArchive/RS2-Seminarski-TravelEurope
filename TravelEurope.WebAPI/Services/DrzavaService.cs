using AutoMapper;
using TravelEurope.Model.Requests;
using TravelEurope.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Services
{
    public class DrzavaService : IDrzavaService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public DrzavaService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Drzava> Get(DrzavaSearchRequest request)
        {
            var query = _context.Drzava.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().Contains(request.Naziv.ToLower()));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Drzava>>(list);
        }

        public Model.Drzava Insert(DrzavaInsertRequest request)
        {
            Database.Drzava entity = _mapper.Map<Database.Drzava>(request);
           
            _context.Drzava.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Drzava>(entity);
        }
        public Model.Drzava GetById(int id)
        {
            var query = _context.Drzava.AsQueryable();

            query = query.Where(x => x.DrzavaId == id);

            var entity = query.FirstOrDefault();

            return _mapper.Map<Model.Drzava>(entity);
        }

        public Model.Drzava Update(int id, DrzavaInsertRequest request)
        {
            Database.Drzava entity = _context.Drzava.Where(x => x.DrzavaId == id).FirstOrDefault();

            _context.Drzava.Attach(entity);
            _context.Drzava.Update(entity);

            entity = _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Drzava>(entity);

        }
    }
}
