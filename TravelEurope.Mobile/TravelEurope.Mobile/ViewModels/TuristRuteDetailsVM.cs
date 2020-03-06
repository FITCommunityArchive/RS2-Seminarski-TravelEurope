using TravelEurope.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using TravelEurope.Model.Requests;

namespace TravelEurope.Mobile.ViewModels
{
    public class TuristRuteDetailsVM : BaseViewModel
    {
        private readonly APIService _serviceTuristRute = new APIService("TuristRute");
        private readonly APIService _serviceRuteSlike = new APIService("RuteSlike");
        private readonly APIService _serviceOcjene = new APIService("Ocjene");
        private readonly APIService _serviceRecenzije = new APIService("Recenzije");
        private readonly APIService _serviceRezervacije = new APIService("Rezervacije");

        public ObservableCollection<Model.RuteSlike> SlikeList { get; set; } = new ObservableCollection<Model.RuteSlike>();

        private int _TuristRutaId;
        private int _KorisnikId;

        private TuristRuteMobile _ruta;
        public TuristRuteMobile Ruta
        {
            get { return _ruta; }
            set { SetProperty(ref _ruta, value); }
        }


        bool _provjera = false;
        public bool Provjera
        {
            get { return _provjera; }
            set { SetProperty(ref _provjera, value); }
        }

        public int TrenutnaSlika { get; set; } = 0;

        private byte[] _prikazanaSlika;

        public byte[] PrikazanaSlika
        {
            get { return _prikazanaSlika; }
            set { SetProperty(ref _prikazanaSlika, value); }
        }

        public int Ocjena { get; set; }
        public ICommand InitCommand { get; set; }

        public TuristRuteDetailsVM(int TuristRutaId, int KorisnikId)
        { 
            _TuristRutaId = TuristRutaId;
            _KorisnikId = KorisnikId;
            InitCommand = new Command(async () => await Init());
            //InitCommand.Execute(null);
        }

        public async Task Init()
        {
            await UcitajRutaDetails();

            await UcitajSlike();

        }

        private async Task UcitajRutaDetails()
        {
            var temp = await _serviceTuristRute.GetById<TuristRuteMobile>(_TuristRutaId);
            Title = temp.Naziv;

            temp.UkupnaCijena = temp.CijenaPaketa * temp.TrajanjePutovanja + temp.CijenaOsiguranja * temp.TrajanjePutovanja;

            Ruta = temp;

            var request = new Model.Requests.OcjeneSearchRequest
            {
                TuristRutaId = _TuristRutaId,
            };
            var PostojecaOcjena = await _serviceOcjene.Get<List<Model.Ocjene>>(request);
            if (PostojecaOcjena.Count > 0)
            {
                Ocjena = PostojecaOcjena[0].Ocjena;
            }
        }

        private async Task<float> UcitajRecenzije()
        {
            var requestRecenzije = new Model.Requests.RecenzijeSearchRequest
            {
                TuristRutaId = _TuristRutaId,
            };
            var recenzije = await _serviceRecenzije.Get<List<Model.Recenzije>>(requestRecenzije);
            if (recenzije.Count == 0)
                return 0;

            double suma = 0;
            foreach (var item in recenzije)
            {
                suma += item.Ocjena;
            }

            return (float)Math.Round(suma / recenzije.Count);
        }

        private async Task UcitajSlike()
        {
            var request = new Model.Requests.RuteSlikeSearchRequest
            {
                TuristRutaId = _TuristRutaId
            };

            var listSlike = await _serviceRuteSlike.Get<List<Model.RuteSlike>>(request);
            SlikeList.Clear();
            foreach (var item in listSlike)
            {
                SlikeList.Add(item);
            }

            if (listSlike.Count > 0)
            {
                PrikazanaSlika = listSlike[0].Slika;
            }
        }

        public async void AddRezervaciju()
        {
            var request = new RezervacijeInsertRequest
            {
                TuristRutaId = _TuristRutaId,
                KorisnikId = 1,//APIService.PrijavljeniKorisnik.KorisniciId,
                DatumRezervacije = DateTime.Now
            };

            var entity = await _serviceRezervacije.Insert<Model.Rezervacije>(request);
            if (entity!=null)
            {

            }
        }
    }
}
