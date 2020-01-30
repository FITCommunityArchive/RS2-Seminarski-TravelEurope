using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model;
using TravelEurope.Model.Requests;

namespace TravelEurope.WebAPI.Services
{
    public interface IStatusVozacaService
    {
        List<Model.StatusVozaca> Get(Model.Requests.StatusVozacaSearchRequest request);
    }
}
