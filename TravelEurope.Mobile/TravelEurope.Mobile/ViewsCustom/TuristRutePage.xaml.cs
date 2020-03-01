using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEurope.Mobile.ViewModels;
using TravelEurope.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelEurope.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TuristRutePage : ContentPage
	{
        private TuristRutaVM model;
		public TuristRutePage ()
		{
			InitializeComponent ();
            BindingContext = model = new TuristRutaVM();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private void FilterToolbarItem_Clicked(object sender, EventArgs e)
        {

        }

        //private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var item = e.SelectedItem as Kategorije;
        //    await Navigation.PushAsync(new ProizvodDetailPage(item));
        //}
    }
}