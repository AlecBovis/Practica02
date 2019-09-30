using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practica02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Page1());

            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Grid());

            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new HierchicalNavigations());

            };
            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new TabbedPage1());

            };
            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DatepickerDemo());

            };
        }
    }
}
