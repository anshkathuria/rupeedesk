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
                    OrderID = "#110",
                    Name = "Abhishek",
                    Phonenumber = "8686042849"
                },
                new Delivery
                {
                    OrderID = "#111",
                    Name = "Gandharv",
                    Phonenumber = "8019608326"
                },
                new Delivery
                {
                    OrderID = "#112",
                    Name = "Gaurav",
                    Phonenumber = "9963899305"
                }
            };
        }
    }
}
