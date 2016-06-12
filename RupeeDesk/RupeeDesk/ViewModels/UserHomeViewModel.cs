using RupeeDesk.Data;
using RupeeDesk.Models.Lannister;
using RupeeDesk.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RupeeDesk.ViewModels
{
    public class UserHomeViewModel : PropertyNotifier
    {
        FireSharpClient firesharpClient = FireSharpClient.Instance;

        private bool fetching;
        public bool Fetching
        {
            get { return fetching; }
            set
            {
                if(fetching != value)
                {
                    fetching = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged("FetchingCompleted");
                }
            }
        }

        public bool FetchingCompleted
        {
            get { return !Fetching; }
        }

        private List<ConsumerWallet> userWallets;
        public List<ConsumerWallet> UserWallets
        {
            get { return userWallets; }
            set
            {
                if(userWallets != value)
                {
                    userWallets = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private double totalAmount;
        public double TotalAmount
        {
            get { return totalAmount; }
            set
            {
                if(value != totalAmount)
                {
                    totalAmount = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged("TotalText");
                }
            }
        }

        public string TotalText
        {
            get { return "Total : " + TotalAmount; }
        }

        private Task Intialization;
        public UserHomeViewModel()
        {
            Fetching = true;
            Intialization = fetchUser();
        }
        private async Task fetchUser()
        {
            if (GlobalData.USER_RECORD_STRING != null)
            {
                // get phone number from global constants
                // fetch user details from the firebase
                FirebaseUser user = await firesharpClient.Get<FirebaseUser>("users/" + GlobalData.USER_RECORD_STRING);
                UserWallets = user.UserWallets;

                totalAmount = UserWallets.AsEnumerable().Sum(wallet => wallet.Amount);
                NotifyPropertyChanged("TotalText");
                // calculate total
                Fetching = false;
            }
                
        }
    }
}
