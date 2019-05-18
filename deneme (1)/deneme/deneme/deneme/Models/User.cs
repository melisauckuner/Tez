using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace deneme.Models
{
	public class User : ContentPage
	{
		
		
            public User(String username, String Pass)
            {
                username = Username;
                Pass = Password;

            }

        public string Username { get; set; }
        public string Password { get; set; }


    }

}
