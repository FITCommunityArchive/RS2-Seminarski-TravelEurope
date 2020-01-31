﻿using AutoMapper;
using TravelEurope.Model.Requests;
using TravelEurope.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Services
{
    public class RuteSlikeService : IRuteSlikeService
    {
        private readonly TravelEurope_Context _context;

        private readonly IMapper _mapper;

        public RuteSlikeService(TravelEurope_Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.RuteSlike> Get(RuteSlikeSearchRequest request)
        {
            var query = _context.RuteSlike.AsQueryable();

            if (request?.RutaId != 0)
            {
                query = query.Where(x => x.TuristRutaId == request.RutaId);
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.RuteSlike>>(list);
        }

        public Model.RuteSlike Insert(RuteSlikeInsertRequest request)
        {
            Database.RuteSlike entity = _mapper.Map<Database.RuteSlike>(request);
           
            _context.RuteSlike.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.RuteSlike>(entity);
        }
        public Model.RuteSlike GetById(int id)
        {
            var query = _context.RuteSlike.AsQueryable();

            query = query.Where(x => x.RuteSlikeId == id);

            var entity = query.FirstOrDefault();

            return _mapper.Map<Model.RuteSlike>(entity);
        }

        public Model.RuteSlike Update(int id, RuteSlikeInsertRequest request)
        {
            Database.RuteSlike entity = _context.RuteSlike.Where(x => x.RuteSlikeId == id).FirstOrDefault();

            _context.RuteSlike.Attach(entity);
            _context.RuteSlike.Update(entity);

            entity = _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.RuteSlike>(entity);

        }
    }
}