using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model;
using TravelEurope.Model.Requests;

namespace TravelEurope.WebAPI.Services
{
    public interface IStatusVozilaService
    {
        List<Model.StatusVozila> Get(Model.Requests.StatusVozilaSearchRequest request);
    }
}
