using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using TravelEurope.Mobile.Models;
using Xamarin.Forms;

namespace TravelEurope.Mobile.ViewModels
{
    public class KategorijeVM : BaseViewModel
    {
        private readonly APIService _serviceKategorije = new APIService("Kategorija");

        public ObservableCollection<KategorijeMobile> KategorijeList { get; set; } = new ObservableCollection<KategorijeMobile>();

        private readonly INavigation Navigation;
        public ICommand NavigateToSearchPageCommand { get; set; }
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var listKategorije = await _serviceKategorije.Get<List<KategorijeMobile>>(null);

            //if (listRute.Count > 0)
            //{
            //    FeaturedRuta = listRute[0];
            //    listRute.RemoveAt(0);
            //}

            KategorijeList.Clear();
            foreach (var item in listKategorije)
            {
                KategorijeList.Add(item);
            }
        }
    }
}
