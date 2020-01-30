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
    public class VozacController : ControllerBase
    {
        private readonly IVozacService _service;

        public VozacController(IVozacService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Vozac> Get([FromQuery]Model.Requests.VozacSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.Vozac Insert([FromBody]Model.Requests.VozacInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public Model.Vozac Update(int id, [FromBody]Model.Requests.VozacInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Vozac GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}