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
    public partial class KategorijePage : ContentPage
    {
        private KategorijeVM model;
        public KategorijePage()
        {
            InitializeComponent();
            BindingContext = model = new KategorijeVM();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private void FilterToolbarItem_Clicked(object sender, EventArgs e)
        {

        }
    }
}