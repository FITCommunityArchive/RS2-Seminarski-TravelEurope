using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model;
using TravelEurope.Model.Requests;

namespace TravelEurope.WebAPI.Services
{
    public interface IVozacService
    {
        List<Model.Vozac> Get(Model.Requests.VozacSearchRequest request);
        Model.Vozac Insert(Model.Requests.VozacInsertRequest request);
        Vozac Update(int id, VozacInsertRequest request);
        Vozac GetById(int id);
    }
}
