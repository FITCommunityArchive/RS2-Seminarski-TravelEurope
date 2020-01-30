using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model;
using TravelEurope.Model.Requests;

namespace TravelEurope.WebAPI.Services
{
    public interface IVoziloService
    {
        List<Model.Vozilo> Get(Model.Requests.VoziloSearchRequest request);
        Model.Vozilo Insert(Model.Requests.VoziloInsertRequest request);
        Vozilo Update(int id, VoziloInsertRequest request);
        Vozilo GetById(int id);
    }
}
