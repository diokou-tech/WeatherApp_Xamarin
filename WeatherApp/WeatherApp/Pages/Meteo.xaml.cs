using System;
using System.Net.Http;

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
			//Button btn = new Button() { Text ="Cliquer" };
			//Content = new StackLayout
			//{
			//	Children =
			//	{
			//		new ScrollView
			//		{
			//			VerticalOptions = LayoutOptions.FillAndExpand,
			//			Content = new StackLayout
			//			{
			//				Children =	
			//				{
			//					btn
			//				}
			//			}
			//		}
			//	}
			//};
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