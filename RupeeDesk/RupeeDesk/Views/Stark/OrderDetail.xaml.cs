using RupeeDesk.Models.Stark;
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
        public OrderDetail(Delivery d)
        {
            InitializeComponent();
            BindingContext = d;
        }
        public void OnOTPClicked(object sender,EventArgs e)
        {
           
        }
        public void OnVerifyOTPClicked(object sender, EventArgs e)
        {
            DisplayAlert("Success", "Payment Received", "Ok");
        }
    }
}
