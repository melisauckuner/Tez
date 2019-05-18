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
    public class Value1
    {
        public int ID { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
    public partial class Cloth_Campaign : ContentPage
	{
		public Cloth_Campaign ()
		{
            InitializeComponent();
            List<Value1> value = new List<Value1>();
            value.Add(new Value1 { ID = 1, Description = "Tüm Ürünlerde %60 a Varan İndirimler!", ImageUrl = "star.png" });
            value.Add(new Value1 { ID = 2, Description = "Jean Çeşitlerinde 2.si %50 İndirimli! ", ImageUrl = "star.png" });
            value.Add(new Value1 { ID = 3, Description = "Trikolarda 3 Al 2 Öde!", ImageUrl = "star.png" });
            value.Add(new Value1 { ID = 4, Description = "Yeni Sezon Ürünlerinde %20 İndirim!", ImageUrl = "star.png" });
            value.Add(new Value1 { ID = 5, Description = "150 TL ve Üzeri Alışverişlerde 50 TL İndirim!", ImageUrl = "star.png" });
            value.Add(new Value1 { ID = 6, Description = "Mont ve Kabanlarda %70 İndirim!", ImageUrl = "star.png" });

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