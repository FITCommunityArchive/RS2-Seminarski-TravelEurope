using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model;
using TravelEurope.Model.Requests;

namespace TravelEurope.WebAPI.Services
{
    public interface IRezervacijaService
    {
        List<Model.Rezervacija> Get(Model.Requests.RezervacijaSearchRequest request);
        Rezervacija GetById(int id);
    }
}
