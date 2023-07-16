using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp.Styles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomStyleEntry : ContentPage
    {
        public CustomStyleEntry()
        {
            InitializeComponent();
        }
    }
}