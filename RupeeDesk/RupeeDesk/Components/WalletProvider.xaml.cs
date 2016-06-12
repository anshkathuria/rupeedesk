using RupeeDesk.Models.Lannister;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RupeeDesk.Components
{
    public partial class WalletProvider : ContentView
    {
        public ConsumerWallet consumerWallet;
        public WalletProvider()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            if (this.BindingContext != null) consumerWallet = this.BindingContext as ConsumerWallet;
        }
        public void AddProvider(object sender, EventArgs e)
        {
            if (consumerWallet != null)
            {
                consumerWallet.Used = !consumerWallet.Used;
                if (consumerWallet.Used)
                {
                    IsTracked.Source = ImageSource.FromFile("ic_check_box");
                }
                else
                {
                    IsTracked.Source = ImageSource.FromFile("ic_check_box_outline");
                }
            }
        }
    }
}
