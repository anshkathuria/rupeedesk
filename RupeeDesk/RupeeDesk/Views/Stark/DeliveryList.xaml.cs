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
        public DeliveryList()
        {
            InitializeComponent();
            _vm = new DeliveryListViewModel();
            BindingContext = _vm;
            var x = _vm.DeliveryList;
        }
    }
}
