using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model.Requests;

namespace TravelEurope.WebAPI.Services
{
    public interface IRecenzijeService
    {
        List<Model.Recenzije> Get(Model.Requests.RecenzijeSearchRequest request);
        Model.Recenzije Insert(Model.Requests.RecenzijeInsertRequest request);
        Model.Recenzije GetById(int id);
        Model.Recenzije Update(int id, RecenzijeInsertRequest request);
    }
}
