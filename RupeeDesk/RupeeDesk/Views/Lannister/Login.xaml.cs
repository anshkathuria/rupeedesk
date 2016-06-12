using RupeeDesk.Data;
using RupeeDesk.Views.Lannister;
using System;

using Xamarin.Forms;

namespace RupeeDesk
{
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
			NavigationPage.SetHasNavigationBar(this,false);
        }

        // TODO: send phone number to verify otp page
        public void SendOtpClicked(object sender, EventArgs e)
        {
            if(phNo.Text.Length > 0)
            {
                GlobalData.PHONE_NUMBER = phNo.Text;
                this.Navigation.PushAsync(new VerifyOtp());
                while (Navigation.NavigationStack.Count > 1)
                    Navigation.RemovePage(Navigation.NavigationStack[0]);
            }
        }
    }
}

