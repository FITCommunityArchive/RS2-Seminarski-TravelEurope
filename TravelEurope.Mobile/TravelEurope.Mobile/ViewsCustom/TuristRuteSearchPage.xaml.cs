using TravelEurope.Mobile.Models;
using TravelEurope.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelEurope.Mobile.ViewsCustom
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TuristRuteSearchPage : ContentPage
    {
        private TuristRuteSearchViewModel model;

        public TuristRuteSearchPage(Model.Requests.TuristickeRuteSearchRequest request = null)
        {
            InitializeComponent();
            BindingContext = model = new TuristRuteSearchViewModel(request);
        }

        private async void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            await model.Search();

        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                TuristRuteMobile igra = e.Item as TuristRuteMobile;
                Navigation.PushAsync(new GameDetailsPage(igra.IgraId));
            }
        }
    }
}