using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RupeeDesk.Views.Lannister
{
    public partial class VerifyOtp : ContentPage
    {
        public VerifyOtp()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
     
        public void LoginClicked(object sender, EventArgs e)
        {
            // if otp is correct
            // Get Customer Details
            // check if new login - push to AddWalletProvider
            // else push to Home Page
            this.Navigation.PushAsync(new AddWalletProviders());
            while (Navigation.NavigationStack.Count > 1)
                Navigation.RemovePage(Navigation.NavigationStack[0]);
        }
    }
}
