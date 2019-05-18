using deneme.Models;
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
	public partial class NotesPage : ContentPage
	{
		public NotesPage ()
		{
			InitializeComponent ();
		}

       

        protected override async void OnAppearing()
        {
            base.OnAppearing();
           

            listView.ItemsSource = await App.Database.GetNotesAsync();

            //   int PID = (int)App.Current.Properties["PeopleID"];
            //   listView.ItemsSource = await App.Database.GetNoteAsync(PID);

        }

        async void OnNoteAddedClicked(object sender, EventArgs e)
        {
            
            await Navigation.PushModalAsync(new AddCampaign
            {
                BindingContext = new Note()
            });

        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushModalAsync(new AddCampaign
                {
                    BindingContext = e.SelectedItem as Note
                });
            }
        }

        private void onClicked(object sender, EventArgs e)
        {
          Navigation.PushModalAsync(new LoginPage());

        }
    }
}