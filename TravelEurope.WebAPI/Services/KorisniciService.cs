﻿using AutoMapper;
using TravelEurope.Model;
using TravelEurope.Model.Requests;
using TravelEurope.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public KorisniciService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Korisnici> Get(KorisniciSearchRequest request)
        {
            var query = _context.Korisnici.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.ImePrezime))
            {
                query = query.Where(x => (x.Ime + " " + x.Prezime).ToLower().Contains(request.ImePrezime.ToLower()) ||
                                          x.KorisnickoIme.Contains(request.ImePrezime.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(request?.UserName))
            {
                query = query.Where(x => x.KorisnickoIme.ToLower().StartsWith(request.UserName));
            }

            query = query.Include(x => x.Grad.Drzava);
            query = query.Include(x => x.Uloga);

            var list = query.ToList();

            return _mapper.Map<List<Model.Korisnici>>(list);
        }

        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            Database.Korisnici entity = _mapper.Map<Database.Korisnici>(request);
            if (request.Lozinka != request.LozinkaPotvrda)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Lozinka);

            _context.Korisnici.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }


        public Model.Korisnici Update(int id, KorisniciUpdateRequest request)
        {
            Database.Korisnici entity = _context.Korisnici.Where(x => x.KorisniciId == id).FirstOrDefault();

            _context.Korisnici.Attach(entity);
            _context.Korisnici.Update(entity);

            if (request.Lozinka != string.Empty)
            {
                if (request.Lozinka != request.LozinkaPotvrda)
                {
                    throw new Exception("Passwordi se ne slažu");
                }

                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Lozinka);
            }

            entity = _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public Model.Korisnici GetById(int id)
        {
            var query = _context.Korisnici.AsQueryable();

            query = query.Where(x => x.KorisniciId == id);

            query = query.Include(x => x.Grad);
            query = query.Include(x => x.Uloga);

            var entity = query.FirstOrDefault();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici MyProfile()
        {
            var query = _context.Korisnici.AsQueryable();

            query = query.Where(x => x.KorisniciId == Security.BasicAuthenticationHandler.PrijavljeniKorisnik.KorisniciId);

            query = query.Include(x => x.Grad.Drzava);
            query = query.Include(x => x.Uloga);

            var entity = query.FirstOrDefault();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici UpdateProfile(KorisniciUpdateProfilRequest request)
        {
            int KorisnikId = Security.BasicAuthenticationHandler.PrijavljeniKorisnik.KorisniciId;

            Database.Korisnici entity = _context.Korisnici.Where(x => x.KorisniciId == KorisnikId).FirstOrDefault();

            _context.Korisnici.Attach(entity);
            _context.Korisnici.Update(entity);

            if (!string.IsNullOrEmpty(request.Lozinka))
            {
                if (request.Lozinka != request.LozinkaPotvrda)
                {
                    throw new Exception("Passwordi se ne slažu");
                }

                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Lozinka);
            }

            entity = _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }


        public Model.Korisnici Authenticiraj(string username, string pass)
        {
            var user = _context.Korisnici
                .Include(x => x.Uloga)
                .Include(x => x.Grad.Drzava)
                .FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var newHash = GenerateHash(user.LozinkaSalt, pass);

                if (newHash == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Korisnici>(user);
                }
            }
            return null;
        }
    }
}
