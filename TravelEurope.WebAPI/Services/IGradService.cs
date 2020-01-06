using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model;
using TravelEurope.Model.Requests;

namespace TravelEurope.WebAPI.Services
{
    public interface IGradService
    {
        List<Model.Grad> Get(Model.Requests.GradSearchRequest request);
        Model.Grad Insert(Model.Requests.GradInsertRequest request);
        Grad Update(int id, GradInsertRequest request);
        Grad GetById(int id);
    }
}
