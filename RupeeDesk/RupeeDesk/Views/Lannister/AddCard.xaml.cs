using RupeeDesk.Data;
using RupeeDesk.Models.Lannister;
using RupeeDesk.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RupeeDesk.Views.Lannister
{
    public partial class AddCard : ContentPage
    {
        FireSharpClient firesharpClient = FireSharpClient.Instance;
        public AddCard()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        // TODO: on save - send to firebase and navigate to home

        public async void SaveClicked(object sender, EventArgs e)
        {
            if(cardNo.Text.Length > 0 && mm.Text.Length > 0 && yyyy.Text.Length > 0)
            {
                GlobalData.USER_CARD = new Models.Lannister.Card { CardNumber = cardNo.Text, ExpiryMonth = mm.Text, ExpiryYear = yyyy.Text };
                // Save to firebase
                FirebaseUser user = new FirebaseUser { PhoneNumber = GlobalData.PHONE_NUMBER, UserCard = GlobalData.USER_CARD, UserWallets = GlobalData.USER_WALLETS };
                GlobalData.USER_RECORD_STRING = await firesharpClient.Push<FirebaseUser>("users/", user);
                // Navigate to Home
                Navigation.PushAsync(new UserHome());
                while (Navigation.NavigationStack.Count > 1)
                    Navigation.RemovePage(Navigation.NavigationStack[0]);
            }
        }
    }
}
