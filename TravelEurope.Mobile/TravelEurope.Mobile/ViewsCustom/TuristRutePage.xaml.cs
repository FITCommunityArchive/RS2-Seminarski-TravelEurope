using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEurope.Mobile.ViewModels;
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
    }
}