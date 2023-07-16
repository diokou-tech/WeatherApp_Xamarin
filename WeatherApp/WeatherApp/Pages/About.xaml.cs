using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class About : ContentPage
	{
		public About ()
		{
			InitializeComponent ();
		}
		public void TextChangedLabel(object sender, TextChangedEventArgs e)
		{
			var textchanged = e.NewTextValue;
			this.emailChanged.Text = " Value changes : "  +textchanged;
        }
        public void TextCompletedLabel(object sender,  EventArgs e)
        {
            var val = this.email.Text;
            this.emailCompleted.Text = " value completed : " + val;
        }
    }
}