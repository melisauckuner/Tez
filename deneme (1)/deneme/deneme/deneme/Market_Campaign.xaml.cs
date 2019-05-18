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
    public class Attribute
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
    public partial class Market_Campaign : ContentPage
	{
		public Market_Campaign ()
		{
			
            InitializeComponent();
            List<Attribute> att = new List<Attribute>();
            att.Add(new Attribute { ID = 1, Name = "Migros", ImageUrl = "migros.png" });
            att.Add(new Attribute { ID = 2, Name = "Çağdaş", ImageUrl = "cagdas.png" });
            att.Add(new Attribute { ID = 3, Name = "Bim", ImageUrl = "bim.png" });
            att.Add(new Attribute { ID = 4, Name = "Metro", ImageUrl = "metro.png" });
            att.Add(new Attribute { ID = 5, Name = "Şok", ImageUrl = "sok.png" });
            att.Add(new Attribute { ID = 6, Name = "Özbesin", ImageUrl = "ozbesin.png" });

            //lstView.ItemsSource = deger;
            lstView.BindingContext = att;
        }

        private void onSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            Attribute selected = (Attribute)e.SelectedItem;
            var Mark_Campaign = new Mark_Campaign();

            Navigation.PushAsync(new Mark_Campaign());
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