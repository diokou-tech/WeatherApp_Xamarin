using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp.Pages.Auth
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PasswordReset : ContentPage
    {
        public PasswordReset()
        {
            InitializeComponent();
        }
        public void home(object sender, EventArgs e)
        {
            Navigation.PopAsync();
            Navigation.PushAsync(new Login());
        }
    }
}