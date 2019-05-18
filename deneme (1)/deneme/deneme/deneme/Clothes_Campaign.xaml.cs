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
    public class Attribute1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
    public partial class Clothes_Campaign : ContentPage
	{
		public Clothes_Campaign ()
		{
            InitializeComponent();
            List<Attribute1> att = new List<Attribute1>();
            att.Add(new Attribute1 { ID = 1, Name = "Zara", ImageUrl = "zara.png" });
            att.Add(new Attribute1 { ID = 2, Name = "Mango", ImageUrl = "mango.png" });
            att.Add(new Attribute1 { ID = 3, Name = "Bershka", ImageUrl = "bershka.png" });
            att.Add(new Attribute1 { ID = 4, Name = "Tudors", ImageUrl = "tudors.png" });
            att.Add(new Attribute1 { ID = 5, Name = "Stradivarius", ImageUrl = "stradivarius.png" });
            att.Add(new Attribute1 { ID = 6, Name = "LC Waikiki", ImageUrl = "lcwaikiki.png" });

            //lstView.ItemsSource = deger;
            lstView.BindingContext = att;
        }

        private void onSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            Attribute1 selected = (Attribute1)e.SelectedItem;
            var Cloth_Campaign = new Cloth_Campaign();

            Navigation.PushAsync(new Cloth_Campaign());
            //ListView lstView = (ListView)sender;
            //lstView.SelectedItem = null;
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