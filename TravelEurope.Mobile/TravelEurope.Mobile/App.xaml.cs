using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TravelEurope.Mobile.Views;
using TravelEurope.Mobile.ViewsCustom;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TravelEurope.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new KategorijePage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
