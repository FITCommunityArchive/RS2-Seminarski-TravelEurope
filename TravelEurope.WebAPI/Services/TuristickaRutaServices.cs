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
    public class TuristickaRutaServices : ITuristickaRutaServices
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public TuristickaRutaServices(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.TuristRuta> Get(TuristickeRuteSearchRequest request)
        {
            var query = _context.TuristRuta.Include(a=>a.Drzava).AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().Contains(request.Naziv.ToLower()));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.TuristRuta>>(list);
        }

        public Model.TuristRuta Insert(TuristickeRuteInsertRequest request)
        {
            Database.TuristRuta entity = _mapper.Map<Database.TuristRuta>(request);
           
            _context.TuristRuta.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.TuristRuta>(entity);
        }
        public Model.TuristRuta GetById(int id)
        {
            var query = _context.TuristRuta.AsQueryable();

            query = query.Where(x => x.TuristRutaId == id);

            var entity = query.FirstOrDefault();

            return _mapper.Map<Model.TuristRuta>(entity);
        }

        public Model.TuristRuta Update(int id, TuristickeRuteInsertRequest request)
        {
            Database.TuristRuta entity = _context.TuristRuta.Where(x => x.TuristRutaId == id).FirstOrDefault();

            _context.TuristRuta.Attach(entity);
            _context.TuristRuta.Update(entity);

            entity = _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.TuristRuta>(entity);

        }
    }
}
