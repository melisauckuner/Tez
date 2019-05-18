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
    public class Value
    {
        public int ID { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
    public partial class Mark_Campaign : ContentPage
	{
		public Mark_Campaign ()
		{
            InitializeComponent();
            List<Value> value = new List<Value>();
            value.Add(new Value { ID = 1, Description = "Temizlik Ürünlerinde %50 ye Varan İndirimler!", ImageUrl = "star.png" });
            value.Add(new Value { ID = 2, Description = "Et ve Tavuk Çeşitlerinde 2.si %40 İndirimli! ", ImageUrl = "star.png" });
            value.Add(new Value { ID = 3, Description = "Eti Ürünlerinde 4 Al 3 Öde", ImageUrl = "star.png" });
            value.Add(new Value { ID = 4, Description = "Bir Islak Mendil alana 2.si 2.99! ", ImageUrl = "star.png" });
            value.Add(new Value { ID = 5, Description = "30 TL ve Üzeri Alışverişlerinizde Domestos Çamaşır Suyu 4.99!", ImageUrl = "star.png" });
            value.Add(new Value { ID = 6, Description = "Havlu Kağıt Alana 10'lu Kağıt Mendil Yarı Fiyatına!", ImageUrl = "star.png" });

            // lstView.ItemsSource = deger;
            lstView.BindingContext = value;
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