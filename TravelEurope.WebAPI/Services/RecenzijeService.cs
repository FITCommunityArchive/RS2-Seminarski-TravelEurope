using AutoMapper;
using TravelEurope.Model;
using TravelEurope.Model.Requests;
using TravelEurope.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Services
{
    public class RecenzijeService : IRecenzijeService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public RecenzijeService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Recenzije> Get(RecenzijeSearchRequest request)
        {
            var query = _context.Recenzije.AsQueryable();

            
            if(request?.TuristRutaId != 0)
            {
                query = query.Where(x => x.TuristRutaId == request.TuristRutaId);
            }
            if (request?.KorisnikId != 0)
            {
                query = query.Where(x => x.KorisnikId == request.KorisnikId);
            }

            query = query.Include(x => x.TuristRuta);
            query = query.Include(x => x.Korisnik);

            var list = query.ToList();

            return _mapper.Map<List<Model.Recenzije>>(list);
        }

        public Model.Recenzije GetById(int id)
        {
            var query = _context.Recenzije.AsQueryable();

            query = query.Where(x => x.RecenzijaId == id);

            query = query.Include(x => x.TuristRuta);

            query = query.Include(x => x.Korisnik);
            

            var entity = query.FirstOrDefault();


            return _mapper.Map<Model.Recenzije>(entity);
        }

        public Model.Recenzije Insert(RecenzijeInsertRequest request)
        {
            Database.Recenzije entity = _mapper.Map<Database.Recenzije>(request);

            entity.KorisnikId = Security.BasicAuthenticationHandler.PrijavljeniKorisnik.KorisniciId;

            _context.Recenzije.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Recenzije>(entity);
        }

        public Model.Recenzije Update(int id, RecenzijeInsertRequest request)
        { 
            Database.Recenzije entity = _context.Recenzije.Where(x => x.TuristRutaId == id).FirstOrDefault();

            _context.Recenzije.Attach(entity);
            _context.Recenzije.Update(entity);

            entity = _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Recenzije>(entity);

        }
    }
}
