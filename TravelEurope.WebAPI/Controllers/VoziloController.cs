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
    public class VoziloController : ControllerBase
    {
        private readonly IVoziloService _service;

        public VoziloController(IVoziloService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Vozilo> Get([FromQuery]Model.Requests.VoziloSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.Vozilo Insert([FromBody]Model.Requests.VoziloInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public Model.Vozilo Update(int id, [FromBody]Model.Requests.VoziloInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Vozilo GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}