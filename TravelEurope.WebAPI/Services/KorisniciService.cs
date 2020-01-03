using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model;
using TravelEurope.Model.Requests;
using TravelEurope.WebAPI.Database;
using TravelEurope.WebAPI.Helper;

namespace TravelEurope.WebAPI.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly TravelEurope_Context _db;
        private readonly IMapper _mapper;

        public KorisniciService(TravelEurope_Context db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public List<Model.Korisnici> Get(KorisniciSearchRequest request)
        {
            var query = _db.Korisnici.AsQueryable();

            if(!string.IsNullOrEmpty(request.Pretraga))
            {
                query = query.Where(x => (x.Ime + " " + x.Prezime).Contains(request.Pretraga));
            }

            query = IncludeUserDetails(query);

            var list = query.ToList();

            return _mapper.Map<List<Model.Korisnici>>(list);
        }

        public Model.Korisnici GetById(int id)
        {
            var query = _db.Korisnici.Where(x => x.Id == id);
            query = IncludeUserDetails(query);

            var entity = query.FirstOrDefault();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnici>(request);
            if (request.Password != request.PasswordConfirmation)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            entity.PasswordSalt = UserPasswordHelper.GenerateSalt();
            entity.PasswordHash = UserPasswordHelper.GenerateHash(entity.PasswordSalt, request.Password);

            _db.Korisnici.Add(entity);
            _db.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici Update(int id, KorisniciUpdateRequest request)
        {
            Database.Korisnici entity = _db.Korisnici.Where(x => x.Id == id)
                .Include(x=>x.Radnik)
                .Include(x=>x.Klijent)
                .FirstOrDefault();

            _db.Korisnici.Attach(entity);
            _db.Korisnici.Update(entity);

            if (!string.IsNullOrEmpty(request.Password))
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new Exception("Passwordi se ne slažu");
                }

                entity.PasswordSalt = UserPasswordHelper.GenerateSalt();
                entity.PasswordHash = UserPasswordHelper.GenerateHash(entity.PasswordSalt, request.Password);
            }

            entity.Adresa = request.Adresa;
            entity.DatumRodjenja = request.DatumRodjenja;
            entity.Email = request.Email;
            entity.GradId = request.GradId;
            entity.Ime = request.Ime;
            entity.Prezime = request.Prezime;
            entity.Slika = request.Slika;
            entity.Spol = request.Spol;
            entity.Telefon = request.Telefon;
            entity.UserName = request.UserName;

            if(entity.Radnik != null && request.Radnik != null)
            {
                entity.Radnik.GodineStaza = request.Radnik.GodineStaza;
                entity.Radnik.Pozicija = request.Radnik.Pozicija;
            }

            if(entity.Klijent != null && request.Klijent != null)
            {
                entity.Klijent.BrojPasosa = request.Klijent.BrojPasosa;
                entity.Klijent.BrVozackeDozvole = request.Klijent.BrVozackeDozvole;
            }

            _db.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }


        private static IQueryable<Database.Korisnici> IncludeUserDetails(IQueryable<Database.Korisnici> query)
        {
            query = query.Include(x => x.Administrator);
            query = query.Include(x => x.Radnik);
            query = query.Include(x => x.Klijent);
            query = query.Include(x => x.Grad.Drzava);
            return query;
        }

    }
}
