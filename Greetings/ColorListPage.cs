using System;

using Xamarin.Forms;

namespace Greetings
{
	public class ColorListPage : ContentPage
	{
		public ColorListPage ()
		{
			Content = new StackLayout { 
				Spacing = 0,
				Children = {
					new Label{
						Text = "White",
						TextColor = Color.White,
						FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label))
					},
					new Label{
						Text = "Silver",
						TextColor = Color.Silver,
						FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label))
					},
					new Label{
						Text = "Gray",
						TextColor = Color.Gray,
						FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label))
					},
					new Label{
						Text = "Black",
						TextColor = Color.Black,
						FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label))
					},
					new Label{
						Text = "Red",
						TextColor = Color.Red,
						FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label))
					},
					new Label{
						Text = "Maroon",
						TextColor = Color.Maroon,
						FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label))
					},
					new Label{
						Text = "Yellow",
						TextColor = Color.Yellow,
						FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label))
					},
					new Label{
						Text = "Olive",
						TextColor = Color.Olive,
						FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label))
					},
					new Label{
						Text = "Lime",
						TextColor = Color.Lime,
						FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label))
					},
					new Label{
						Text = "Green",
						TextColor = Color.Green,
						FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label))
					},
					new Label{
						Text = "Aqua",
						TextColor = Color.Aqua,
						FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label))
					},
					new Label{
						Text = "Teal",
						TextColor = Color.Teal,
						FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label))
					},
					new Label{
						Text = "Blue",
						TextColor = Color.Blue,
						FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label))
					},
					new Label{
						Text = "Navy",
						TextColor = Color.Navy,
						FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label))
					},
					new Label{
						Text = "Pink",
						TextColor = Color.Pink,
						FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label))
					},
					new Label{
						Text = "Fuchsia",
						TextColor = Color.Fuchsia,
						FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label))
					},
					new Label{
						Text = "Purple",
						TextColor = Color.Purple,
						FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label))
					}
				}
			};
		}
	}
}


