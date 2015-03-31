using System;

using Xamarin.Forms;

namespace Greetings
{
	public class GreetingsPage : ContentPage
	{
		public GreetingsPage ()
		{
			Content = new Label 
			{ 
				Text = "Greetings, Xamarin.Forms!", 
				VerticalOptions = LayoutOptions.Center, 
				HorizontalOptions = LayoutOptions.Center,
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				FontAttributes = FontAttributes.Bold | FontAttributes.Italic
			};
		}

	}
}


