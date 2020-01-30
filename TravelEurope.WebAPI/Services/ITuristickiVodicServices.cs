using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model;
using TravelEurope.Model.Requests;

namespace TravelEurope.WebAPI.Services
{
    public interface ITuristickiVodicServices
    {
        List<Model.TuristickiVodic> Get(Model.Requests.TuristickiVodicSearchRequest request);
        Model.TuristickiVodic Insert(Model.Requests.TuristickiVodicInsertRequest request);
        TuristickiVodic Update(int id, TuristickiVodicInsertRequest request);
        TuristickiVodic GetById(int id);
    }
}
