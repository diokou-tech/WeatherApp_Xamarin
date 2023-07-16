using System;
using System.Net.Http;
using WeatherApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }
        public void registerUser(object sender, EventArgs e)
        {
            var client = new HttpClient();
            //String url = "https://localhost:7258/api/user";
            var user = new UserInputRegister
            {
                Email = Email.Text,
                UserName = Username.Text,
                PhoneNumber = Telephone.Text,
                Password = Password.Text,
                ConfirmPassword = PasswordConfirm.Text,
            };
            Console.WriteLine(user.UserName);
            //var resultString = await client.PostAsync(url, data);
        }
        public void cancel(object sender, EventArgs e)
        {

        }
        public void show(object sender, EventArgs e)
        {
                Password.IsPassword = !choixPassword.IsChecked;
                PasswordConfirm.IsPassword = !choixPassword.IsChecked;
        }
    }
}