using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEurope.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelEurope.Mobile.ViewsCustom
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RezervacijeDetailsPage : ContentPage
    {
        private int _rezervacijaId;
        private int _korisnikId;
        private RezervacijeDetailsVM model;

        public RezervacijeDetailsPage(int rezervacijaId, int korisnikId)
        {
            InitializeComponent();
            _rezervacijaId = rezervacijaId;
            _korisnikId = korisnikId;
            BindingContext = model = new RezervacijeDetailsVM(_rezervacijaId, _korisnikId);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}
