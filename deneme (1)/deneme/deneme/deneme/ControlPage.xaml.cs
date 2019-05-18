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
	public partial class ControlPage : ContentPage
	{
		public ControlPage ()
		{
			InitializeComponent ();
		}

        async void control(object sender, EventArgs e)
        {
            if (txtid.Text == "123")
            {
                await Navigation.PushModalAsync(new Cafe_Campaign());

            }
        }
    }
}