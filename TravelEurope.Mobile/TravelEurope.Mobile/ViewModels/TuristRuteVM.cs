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


        KategorijeMobile _selectedPretplaceneKategorijePutovanja = null;

        public KategorijeMobile SelectedKategorijaPutovanja
        {
            get { return _selectedPretplaceneKategorijePutovanja; }
            set
            {
                SetProperty(ref _selectedPretplaceneKategorijePutovanja, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }

        public TuristRuteVM()
        {
            InitCommand = new Command(async () => await Init());
        }

        private async Task NavigateToSearchPage()
        {
            //await Navigation.PushAsync(new TuristRuteSearchPage());
        }

        public async Task Init()
        {
            if (PretplaceneKategorijePutovanja.Count == 0)
            {
                var kategorijaPutovanjaList = await _kategorijePutovanja.Get<List<KategorijeMobile>>(null);
                var listPretplate = await _servicePretplate.Get<List<Pretplate>>(null);

                foreach (var x in kategorijaPutovanjaList)
                {
                    foreach (var y in listPretplate)
                    {
                        if (x.KategorijaId == y.KategorijaId && y.KorisnikId == 1)//APIService.PrijavljeniKorisnik.KorisniciId)
                        {
                            PretplaceneKategorijePutovanja.Add(x);
                        }
                    }
                }
            }

            TuristRuteSearchRequest search = new TuristRuteSearchRequest();

            if (SelectedKategorijaPutovanja != null)
            {
                search.KategorijaId = _selectedPretplaceneKategorijePutovanja.KategorijaId;
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
