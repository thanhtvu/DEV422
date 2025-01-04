using StoreConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// AKA Super-class

// Question In CLASS: What is the Abstract Class?

public abstract class Order
{
    // methods - no body - no logic



    // fields
    public int OrderId { get; set; }
    public string CustomerName { get; set; }

    protected ShippingStrategy _ShippingStrategy;



    // After fields - What do we need> => THE CONSTRACTOR - What a Constractor DO???
    // Use method with fields only / no constructor??
    public Order (int orderId, string customerName)
    {
        OrderId = orderId;
        CustomerName = customerName;
    }


    public void setShippingStrategy (ShippingStrategy shippingStrategy)
    {
        this._ShippingStrategy = shippingStrategy;
    }

    public void ShipOrder() 
    {
        if (this._ShippingStrategy != null)
        {
            _ShippingStrategy.Ship(this); // "this" - the Instance of the object
        } else
        {
            Console.WriteLine($"Shipping Strategy is NOT set! Set the Shipping Strategy and Try again!");
        }
    }

    // Astract method to process the order, must be implemented by derived classes
    public abstract void ProcessOrder();
}
