using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 
namespace StoreConsole
{
    internal class OnlineOrder : Order  // Red-line complained from No constructor & No implementing method??
    {
        // fields
        public string DeliveryAddress { get; set; }

        // constructor
        public OnlineOrder(int orderId, string customerName, string deliveryAddress) :base(orderId, customerName)
        {
            DeliveryAddress = deliveryAddress;
        }

        public override void ProcessOrder()
        {
            Console.WriteLine($"Processing Online Order for {CustomerName} to be Delivered at {DeliveryAddress}");
        }
    }
}
