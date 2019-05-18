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
    public class Factory
    {
        public int ID { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
    public partial class Cafe_Campaign : ContentPage
	{
		public Cafe_Campaign ()
		{
            InitializeComponent();

            List<Factory> factory = new List<Factory>();
            factory.Add(new Factory { ID = 1, Description = "Filtre kahve alana mozaik pasta 5 tl", ImageUrl = "star.png" });
            factory.Add(new Factory { ID = 2, Description = "Filtre kahve alana mozaik pasta 5 tl", ImageUrl = "star.png" });
            factory.Add(new Factory { ID = 3, Description = "Filtre kahve alana mozaik pasta 5 tl", ImageUrl = "star.png" });
            factory.Add(new Factory { ID = 4, Description = "Filtre kahve alana mozaik pasta 5 tl", ImageUrl = "star.png" });
            factory.Add(new Factory { ID = 5, Description = "Filtre kahve alana mozaik pasta 5 tl", ImageUrl = "star.png" });
            factory.Add(new Factory { ID = 6, Description = "Filtre kahve alana mozaik pasta 5 tl", ImageUrl = "star.png" });
            factory.Add(new Factory { ID = 7, Description = "Filtre kahve alana mozaik pasta 5 tl", ImageUrl = "star.png" });
            factory.Add(new Factory { ID = 8, Description = "Filtre kahve alana mozaik pasta 5 tl", ImageUrl = "star.png" });
            factory.Add(new Factory { ID = 9, Description = "Filtre kahve alana mozaik pasta 5 tl", ImageUrl = "star.png" });
            factory.Add(new Factory { ID = 10, Description = "Filtre kahve alana mozaik pasta 5 tl", ImageUrl = "star.png" });
            // lstView.ItemsSource = deger;
            lstView.BindingContext = factory;
        }
        private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HakkındaPage());
        }

        private void MenuItem_OnClicked1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}