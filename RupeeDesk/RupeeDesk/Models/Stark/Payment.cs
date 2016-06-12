using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RupeeDesk.Models.Stark
{
    public class Payment
    {
        private string _orderId;

        public string OrderId
        {
            get { return _orderId; }
            set { _orderId = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _phoneNumber;

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        private string _status;

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private double _amount;

        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private string _paymentType;

        public string PaymentType
        {
            get { return _paymentType; }
            set { _paymentType = value; }
        }

        private string _merchantName;

        public string MerchantName
        {
            get { return _merchantName; }
            set { _merchantName = value; }
        }


    }
}
