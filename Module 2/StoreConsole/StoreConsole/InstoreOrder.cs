using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreConsole
{
    internal class InstoreOrder : Order
    {
        // field
        public string StoreLocation { get; set; }

        // constructor
        public InstoreOrder(int orderId, string customerName, string storeLocation) : base(orderId, customerName)
        {
            StoreLocation = storeLocation;
        }

        // abstract mothods required by super class to be implemented
        public override void ProcessOrder()
        {
            Console.WriteLine($"Processing in-store Order for {CustomerName} to be picked up at {StoreLocation}");
        }


    }
}
