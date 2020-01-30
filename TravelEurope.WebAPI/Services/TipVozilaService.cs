using AutoMapper;
using TravelEurope.Model.Requests;
using TravelEurope.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Services
{
    public class TipVozilaService : ITipVozilaService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public TipVozilaService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.TipVozila> Get(TipVozilaSearchRequest request)
        {
            var query = _context.TipVozila.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().Contains(request.Naziv.ToLower()));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.TipVozila>>(list);
        }

    }
}
