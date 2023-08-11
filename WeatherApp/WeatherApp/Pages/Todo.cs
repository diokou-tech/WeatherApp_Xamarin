using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace WeatherApp.Pages
{
	public class Todo : ContentPage
	{
		public Todo ()
		{
			Content = new StackLayout {
				Margin = 4,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					new Button {
						Text ="Retour", TextColor = Color.Orange
					},
					GetButton("Add"),
					GetButton("Clear"),
				new StackLayout
				{
					 Margin = 4,
					 HorizontalOptions = LayoutOptions.CenterAndExpand, 
					Children = {
						new Label
						{
							Text = "Item 1"
						},
                        new Label
                        {
                            Text = "Item 2"
                        }
                    }
				}
				},
			};
		}
		public void Add()
		{
			
		}
		public void Remove()
		{

		}
		public Button GetButton(string txt)
		{
			return new Button { Text = txt, TextColor = Color.DarkGray };
		}
	}
}