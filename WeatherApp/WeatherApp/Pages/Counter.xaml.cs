using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Counter : ContentPage
	{
		public Counter ()
		{
			InitializeComponent ();
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
            if (countInit != 0)
            {
                countInit--;
                this.counter.Text = $"{countInit}";
            }
        }
    }
}