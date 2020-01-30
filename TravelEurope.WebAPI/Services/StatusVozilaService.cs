using AutoMapper;
using TravelEurope.Model.Requests;
using TravelEurope.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Services
{
    public class StatusVozilaService : IStatusVozilaService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public StatusVozilaService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.StatusVozila> Get(StatusVozilaSearchRequest request)
        {
            var query = _context.StatusVozila.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Status))
            {
                query = query.Where(x => x.Status.ToLower().Contains(request.Status.ToLower()));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.StatusVozila>>(list);
        }

    }
}
