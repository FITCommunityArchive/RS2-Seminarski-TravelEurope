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
    public class StatusVozacaController : ControllerBase
    {
        private readonly IStatusVozacaService _service;

        public StatusVozacaController(IStatusVozacaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.StatusVozaca> Get([FromQuery]Model.Requests.StatusVozacaSearchRequest request)
        {
            return _service.Get(request);
        }
    }
}

