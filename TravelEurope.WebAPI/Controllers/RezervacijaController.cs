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
    public class RezervacijaController : ControllerBase
    {
        private readonly IRezervacijaService _service;

        public RezervacijaController(IRezervacijaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Rezervacija> Get([FromQuery]Model.Requests.RezervacijaSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Model.Rezervacija GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}