using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreConsole
{
    // Base class
    public interface ShippingStrategy
    {
        // abstract method is required by classes to implement
        void Ship(Order order);
    }

    // Ground shipping - 
    public class GroundShipping : ShippingStrategy
    {
        public void Ship(Order order)
        {
            Console.WriteLine($"Order {order.OrderId} is being via Ground");
        }
    }

    // Air Shipping
    public class AirShipping : ShippingStrategy
    {
        public void Ship(Order order)
        {
            Console.WriteLine($"Order {order.OrderId} is being shipped via Air");
        }
    }

}
