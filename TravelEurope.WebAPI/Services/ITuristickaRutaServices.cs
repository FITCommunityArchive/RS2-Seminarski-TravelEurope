using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelEurope.Model;
using TravelEurope.Model.Requests;

namespace TravelEurope.WebAPI.Services
{
    public interface ITuristickaRutaServices
    {
        List<Model.TuristRuta> Get(Model.Requests.TuristickeRuteSearchRequest request);
        Model.TuristRuta Insert(Model.Requests.TuristickeRuteInsertRequest request);
        TuristRuta Update(int id, TuristickeRuteInsertRequest request);
        TuristRuta GetById(int id);
    }
}
