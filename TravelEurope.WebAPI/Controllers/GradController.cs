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
    public class GradController : ControllerBase
    {
        private readonly IGradService _service;

        public GradController(IGradService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Grad> Get([FromQuery]Model.Requests.GradSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.Grad Insert([FromBody]Model.Requests.GradInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Grad Update(int id, [FromBody]Model.Requests.GradInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Grad GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}