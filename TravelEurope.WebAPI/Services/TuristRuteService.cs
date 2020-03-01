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
    public class TuristRuteService : ITuristRuteService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public TuristRuteService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.TuristRute> Get(TuristRuteSearchRequest request)
        {

            var query = _context.TuristRute.Include(a=>a.Kategorija).Include(b=>b.Lokacija).Include(c=>c.TuristickiVodic).ThenInclude(d=>d.StraniJezik).AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().Contains(request.Naziv.ToLower()));
            }
            //if (request?.KategorijaId != 0)
            //{
            //    query = query.Where(x => x.KategorijaId == request.KategorijaId);
            //}

            var list = query.ToList();

            return _mapper.Map<List<Model.TuristRute>>(list);
        }

        public Model.TuristRute Insert(TuristRuteInsertRequest request)
        {
            Database.TuristRute entity = _mapper.Map<Database.TuristRute>(request);
           
            _context.TuristRute.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.TuristRute>(entity);
        }
        public Model.TuristRute GetById(int id)
        {
            var query = _context.TuristRute.Include(a => a.Kategorija).Include(b => b.Lokacija).Include(c => c.TuristickiVodic).AsQueryable();

            query = query.Where(x => x.TuristRutaId == id);

            var entity = query.FirstOrDefault();

            return _mapper.Map<Model.TuristRute>(entity);
        }

        public Model.TuristRute Update(int id, TuristRuteInsertRequest request)
        {
            Database.TuristRute entity = _context.TuristRute.Where(x => x.TuristRutaId == id).FirstOrDefault();

            _context.TuristRute.Attach(entity);
            _context.TuristRute.Update(entity);

            entity = _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.TuristRute>(entity);
        }
    }
}
