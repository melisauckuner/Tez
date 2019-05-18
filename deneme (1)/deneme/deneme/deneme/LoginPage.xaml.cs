using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using deneme.Models;
using deneme.Views;

namespace deneme
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void SignIn(object sender, EventArgs e)
        {
            People userDetail = App.PersonRepo.GetItem(txtuser.Text, txtpassword.Text);

            if (userDetail != null)
            {
                
                if (txtuser.Text != userDetail.Email && txtpassword.Text != userDetail.Password)
                  {
                      await DisplayAlert("Login", "Login failed .. Please try again ", "OK");
                  }
                  else
                  {

                      Application.Current.Properties["PeopleID"] = userDetail.ID;
                      await DisplayAlert("Registrtion", "Login Success ... Now Edit your profile ", "OK");
          if(txtcategoryid.Text=="1")
                    {
                        await Navigation.PushModalAsync(new NotesPage());
                    }
                    
                   

                    
                    
                  }
              }
              else
              {
                  await DisplayAlert("Register", "Login Failed...", "OK");
                  await Navigation.PushModalAsync(new Form());

              } 
            }

        
    


        

        private void SignUp(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Form());
        }

        private void Login_Member(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Anasayfa());
        }
    }



}
