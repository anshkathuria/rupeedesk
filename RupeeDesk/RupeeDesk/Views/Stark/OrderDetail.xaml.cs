using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RupeeDesk.Views.Stark
{
    public partial class OrderDetail : ContentPage
    {
        public OrderDetail()
        {
            InitializeComponent();
        }
        public void OnOTPClicked(object sender,EventArgs e)
        {
            VerifyOTPEntry.IsVisible = true;
            VerifyOTPButton.IsVisible = true;
        }
        public void OnVerifyOTPClicked(object sender, EventArgs e)
        {
            DisplayAlert("Success", "Payment Received", "Ok");
        }
    }
}
