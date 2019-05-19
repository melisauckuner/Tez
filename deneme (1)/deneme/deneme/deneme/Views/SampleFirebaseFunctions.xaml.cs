using deneme.Providers;
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
    public partial class SampleFirebaseFunctions : ContentPage
    {
        FirebaseManager firebaseManager = new FirebaseManager();
        public SampleFirebaseFunctions()
        {
            InitializeComponent();
            GetAllList();
        }

        private async void GetAllList()
        {
            var takenData = await firebaseManager.GetAllPersons();
            lstPersons.ItemsSource = takenData;
        }

        private async void BtnAdd_Clicked(object sender, EventArgs e)
        {
            //await firebaseManager.AddPerson(Convert.ToInt32(txtId.Text), txtName.Text);
            var takenData = await firebaseManager.GetSelectedPerson(1);
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            await DisplayAlert("Success", "Person Added Successfully", "OK");
            var allPersons = await firebaseManager.GetAllPersons();
            lstPersons.ItemsSource = allPersons;
        }

        private void BtnRetrive_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Clicked(object sender, EventArgs e)
        {

        }
    }
}