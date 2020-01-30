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
    public class TuristickiVodicController : ControllerBase
    {
        private readonly ITuristickiVodicServices _service;

        public TuristickiVodicController(ITuristickiVodicServices service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.TuristickiVodic> Get([FromQuery]Model.Requests.TuristickiVodicSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.TuristickiVodic Insert([FromBody]Model.Requests.TuristickiVodicInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public Model.TuristickiVodic Update(int id, [FromBody]Model.Requests.TuristickiVodicInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.TuristickiVodic GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}