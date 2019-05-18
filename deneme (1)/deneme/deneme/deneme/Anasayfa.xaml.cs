using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamd.ImageCarousel.Forms.Plugin.Abstractions;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace deneme
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Anasayfa : ContentPage
	{


        ObservableCollection<FileImageSource> imageSources = new ObservableCollection<FileImageSource>();
        public Anasayfa()
        {
            InitializeComponent();

            imageSources.Add("tudors.png");
            imageSources.Add("migroskampanya.PNG");
            imageSources.Add("kampdominos.png");
            imageSources.Add("rossmann.png");


            imgSlider.Images = imageSources;
        }
    




private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HakkındaPage());

        }

        private void Click_Cafe(object sender, EventArgs e)
        {
          Navigation.PushAsync(new Page1());
        }

        private void Click_Cosmetic(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        private void Click_Clothes(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }

        private void Click_Market(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page4());
        }

        private void MenuItem_OnClicked1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}