using Plugin.Fingerprint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InfoAmbiente
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Login();
        }

        public async void Login()
        {
            var result = await CrossFingerprint.Current.IsAvailableAsync(false);

            if (result)
            {
                var auth = await CrossFingerprint.Current.AuthenticateAsync("Use o sensor biométrico");

                if (auth.Authenticated)
                {
                    await Navigation.PushAsync(new Home(true));
                }
                else
                    await Navigation.PushAsync(new Home(false));
            }
            else
                await DisplayAlert("Viish", "O seu smartphone não possui sensor biométrico!", "OK");
        }
    }
}
