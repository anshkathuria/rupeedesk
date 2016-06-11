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
        bool IsFavorite;
        public AddWalletProviders()
        {
            InitializeComponent();
        }
        public void AddProvider(object sender,EventArgs e)
        {
            IsFavorite = !IsFavorite;
            if (IsFavorite)
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
