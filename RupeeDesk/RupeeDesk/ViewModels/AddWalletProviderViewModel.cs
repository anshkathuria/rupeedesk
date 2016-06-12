using RupeeDesk.Models.Lannister;
using RupeeDesk.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RupeeDesk.ViewModels
{
    public class AddWalletProviderViewModel : PropertyNotifier
    {
        private List<ConsumerWallet> _walletProviders;
        public List<ConsumerWallet> WalletProviders
        {
            get { return _walletProviders; }
            set
            {
                if (value != _walletProviders)
                {
                    _walletProviders = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ConsumerWallet PaytmWallet { get; set; }

        public AddWalletProviderViewModel()
        {
            // add Paytm, Mobikwik, Airtel Money, OLA Money, Freecharge to walletProviders
            WalletProviders = new List<ConsumerWallet>();
            WalletProviders.Add(new ConsumerWallet { Name = "Paytm" });
            WalletProviders.Add(new ConsumerWallet { Name = "Mobikwik" });
            WalletProviders.Add(new ConsumerWallet { Name = "Airtel Money" });
            WalletProviders.Add(new ConsumerWallet { Name = "OLA Money" });
            WalletProviders.Add(new ConsumerWallet { Name = "Freecharge" });

            PaytmWallet = new ConsumerWallet { Name = "Paytm" };
        }
    }
}
