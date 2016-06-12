using RupeeDesk.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RupeeDesk.Models.Lannister
{
    public class ConsumerWallet : PropertyNotifier
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool _Used;
        public bool Used
        {
            get { return _Used; }
            set
            {
                if (_Used != value)
                {
                    _Used = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private double _Amount;
        public double Amount
        {
            get { return _Amount; }
            set
            {
                if (_Amount != value)
                {
                    _Amount = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
