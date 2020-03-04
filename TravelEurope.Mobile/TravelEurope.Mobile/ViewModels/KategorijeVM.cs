using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using TravelEurope.Mobile.Models;
using TravelEurope.Model;
using TravelEurope.Model.Requests;
using Xamarin.Forms;

namespace TravelEurope.Mobile.ViewModels
{
    public class KategorijeVM : BaseViewModel
    {
        private readonly APIService _serviceKategorije = new APIService("Kategorije");
        private readonly APIService _servicePretplate = new APIService("Pretplate");
        private readonly APIService _serviceKorisnici = new APIService("Korisnici");

        public ObservableCollection<KategorijeMobile> KategorijeList { get; set; } = new ObservableCollection<KategorijeMobile>();
        public ObservableCollection<KategorijeMobile> PretplaceneKategorijeList { get; set; } = new ObservableCollection<KategorijeMobile>();
        public ObservableCollection<KategorijeMobile> NePretplaceneKategorijeList { get; set; } = new ObservableCollection<KategorijeMobile>();
        public ObservableCollection<Pretplate> PretplateList { get; set; } = new ObservableCollection<Pretplate>();

        private readonly INavigation Navigation;
        public ICommand NavigateToSearchPageCommand { get; set; }
        public ICommand InitCommand { get; set; }

        public KategorijeVM()
        {
            PretplatiCommand = new Command(async () => await Pretplati());
            InitCommand = new Command(async () => await Init());
        }

        public async Task Init()
        {
            //APIService.PrijavljeniKorisnik = await _serviceKorisnici.Get<Model.Korisnici>(null, "MyProfile");
            var listKategorije = await _serviceKategorije.Get<List<KategorijeMobile>>(null);
            var listPretplate = await _servicePretplate.Get<List<Pretplate>>(null);
            var listPretplaceneKategorije = new List<KategorijeMobile>();
            var listNepretplaceneKategorije = new List<KategorijeMobile>();

            foreach(var x in listKategorije)
            {
                foreach(var y in listPretplate)
                {
                    if(x.KategorijaId == y.KategorijaId && y.KorisnikId == 1)//APIService.PrijavljeniKorisnik.KorisniciId)
                    {
                        listPretplaceneKategorije.Add(x);
                    }
                }
            }

            foreach (var x in listKategorije)
            {
                foreach (var y in listPretplaceneKategorije)
                {
                    if (x.KategorijaId != y.KategorijaId)//APIService.PrijavljeniKorisnik.KorisniciId)
                    {
                        listNepretplaceneKategorije.Add(x);
                    }
                }
            }


            PretplaceneKategorijeList.Clear();
            foreach (var item in listPretplaceneKategorije)
            {
                PretplaceneKategorijeList.Add(item);
            }

            NePretplaceneKategorijeList.Clear();
            foreach (var item in listNepretplaceneKategorije)
            {
                NePretplaceneKategorijeList.Add(item);
            }
        }

        public ICommand PretplatiCommand { get; set; }
        public KategorijeMobile SelectedKategorija { get; set; }

        public async Task AddPretplate(PretplateInsertRequest request)
        {
            var entity = await _servicePretplate.Insert<Model.Pretplate>(request);
        }

        public async Task Pretplati()
        {
            try
            {
                PretplateInsertRequest korak = new PretplateInsertRequest();
                korak.KategorijaId = SelectedKategorija.KategorijaId;
                korak.KorisnikId = 1;
                await AddPretplate(korak);
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "OK");
            }
        }

        bool _provjera = false;
        public bool Provjera
        {
            get { return _provjera; }
            set { SetProperty(ref _provjera, value); }
        }
    }
}
