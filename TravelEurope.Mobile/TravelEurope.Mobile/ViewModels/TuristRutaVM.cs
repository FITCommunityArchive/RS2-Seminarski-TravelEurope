using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using TravelEurope.Mobile.Models;
using Xamarin.Forms;

namespace TravelEurope.Mobile.ViewModels
{
    public class TuristRutaVM : BaseViewModel
    {
        private readonly APIService _serviceTuristRuta = new APIService("TuristRuta");

        public ObservableCollection<TuristRuteMobile> RuteList { get; set; } = new ObservableCollection<TuristRuteMobile>();
        private TuristRuteMobile _featuredRuta;

        private readonly INavigation Navigation;
        public ICommand NavigateToSearchPageCommand { get; set; }
        public ICommand InitCommand { get; set; }

        //public TuristRuteMobile FeaturedRuta
        //{
        //    get { return _featuredRuta; }

        //    set { SetProperty(ref _featuredRuta, value); }
        //}

        public async Task Init()
        {
            //var listRute = await _serviceTuristRuta.Get<List<TuristRuteMobile>>(null, "GetListSaSlikama");
            var listRute = await _serviceTuristRuta.Get<List<TuristRuteMobile>>(null);

            //if (listRute.Count > 0)
            //{
            //    FeaturedRuta = listRute[0];
            //    listRute.RemoveAt(0);
            //}

            RuteList.Clear();
            foreach (var item in listRute)
            {
                RuteList.Add(item);
            }
        }
    }
}
