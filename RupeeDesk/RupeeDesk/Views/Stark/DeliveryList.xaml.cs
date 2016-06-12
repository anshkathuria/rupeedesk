using RupeeDesk.Models.Stark;
using RupeeDesk.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RupeeDesk.Views.Stark
{
    public partial class DeliveryList : ContentPage
    {
        private DeliveryListViewModel _vm;
        bool isAlertDisplayed = false;
        public DeliveryList()
        {
            InitializeComponent();
            _vm = new DeliveryListViewModel();
            BindingContext = _vm;
            var x = _vm.DeliveryList;
        }
        public async void OnDeliveryTapped(object sender, SelectedItemChangedEventArgs e)
        {
            if (!isAlertDisplayed)
            {
                var answer = await DisplayAlert("Payment Method?", "Is it payment by cash?", "Yes", "No");
                isAlertDisplayed = true;
            
            if (answer)
            {
                await DisplayAlert("Success", "Payment Received", "Ok");
            }
            else
            {
                if (e.SelectedItem != null)
                {
                    var x = e.SelectedItem as Delivery;
                    (sender as ListView).SelectedItem = null;
                    await Navigation.PushAsync(new OrderDetail(x));

                }
            }
            }
        }
    }
}
