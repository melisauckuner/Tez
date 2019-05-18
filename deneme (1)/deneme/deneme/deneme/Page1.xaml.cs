using deneme.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace deneme
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}

        private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HakkındaPage());
        }
        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void Cafe_Sonuc(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Liste());
        }

        private void MenuItem_OnClicked1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}