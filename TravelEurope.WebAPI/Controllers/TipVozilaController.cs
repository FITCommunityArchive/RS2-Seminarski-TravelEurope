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
    public class TipVozilaController : ControllerBase
    {
        private readonly ITipVozilaService _service;

        public TipVozilaController(ITipVozilaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.TipVozila> Get([FromQuery]Model.Requests.TipVozilaSearchRequest request)
        {
            return _service.Get(request);
        }
    }
}

