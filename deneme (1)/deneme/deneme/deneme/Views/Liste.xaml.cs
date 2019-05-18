using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace deneme.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public class Deger

    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

    }

    public partial class Liste : ContentPage

    {

        public Liste()

        {

            InitializeComponent();

            List<Deger> deger = new List<Deger>();

            deger.Add(new Deger { ID = 1, Name = "Gaga", ImageUrl = "gaga.png" });

            deger.Add(new Deger { ID = 2, Name = "Kahve Dünyası", ImageUrl = "kahve.png" });

            deger.Add(new Deger { ID = 3, Name = "Starbucks", ImageUrl = "starbucks.png" });

            deger.Add(new Deger { ID = 4, Name = "Arabica", ImageUrl = "arabica.png" });

            deger.Add(new Deger { ID = 5, Name = "Burger", ImageUrl = "burger.png" });

            deger.Add(new Deger { ID = 6, Name = "Dominos", ImageUrl = "dominos.png" });

            //lstView.ItemsSource = deger;

            lstView.BindingContext = deger;

        }


        async void onSelected(object sender, SelectedItemChangedEventArgs e)

        {

            if (e.SelectedItem == null)

                return;

            Deger selected = (Deger)e.SelectedItem;
            var Cafe_Campaign = e.SelectedItem as Deger;
            switch (selected.ID) {
                case 1 :
                     await Navigation.PushAsync(new MüsteriCampaign());
                    break;
                case 2:
                    await Navigation.PushAsync(new Cafe_Campaign());
                    break;
                case 3:
                    await Navigation.PushAsync(new Cafe_Campaign());
                    break;
                case 4:
                    await Navigation.PushAsync(new Cafe_Campaign());
                    break;
                case 5:
                    await Navigation.PushAsync(new Cafe_Campaign());
                    break;
                case 6:
                    await Navigation.PushAsync(new Cafe_Campaign());
                    break;
            }
               ((ListView)sender).SelectedItem = null;
            // var Cafe_Campaign = new NotesPage();



            //  Navigation.PushAsync(new NotesPage());

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