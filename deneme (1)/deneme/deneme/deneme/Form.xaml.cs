using SQLite;
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
    public partial class Form : ContentPage
    {
        public Form()
        {
            InitializeComponent();
        }



        async void Sign_Up(object sender, EventArgs e)
        {
            

            if (txtuserid.Text != "")
            {
                People fileexist = App.PersonRepo.GetItem(txtuserid.Text);
                if (fileexist == null)
                {
                    if (txtuser.Text != "" && txtpassword.Text != "" && txtuserid.Text != "")
                    {
                        People OReg = new People();
                        OReg.Email = txtuser.Text;
                      //  OReg.UserID = txtuserid.Text;
                        OReg.Password = txtpassword.Text;
                        int i = App.PersonRepo.SaveItem(OReg);
                        if (i > 0)
                        {
                            await DisplayAlert("Registrtion", "Registrtion Success ... Login and Edit profile ", "OK");
                             await Navigation.PushAsync(new LoginPage());
                            
                        }
                        else
                        {
                            await DisplayAlert("Registrtion", "Registrtion Fail .. Please try again ", "OK");
                        }
                    }
                }
                else
                {
                    await DisplayAlert("Registrtion Failed", "username already exist .. Please try differnt user name ", "OK");
                    txtuserid.Text = "";
                    txtuserid.Focus();

                }
            }

        }
   
    }
}

