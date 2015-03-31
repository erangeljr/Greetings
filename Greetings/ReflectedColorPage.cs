﻿using System;
using System.Reflection;

using Xamarin.Forms;

namespace Greetings
{
	public class ReflectedColorPage : ContentPage
	{
		public ReflectedColorPage ()
		{
			StackLayout stackLayout = new StackLayout ();

			foreach(FieldInfo info in typeof(Color).GetRuntimeFields())
			{
				if (info.GetCustomAttribute<ObsoleteAttribute>() != null)
					continue;

				if(info.IsPublic &&
					info.IsStatic &&
					info.FieldType == typeof(Color))
				{
					stackLayout.Children.Add (
						CreateColorLabel((Color)info.GetValue(null),info.Name));
				}
			}


			Padding = new Thickness (5, Device.OnPlatform(20, 5, 5), 5, 5);
			Content = new ScrollView { 
				Content = stackLayout
			};
		}

		Label CreateColorLabel (Color color, string name)
		{
			Color backgroundColor = Color.Default;

			if(color != Color.Default)
			{
				// Standard luminance calculation 
				double luminance = 
						0.30 * color.R + 
						0.59 * color.G + 
						0.11 * color.B;
				
				backgroundColor = luminance > 0.5 ? Color.Black : Color.White;
			}

			return new Label {
				Text = name,
				TextColor = color,
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
				BackgroundColor = backgroundColor
			};
		}
	}
}


