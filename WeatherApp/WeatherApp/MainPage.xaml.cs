using System;
using WeatherApp.Pages;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public async void NextPageAbout(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new About());
        }
        public async void NextPageMeteo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Meteo());
        }
        public async void NextPageUser(object sender, EventArgs e)
        {
            await Navigation.PushAsync( new User());
        }
        public async void NextPageLogin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }
        public async void NextPageRegister(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
        }
        public async void NextTodoPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Todo());
        }        
        public async void NextPageCounter(object sender, EventArgs e)
        {
            await Navigation.PushAsync( new Counter());
        }
    }
}
