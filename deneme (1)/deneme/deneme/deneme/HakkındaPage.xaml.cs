using Plugin.Messaging;
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
	public partial class HakkındaPage : ContentPage
	{
		public HakkındaPage ()
		{
			InitializeComponent ();
		}

        private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HakkındaPage());
        }

        private void MenuItem_OnClicked1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        private void BtnCall_Click(object sender, EventArgs e)
        {

            var PhoneCallTask = CrossMessaging.Current.PhoneDialer;
            if (PhoneCallTask.CanMakePhoneCall)
                PhoneCallTask.MakePhoneCall("2222222222");
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            var EmailTask = CrossMessaging.Current.EmailMessenger;

            if (EmailTask.CanSendEmail)
                EmailTask.SendEmail("kampanyanerede@hotmail.com", EmailSubject.Text, EmailBody.Text);
        }
    }
}