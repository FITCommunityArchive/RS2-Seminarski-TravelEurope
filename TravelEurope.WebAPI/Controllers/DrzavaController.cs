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
    public class DrzavaController : ControllerBase
    {
        private readonly IDrzavaService _service;

        public DrzavaController(IDrzavaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Drzava> Get([FromQuery]Model.Requests.DrzavaSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.Drzava Insert([FromBody]Model.Requests.DrzavaInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public Model.Drzava Update(int id, [FromBody]Model.Requests.DrzavaInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Drzava GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}