using RupeeDesk.Models.Stark;
using RupeeDesk.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RupeeDesk.ViewModels
{
    public class DeliveryListViewModel : PropertyNotifier
    {
        public List<Delivery> _DeliveryList;
        public List<Delivery> DeliveryList
        {
            get
            {
                return _DeliveryList;
            }
            set
            {
                if (value != _DeliveryList)
                {
                    _DeliveryList = value;
                    NotifyPropertyChanged();
                }
            }
        } 
        public DeliveryListViewModel()
        {
            DeliveryList = new List<Delivery>()
            {
                new Delivery
                {
                    Name = "1"
                },
                new Delivery
                {
                    Name = "2"
                },
                new Delivery
                {
                    Name = "3"
                }
            };
        }
    }
}
