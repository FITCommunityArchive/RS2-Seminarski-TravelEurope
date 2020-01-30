using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TravelEurope.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RuteKategorijeController : ControllerBase
    {
        private readonly ITuristickaRutaServices _service;

        public RuteKategorijeController(ITuristickaRutaServices service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.RuteKategorije> Get([FromQuery]Model.Requests.RuteKategorijeSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.RuteKategorije Insert([FromBody]Model.Requests.RuteKategorijeInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public Model.RuteKategorije Update(int id, [FromBody]Model.Requests.RuteKategorijeInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.RuteKategorije GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}