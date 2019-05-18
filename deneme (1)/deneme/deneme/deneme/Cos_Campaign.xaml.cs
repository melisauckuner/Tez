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
    public class Fact
    {
        public int ID { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
    public partial class Cos_Campaign : ContentPage
	{
		public Cos_Campaign ()
		{
			

            InitializeComponent();
            List<Fact> factory = new List<Fact>();
            factory.Add(new Fact { ID = 1, Description = "Cilt Bakımı Ürünlerinde %50 İndirim!", ImageUrl = "star.png" });
            factory.Add(new Fact { ID = 2, Description = "Parfüm ve Deodorant Çeşitlerinde %20 İndirim! ", ImageUrl = "star.png" });
            factory.Add(new Fact { ID = 3, Description = "Pastel Ürünlerinde 1 Alana 1 Bedava!", ImageUrl = "star.png" });
            factory.Add(new Fact { ID = 4, Description = "Bir Oje Alana 2. si 1.99!", ImageUrl = "star.png" });
            factory.Add(new Fact { ID = 5, Description = "30 TL ve Üzeri Alışverişlerinizde Palmolive Duş Jeli 10.99!", ImageUrl = "star.png" });
            factory.Add(new Fact { ID = 6, Description = "Maybelline Far Paletlerinde %25 İndirim!", ImageUrl = "star.png" });

            // lstView.ItemsSource = deger;
            lstView.BindingContext = factory;
        }
        private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            ToolbarItem tbi = (ToolbarItem)sender;
            this.DisplayAlert("Selected!", tbi.Text, "OK");
        }

        private void MenuItem_OnClicked1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}