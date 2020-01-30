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
    public class VrstaGorivaController : ControllerBase
    {
        private readonly IVrstaGorivaService _service;

        public VrstaGorivaController(IVrstaGorivaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.VrstaGoriva> Get([FromQuery]Model.Requests.VrstaGorivaSearchRequest request)
        {
            return _service.Get(request);
        }
    }
}

