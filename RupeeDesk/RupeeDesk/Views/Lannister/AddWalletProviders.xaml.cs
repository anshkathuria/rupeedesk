using RupeeDesk.Data;
using RupeeDesk.Models.Lannister;
using RupeeDesk.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RupeeDesk.Views.Lannister
{
    public partial class AddWalletProviders : ContentPage
    {
        public AddWalletProviderViewModel _vm;
        public AddWalletProviders()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            _vm = new AddWalletProviderViewModel();
            BindingContext = _vm;
        }

        public void NullSelectItem(object sender, SelectedItemChangedEventArgs e)
        {
            (sender as ListView).SelectedItem = null;
        }

        // TODO : on NEXT Click transfer generate random money to these wallet and send to firebase.

        public void NextClicked(object sender, EventArgs e)
        {
            foreach (var item in _vm.WalletProviders)
            {
                if(item.Used)
                    item.Amount = new Random().Next(0, 100);
            }
            GlobalData.USER_WALLETS = _vm.WalletProviders.FindAll(wallet => wallet.Used == true);
            this.Navigation.PushAsync(new AddCard());
        }
    }
}
