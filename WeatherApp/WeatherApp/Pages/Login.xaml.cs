using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public const string _user  = "zola";
        public const string _pass  = "passer";
        public Login()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            rememberMe.IsChecked = true;
        }
        public async void GoHomePage(object sender, EventArgs e)
        {
            var user = email.Text;
            var pass = motPasse.Text;
            if (CheckLogin(user, pass))
            {
                await Navigation.PopAsync();
                await Navigation.PushAsync(new MainPage());
            }
        }       
        public async void registerPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
        }
        public void ShowPassword(object sender, EventArgs e)
        {
            bool initState = motPasse.IsPassword;
            motPasse.IsPassword = !initState;
            if (initState == true)
            {
                checkedShowLabel.Text = "Masquer le mot de passe";
            }
            else
            {
                checkedShowLabel.Text = "Afficher le mot de passe";
            }
        }
        protected bool CheckLogin(string user, string passxord)
        {
            if(user == null || passxord == null)
            {
                ErrorMessage.IsVisible = true;
                TextError.Text = "Veuillez entrer les informations !";
                return false;
            }
            if(user != _user && passxord != _pass)
            {
                ErrorMessage.IsVisible = true;
                TextError.Text = "Identifiants incorrects !";
                return false;
            }
            return true;
        }
    }
}