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
    public class TuristRutaController : ControllerBase
    {
        private readonly ITuristickaRutaServices _service;

        public TuristRutaController(ITuristickaRutaServices service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.TuristRuta> Get([FromQuery]Model.Requests.TuristickeRuteSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.TuristRuta Insert([FromBody]Model.Requests.TuristickeRuteInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public Model.TuristRuta Update(int id, [FromBody]Model.Requests.TuristickeRuteInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.TuristRuta GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}