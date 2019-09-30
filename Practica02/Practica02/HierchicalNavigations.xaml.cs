﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica02
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HierchicalNavigations : ContentPage
	{
		public HierchicalNavigations ()
		{
			InitializeComponent ();
            btnClose.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync();
            };
        }
        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}