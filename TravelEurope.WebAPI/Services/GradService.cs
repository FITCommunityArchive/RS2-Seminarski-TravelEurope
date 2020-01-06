using AutoMapper;
using TravelEurope.Model.Requests;
using TravelEurope.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Services
{
    public class GradService : IGradService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public GradService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Grad> Get(GradSearchRequest request)
        {
            var query = _context.Grad.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.ToLower().Contains(request.Naziv.ToLower()));
            }
            if (request?.DrzavaId != 0)
            {
                query = query.Where(x => x.DrzavaId == request.DrzavaId);
            }

            query = query.Include(x => x.Drzava);

            var list = query.ToList();

            return _mapper.Map<List<Model.Grad>>(list);
        }

        public Model.Grad Insert(GradInsertRequest request)
        {
            Database.Grad entity = _mapper.Map<Database.Grad>(request);

            _context.Grad.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Grad>(entity);
        }

        public Model.Grad GetById(int id)
        {
            var query = _context.Grad.AsQueryable();

            query = query.Where(x => x.GradId == id);

            query = query.Include(x => x.Drzava);

            var entity = query.FirstOrDefault();

            return _mapper.Map<Model.Grad>(entity);
        }

        public Model.Grad Update(int id, GradInsertRequest request)
        {
            Database.Grad entity = _context.Grad.Where(x => x.GradId == id).FirstOrDefault();

            _context.Grad.Attach(entity);
            _context.Grad.Update(entity);
            
            entity = _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Grad>(entity);

        }

    }

}
