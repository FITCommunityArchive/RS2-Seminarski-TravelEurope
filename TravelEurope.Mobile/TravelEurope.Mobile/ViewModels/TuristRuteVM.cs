using TravelEurope.Mobile.Models;
using TravelEurope.Mobile.ViewsCustom;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using TravelEurope.Model.Requests;
using TravelEurope.Model;

namespace TravelEurope.Mobile.ViewModels
{
    public class TuristRuteVM : BaseViewModel
    {
        private readonly APIService _serviceTuristRute = new APIService("TuristRute");
        private readonly APIService _kategorijePutovanja = new APIService("Kategorije");
        private readonly APIService _servicePretplate = new APIService("Pretplate");

        public ObservableCollection<TuristRuteMobile> RuteList { get; set; } = new ObservableCollection<TuristRuteMobile>();

        private readonly INavigation Navigation;
        public ICommand NavigateToSearchPageCommand { get; set; }
        public ICommand InitCommand { get; set; }

        public ObservableCollection<KategorijeMobile> PretplaceneKategorijePutovanja { get; set; } = new ObservableCollection<KategorijeMobile>();

        KategorijeMobile _selectedKategorijeRuta = null;

        public KategorijeMobile SelectedKategorijeRuta
        {
            get { return _selectedKategorijeRuta; }
            set
            {
                SetProperty(ref _selectedKategorijeRuta, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }

        public TuristRuteVM(INavigation navigation)
        {
            this.Navigation = navigation;
            InitCommand = new Command(async () => await Init());
        }

        private async Task UcitajPretplaceneKategorije()
        {
            var kategorijaPutovanjaList = await _kategorijePutovanja.Get<List<KategorijeMobile>>(null);
            var listPretplate = await _servicePretplate.Get<List<Pretplate>>(null);

            PretplaceneKategorijePutovanja.Clear();
            foreach (var x in kategorijaPutovanjaList)
            {
                foreach (var y in listPretplate)
                {
                    if (x.KategorijaId == y.KategorijaId && y.KorisnikId == APIService.PrijavljeniKorisnik.KorisniciId)
                    {
                        PretplaceneKategorijePutovanja.Add(x);
                    }
                }
            }
        }
        public async Task Init()
        {
            //await UcitajPretplaceneKategorije();

            var kategorijaPutovanjaList = await _kategorijePutovanja.Get<List<KategorijeMobile>>(null);
            var listPretplate = await _servicePretplate.Get<List<Pretplate>>(null);

            PretplaceneKategorijePutovanja.Clear();
            foreach (var x in kategorijaPutovanjaList)
            {
                foreach (var y in listPretplate)
                {
                    if (x.KategorijaId == y.KategorijaId && y.KorisnikId == APIService.PrijavljeniKorisnik.KorisniciId)
                    {
                        PretplaceneKategorijePutovanja.Add(x);
                    }
                }
            }

            TuristRuteSearchRequest search = new TuristRuteSearchRequest();

            if (SelectedKategorijeRuta != null)
            {
                search.KategorijaId = _selectedKategorijeRuta.KategorijaId;
            }

            var listTuristRute = await _serviceTuristRute.Get<List<TuristRuteMobile>>(search, "GetListSaSlikama");

            RuteList.Clear();
            foreach (var item in listTuristRute)
            {
                RuteList.Add(item);
            }
        }
    }
}
