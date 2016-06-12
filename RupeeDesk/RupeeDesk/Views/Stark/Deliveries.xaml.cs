using RupeeDesk.Models.Stark;
using RupeeDesk.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RupeeDesk.Views.Stark
{
    public partial class Deliveries : ContentPage
    {
        FireSharpClient fsClient = FireSharpClient.Instance;
        Dictionary<string, Payment> payments;
        private Task sendDummyData;

        private Task GetData;
        public Deliveries()
        {
            InitializeComponent();
            var ToolbarButton = new ToolbarItem
            {
                Icon = "ic_add_white",
                Command = new Command(
                (() => {
                    //Navigation.PushAsync(new ManageYarnPage(list));
                    insertRandomDelivery();
                })
                )
            };
            ToolbarItems.Add(ToolbarButton);
            // sendDummyData = sendDummy();
        }

        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public string RandomNumber(int length)
        {
            const string chars = "0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void insertRandomDelivery()
        {
            Payment p = new Payment();
            p.Address = RandomString(10) + RandomString(10) + RandomString(10);
            //+p.Amount = Convert.ToInt32(Ran)
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            GetData = getData();
        }

        private async Task sendDummy()
        {
            Payment p = new Payment();
            p.OrderId = "#1234";
            p.Name = "Tony Stark";
            p.PaymentType = "CASH";
            p.PhoneNumber = "123243432";
            p.Status = "COMPLETED";
            p.Amount = 500;
            p.Address = "Tony ka ghar";
            p.MerchantName = "McDonalds";
            await fsClient.Push<Payment>("payments", p);

            p = new Payment();
            p.OrderId = "#1235";
            p.Name = "Tony Stark 1";
            p.PaymentType = "CASH";
            p.PhoneNumber = "1232322";
            p.Status = "PENDING";
            p.Amount = 400;
            p.Address = "address ghar";
            p.MerchantName = "KFC";
            await fsClient.Push<Payment>("payments", p);

            p = new Payment();
            p.OrderId = "#1236";
            p.Name = "Tony Stark 2";
            p.PaymentType = "ONLINE";
            p.PhoneNumber = "1221332322";
            p.Status = "COMPLETED";
            p.Amount = 450;
            p.Address = "address 1 ghar";
            p.MerchantName = "KFC";
            await fsClient.Push<Payment>("payments", p);

            p = new Payment();
            p.OrderId = "#1285";
            p.Name = "Tony sada";
            p.PaymentType = "CASH";
            p.PhoneNumber = "12212322";
            p.Status = "PENDING";
            p.Amount = 390;
            p.Address = "address ghar";
            p.MerchantName = "McDonalds";
            await fsClient.Push<Payment>("payments", p);

            p = new Payment();
            p.OrderId = "#1285";
            p.Name = "Tony sada";
            p.PaymentType = "ONLINE";
            p.PhoneNumber = "12212322";
            p.Status = "COMPLETED";
            p.Amount = 390;
            p.Address = "address ghar";
            p.MerchantName = "Snapdeal";
            await fsClient.Push<Payment>("payments", p);
        }

        private async Task getData()
        {
            payments = await fsClient.GetAll<Payment>("payments");
            deliveryList.ItemsSource = payments;
        }

        public void DeliverSelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            if((sender as ListView).SelectedItem != null)
            {
                var d = (KeyValuePair<string, Payment>)e.SelectedItem;
                string key = d.Key;
                Navigation.PushAsync(new DeliveryDetail(key));
                (sender as ListView).SelectedItem = null;
            }
        }
    }
}
