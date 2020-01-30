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
    public class StraniJezikController : ControllerBase
    {
        private readonly IStraniJezikService _service;

        public StraniJezikController(IStraniJezikService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.StraniJezik> Get([FromQuery]Model.Requests.StraniJezikSearchRequest request)
        {
            return _service.Get(request);
        }
    }
}

