using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model;
using TravelEurope.Model.Requests;

namespace TravelEurope.WebAPI.Services
{
    public interface IStraniJezikService
    {
        List<Model.StraniJezik> Get(Model.Requests.StraniJezikSearchRequest request);
    }
}
