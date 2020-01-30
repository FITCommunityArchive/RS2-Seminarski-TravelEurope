using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model;
using TravelEurope.Model.Requests;

namespace TravelEurope.WebAPI.Services
{
    public interface IMarkaVozilaService
    {
        List<Model.MarkaVozila> Get(Model.Requests.MarkaVozilaSearchRequest request);
    }
}
