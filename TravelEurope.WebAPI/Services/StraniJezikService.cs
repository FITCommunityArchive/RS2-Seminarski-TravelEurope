using AutoMapper;
using TravelEurope.Model.Requests;
using TravelEurope.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Services
{
    public class StraniJezikService : IStraniJezikService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public StraniJezikService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.StraniJezik> Get(StraniJezikSearchRequest request)
        {
            var query = _context.StraniJezik.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().Contains(request.Naziv.ToLower()));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.StraniJezik>>(list);
        }

    }
}
