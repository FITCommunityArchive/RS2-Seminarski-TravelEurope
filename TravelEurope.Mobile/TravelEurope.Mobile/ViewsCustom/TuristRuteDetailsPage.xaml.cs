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
    public partial class TuristRuteDetailsPage : ContentPage
    {
        private int _rutaId;
        private TuristRuteDetailsVM model;

        public TuristRuteDetailsPage(int rutaId)
        {
            InitializeComponent();
            _rutaId = rutaId;
            BindingContext = model = new TuristRuteDetailsVM(_rutaId);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var element = sender as StackLayout;
            var context = element.BindingContext as Model.RuteSlike;

            model.PrikazanaSlika = context.Slika;
            for (int i = 0; i < model.SlikeList.Count; i++)
            {
                if (model.SlikeList[i].RuteSlikeId == context.RuteSlikeId)
                {
                    model.TrenutnaSlika = i;
                    break;
                }
            }
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            if (!model.Provjera)
            {
                await Application.Current.MainPage.DisplayAlert("Obavijest", "Uspješno ste rezervisali putovanje!", "OK");
                Page p = Navigation.NavigationStack[Navigation.NavigationStack.Count - 1];
                //Navigation.InsertPageBefore(new MyRidesPage(model.KlijentID), p);
                await Navigation.PopAsync();
            }
        }

        private async void SwipeGestureRecognizer_Swiped_Left(object sender, SwipedEventArgs e)
        {
            if (model.TrenutnaSlika < model.SlikeList.Count - 1)
            {
                uint transitionTime = 300;
                double displacement = PrikazanaSlikaImage.Width;

                await Task.WhenAll(
                    PrikazanaSlikaImage.FadeTo(0, transitionTime, Easing.Linear),
                    PrikazanaSlikaImage.TranslateTo(-displacement, PrikazanaSlikaImage.Y, transitionTime, Easing.CubicInOut));

                model.TrenutnaSlika++;
                if (model.TrenutnaSlika >= model.SlikeList.Count)
                    model.TrenutnaSlika = model.SlikeList.Count - 1;

                model.PrikazanaSlika = model.SlikeList[model.TrenutnaSlika].Slika;

                await PrikazanaSlikaImage.TranslateTo(displacement, 0, 0);
                await Task.WhenAll(
                    PrikazanaSlikaImage.FadeTo(1, transitionTime, Easing.Linear),
                    PrikazanaSlikaImage.TranslateTo(0, PrikazanaSlikaImage.Y, transitionTime, Easing.CubicInOut));
            }
        }

        private async void SwipeGestureRecognizer_Swiped_Right(object sender, SwipedEventArgs e)
        {
            if (model.TrenutnaSlika > 0)
            {
                uint transitionTime = 300;
                double displacement = PrikazanaSlikaImage.Width;

                await Task.WhenAll(
                    PrikazanaSlikaImage.FadeTo(0, transitionTime, Easing.Linear),
                    PrikazanaSlikaImage.TranslateTo(displacement, PrikazanaSlikaImage.Y, transitionTime, Easing.CubicInOut));

                model.TrenutnaSlika--;
                if (model.TrenutnaSlika < 0)
                    model.TrenutnaSlika = 0;

                model.PrikazanaSlika = model.SlikeList[model.TrenutnaSlika].Slika;

                await PrikazanaSlikaImage.TranslateTo(-displacement, 0, 0);
                await Task.WhenAll(
                    PrikazanaSlikaImage.FadeTo(1, transitionTime, Easing.Linear),
                    PrikazanaSlikaImage.TranslateTo(0, PrikazanaSlikaImage.Y, transitionTime, Easing.CubicInOut));
            }
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}
