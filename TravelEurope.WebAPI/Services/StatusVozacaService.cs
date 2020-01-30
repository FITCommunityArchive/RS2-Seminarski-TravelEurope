using AutoMapper;
using TravelEurope.Model.Requests;
using TravelEurope.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Services
{
    public class StatusVozacaService : IStatusVozacaService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public StatusVozacaService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.StatusVozaca> Get(StatusVozacaSearchRequest request)
        {
            var query = _context.StatusVozaca.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Status))
            {
                query = query.Where(x => x.Dostupan.ToString().ToLower().Contains(request.Status.ToLower()));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.StatusVozaca>>(list);
        }

    }
}
