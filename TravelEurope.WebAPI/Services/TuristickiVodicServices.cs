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
    public class TuristickiVodicServices : ITuristickiVodicServices
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public TuristickiVodicServices(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.TuristickiVodic> Get(TuristickiVodicSearchRequest request)
        {
            var query = _context.TuristickiVodic.Include(a => a.StraniJezik).AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.ToLower().Contains(request.Ime.ToLower()));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.TuristickiVodic>>(list);
        }

        public Model.TuristickiVodic Insert(TuristickiVodicInsertRequest request)
        {
            Database.TuristickiVodic entity = _mapper.Map<Database.TuristickiVodic>(request);
           
            _context.TuristickiVodic.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.TuristickiVodic>(entity);
        }
        public Model.TuristickiVodic GetById(int id)
        {
            var query = _context.TuristickiVodic.AsQueryable();

            query = query.Where(x => x.TuristickiVodicId == id);

            var entity = query.FirstOrDefault();

            return _mapper.Map<Model.TuristickiVodic>(entity);
        }

        public Model.TuristickiVodic Update(int id, TuristickiVodicInsertRequest request)
        {
            Database.TuristickiVodic entity = _context.TuristickiVodic.Where(x => x.TuristickiVodicId == id).FirstOrDefault();

            _context.TuristickiVodic.Attach(entity);
            _context.TuristickiVodic.Update(entity);

            entity = _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.TuristickiVodic>(entity);

        }
    }
}
