using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model;
using TravelEurope.Model.Requests;

namespace TravelEurope.WebAPI.Services
{
    public interface IDrzavaService
    {
        List<Model.Drzava> Get(Model.Requests.DrzavaSearchRequest request);
        Model.Drzava Insert(Model.Requests.DrzavaInsertRequest request);
        Drzava Update(int id, DrzavaInsertRequest request);
        Drzava GetById(int id);
    }
}
