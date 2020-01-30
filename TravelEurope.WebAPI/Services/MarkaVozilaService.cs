using AutoMapper;
using TravelEurope.Model.Requests;
using TravelEurope.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Services
{
    public class MarkaVozilaService : IMarkaVozilaService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public MarkaVozilaService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.MarkaVozila> Get(MarkaVozilaSearchRequest request)
        {
            var query = _context.MarkaVozila.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().Contains(request.Naziv.ToLower()));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.MarkaVozila>>(list);
        }

    }
}
