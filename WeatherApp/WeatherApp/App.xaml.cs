using System;
using WeatherApp.Pages;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[] {"MediaElement_Experimental", "Brush_Experimental"});
            MainPage = new NavigationPage(new Login());
        }
        protected override void OnStart()
        {
            Console.WriteLine("On start !");
        }
        protected override void OnSleep()
        {
            Console.WriteLine("On sleep !");
        }
        protected override void OnResume()
        {
            Console.WriteLine("On resume !");
        }
    }
}
