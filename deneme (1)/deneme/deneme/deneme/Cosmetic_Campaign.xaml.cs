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
    public class Deger
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
    public partial class Cosmetic_Campaign : ContentPage
	{
		public Cosmetic_Campaign ()
		{
			InitializeComponent ();

            List<Deger> deger = new List<Deger>();
            deger.Add(new Deger { ID = 1, Name = "Gratis", ImageUrl = "gratis.png" });
            deger.Add(new Deger { ID = 2, Name = "Watsons", ImageUrl = "watsons.png" });
            deger.Add(new Deger { ID = 3, Name = "Tekin Acar", ImageUrl = "tekinacar.png" });
            deger.Add(new Deger { ID = 4, Name = "Mac", ImageUrl = "mac.png" });
            deger.Add(new Deger { ID = 5, Name = "Eve", ImageUrl = "eve.png" });
            deger.Add(new Deger { ID = 6, Name = "Rossman", ImageUrl = "rossmann.png" });

            //lstView.ItemsSource = deger;
            lstView.BindingContext = deger;
        }

        private void onSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            Deger selected = (Deger)e.SelectedItem;
            var Cos_Campaign = new Cos_Campaign();

            Navigation.PushAsync(new Cos_Campaign());
            //ListView lstView = (ListView)sender;
            //lstView.SelectedItem = null;
        }
        private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HakkındaPage());
            // ToolbarItem tbi = (ToolbarItem)sender;
            // this.DisplayAlert("Selected!", tbi.Text, "OK");
        }

        private void MenuItem_OnClicked1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}