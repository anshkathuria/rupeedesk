using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RupeeDesk.Models.Lannister
{
    public class FirebaseUser
    {
        public string PhoneNumber { get; set; }
        public List<ConsumerWallet> UserWallets { get; set; }
        public Card UserCard { get; set; }
    }
}
