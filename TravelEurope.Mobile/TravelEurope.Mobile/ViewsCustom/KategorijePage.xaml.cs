using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TravelEurope.Mobile.ViewModels;
using TravelEurope.Model;
using TravelEurope.Model.Requests;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelEurope.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KategorijePage : ContentPage
    {
        public KategorijeVM model;
        public KategorijePage()
        {
            InitializeComponent();
            BindingContext = model = new KategorijeVM();
        }

    
        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            if (!model.Provjera)
            {
                await Application.Current.MainPage.DisplayAlert("Obavijest", "Uspješno ste se pretplatili na novu kategoriju!", "OK");
                Page p = Navigation.NavigationStack[Navigation.NavigationStack.Count - 1];
                await model.Init();
            }
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}