using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Meteo : ContentPage
	{
		public String _defaultRegion { get; set; } = "Dakar";
		public Meteo ()
		{
			InitializeComponent ();
		}
		public async void Getregion(object sender, EventArgs e)
		{
			var textregion = this.region.Text;
			if (string.IsNullOrEmpty(textregion))
			{
				HttpClient client = new HttpClient();
				var resultString = await client.GetAsync("");
				if (resultString.IsSuccessStatusCode)
				{

				}
			}
		}

    }
}