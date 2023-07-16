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
        public void ChangeColor(object sender,EventArgs e)
        {
            Console.WriteLine("Change color btn");
            Button btnValider = (Button)sender;
            if(btnValider.Text != "Clicked")
            {
            btnValider.Text = "Clicked";
            btnValider.BackgroundColor = Color.Wheat;
            btnValider.TextColor = Color.Black;
            }
            else
            {
                btnValider.Text = "valider";
                btnValider.BackgroundColor = Color.Teal;
            }

        }
        public void Increment(Object sender, EventArgs e)
        {
            var countInit = int.Parse(this.counter.Text);
            countInit++;
            this.counter.Text = $"{countInit}";
        }
        public void Decrement(Object sender, EventArgs e)
        {
            var countInit = int.Parse(this.counter.Text);
            if(countInit != 0)
            {
            countInit--;
            this.counter.Text = $"{countInit}";
            }
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
        
        public void ShowPassword(object sender, EventArgs e)
        {
            bool initState = motPasse.IsPassword;
            motPasse.IsPassword = !initState;
            Button btn = (Button)sender;
            if (initState == true)
            {
                btn.Text = "Masquer le mot de passe";
            }
            else
            {
                btn.Text = "afficher le mot de passe";
            }
        }
    }
}
