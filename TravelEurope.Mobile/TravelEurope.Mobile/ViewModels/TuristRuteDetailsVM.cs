using TravelEurope.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace TravelEurope.Mobile.ViewModels
{
    public class TuristRuteDetailsVM : BaseViewModel
    {
        private readonly APIService _serviceTuristRute = new APIService("TuristRute");
        private readonly APIService _serviceRuteSlike = new APIService("RuteSlike");
        private readonly APIService _serviceOcjene = new APIService("Ocjene");
        private readonly APIService _serviceRecenzije = new APIService("Recenzije");

        public ObservableCollection<Model.RuteSlike> SlikeList { get; set; } = new ObservableCollection<Model.RuteSlike>();

        private int _TuristRutaId;
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

        #region stars

        private Star _star1;
        public Star Star1
        {
            get { return _star1; }
            set { SetProperty(ref _star1, value); }
        }
        private Star _star2;
        public Star Star2
        {
            get { return _star2; }
            set { SetProperty(ref _star2, value); }
        }
        private Star _star3;
        public Star Star3
        {
            get { return _star3; }
            set { SetProperty(ref _star3, value); }
        }
        private Star _star4;
        public Star Star4
        {
            get { return _star4; }
            set { SetProperty(ref _star4, value); }
        }
        private Star _star5;
        public Star Star5
        {
            get { return _star5; }
            set { SetProperty(ref _star5, value); }
        }

        #endregion

        public ICommand InitCommand { get; set; }
        public ICommand OcijeniStarCommand { get; set; }

        public TuristRuteDetailsVM(int TuristRutaId)
        { 
            _TuristRutaId = TuristRutaId;
            InitCommand = new Command(async () => await Init());
            //InitCommand.Execute(null);

            OcijeniStarCommand = new Command<string>(async (ocjena) => await OcijeniStar(ocjena));
            Star1 = new Star();
            Star2 = new Star();
            Star3 = new Star();
            Star4 = new Star();
            Star5 = new Star();
        }

        private void UpdateZvjezdice()
        {
            var star_emptyinside = new Star { Slika = "star_empty.png" };
            var Star_Filled = new Star { Slika = "star_filled.png" };

            Star1 = star_emptyinside;
            Star2 = star_emptyinside;
            Star3 = star_emptyinside;
            Star4 = star_emptyinside;
            Star5 = star_emptyinside;

            if (Ocjena >= 1)
                Star1 = Star_Filled;
            if (Ocjena >= 2)
                Star2 = Star_Filled;
            if (Ocjena >= 3)
                Star3 = Star_Filled;
            if (Ocjena >= 4)
                Star4 = Star_Filled;
            if (Ocjena == 5)
                Star5 = Star_Filled;
        }

        private async Task OcijeniStar(string ocjena)
        {
            int OcjenaBroj = int.TryParse(ocjena, out int value) ? value : 0;
            if (OcjenaBroj >= 1 && OcjenaBroj <= 5)
            {

                var request = new Model.Requests.OcjeneInsertRequest
                {
                    TuristRutaId = _TuristRutaId,
                    Ocjena = OcjenaBroj
                };

                Ocjena = OcjenaBroj;

                UpdateZvjezdice();

                await _serviceOcjene.Insert<Model.Ocjene>(request, "OcijeniRutu");

                await UcitajRutaDetails();
            }
        }

        public async Task Init()
        {
            await UcitajRutaDetails();

            UpdateZvjezdice();

            await UcitajSlike();

        }

        private async Task UcitajRutaDetails()
        {
            var temp = await _serviceTuristRute.GetById<TuristRuteMobile>(_TuristRutaId);
            Title = temp.Naziv;

            temp.OcjenaKorisnika = await UcitajOcjene();
            temp.OcjenaKriticara = await UcitajRecenzije();
            temp.UkupnaCijena = temp.CijenaPaketa * temp.TrajanjePutovanja + temp.CijenaOsiguranja * temp.TrajanjePutovanja;

            Ruta = temp;

            var request = new Model.Requests.OcjeneSearchRequest
            {
                TuristRutaId = _TuristRutaId,
                KorisnikId = 1// APIService.PrijavljeniKorisnik.KorisniciId
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
                TuristRutaId = _TuristRutaId
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

        private async Task<float> UcitajOcjene()
        {
            var requestOcjene = new Model.Requests.OcjeneSearchRequest
            {
                TuristRutaId = _TuristRutaId
            };
            var Ocjene = await _serviceOcjene.Get<List<Model.Ocjene>>(requestOcjene);
            if (Ocjene.Count == 0)
                return 0;

            double suma = 0;
            foreach (var item in Ocjene)
            {
                suma += item.Ocjena;
            }

            int prosjekInt = (int)(suma / Ocjene.Count * 100);

            return prosjekInt / (float)100;

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
    }
}
