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
    public class RecenzijeController : ControllerBase
    {
        private readonly IRecenzijeService _service;

        public RecenzijeController(IRecenzijeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Recenzije> Get([FromQuery]Model.Requests.RecenzijeSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.Recenzije Insert([FromBody]Model.Requests.RecenzijeInsertRequest request)
        {
            return _service.Insert(request);
        }


        [HttpPut("{id}")]
        public Model.Recenzije Update(int id, [FromBody]Model.Requests.RecenzijeInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Recenzije GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}