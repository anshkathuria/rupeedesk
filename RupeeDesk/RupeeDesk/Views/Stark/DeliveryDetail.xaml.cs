using RupeeDesk.Models.Stark;
using RupeeDesk.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RupeeDesk.Views.Stark
{
    public partial class DeliveryDetail : ContentPage
    {
        FireSharpClient fsClient = FireSharpClient.Instance;
        private Task GetPayment;
        public Payment CurrentPayment;
        private string key;
        public DeliveryDetail(string key)
        {
            InitializeComponent();
            this.key = key;
            GetPayment = getCurrentPayment(key);
            click1(null, null);
        }

        private async Task getCurrentPayment(string key)
        {
            CurrentPayment = await fsClient.Get<Payment>("payments/" + key);
            this.BindingContext = CurrentPayment;
        }

        public void click1(object s, EventArgs e)
        {
            button1.IsEnabled = false;
            button2.IsEnabled = true;
            contentview1.IsVisible = true;
            contentview2.IsVisible = false;

        }
        public void click2(object s, EventArgs e)
        {
            button2.IsEnabled = false;
            button1.IsEnabled = true;
            contentview1.IsVisible = false;
            contentview2.IsVisible = true;

        }
        public void OnOTPClicked(object sender, EventArgs e)
        {
            VerifyOTPEntry.IsVisible = true;
            VerifyOTPButton.IsVisible = true;
        }
        public async void OnVerifyOTPClicked(object sender, EventArgs e)
        {
            CurrentPayment.PaymentType = "ONLINE";
            CurrentPayment.Status = "COMPLETED";
            await fsClient.Set<Payment>("payments/" + key, CurrentPayment);
            await DisplayAlert("Success", "Payment Received", "Ok");
            await this.Navigation.PopAsync();
        }

        public async void OnCOD(object sender, EventArgs e)
        {
            CurrentPayment.PaymentType = "CASH";
            CurrentPayment.Status = "COMPLETED";
            await fsClient.Set<Payment>("payments/" + key, CurrentPayment);
            await DisplayAlert("Success", "COD Accepted", "Ok");
            await this.Navigation.PopAsync();
        }
    }
}
