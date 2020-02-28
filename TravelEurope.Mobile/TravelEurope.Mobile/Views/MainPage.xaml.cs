using TravelEurope.Mobile.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelEurope.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Ponuda, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    //case (int)MenuItemType.Friends:
                    //    MenuPages.Add(id, new NavigationPage(new FriendsPage()));
                    //    break;
                    //case (int)MenuItemType.Games:
                    //    MenuPages.Add(id, new NavigationPage(new GamesPage()));
                    //    break;
                    //case (int)MenuItemType.Logout:
                    //    MenuPages.Add(id, new NavigationPage(new LoginPage()));
                    //    break;
                    //case (int)MenuItemType.Favorites:
                    //    MenuPages.Add(id, new NavigationPage(new FavoritesPage()));
                    //    break;
                    //case (int)MenuItemType.Recommendations:
                    //    MenuPages.Add(id, new NavigationPage(new RecommendedGamesPage()));
                    //    break;
                    case (int)MenuItemType.Ponuda:
                        MenuPages.Add(id, new NavigationPage(new TuristRutePage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}