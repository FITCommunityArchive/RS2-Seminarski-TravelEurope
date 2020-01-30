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
    public class MarkaVozilaController : ControllerBase
    {
        private readonly IMarkaVozilaService _service;

        public MarkaVozilaController(IMarkaVozilaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.MarkaVozila> Get([FromQuery]Model.Requests.MarkaVozilaSearchRequest request)
        {
            return _service.Get(request);
        }
    }
}

