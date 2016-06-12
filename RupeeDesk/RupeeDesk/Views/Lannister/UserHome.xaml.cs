using RupeeDesk.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RupeeDesk.Views.Lannister
{
    public partial class UserHome : ContentPage
    {
        public UserHomeViewModel _vm;
        public UserHome()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _vm = new UserHomeViewModel();
            this.BindingContext = _vm;
        }
        public void NullItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            (sender as ListView).SelectedItem = null;
        }
    }
}
