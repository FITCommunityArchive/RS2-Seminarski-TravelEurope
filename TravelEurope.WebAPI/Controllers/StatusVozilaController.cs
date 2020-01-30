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
    public class StatusVozilaController : ControllerBase
    {
        private readonly IStatusVozilaService _service;

        public StatusVozilaController(IStatusVozilaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.StatusVozila> Get([FromQuery]Model.Requests.StatusVozilaSearchRequest request)
        {
            return _service.Get(request);
        }
    }
}

