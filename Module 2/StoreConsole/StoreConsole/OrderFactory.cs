using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreConsole
{
    public static class OrderFactory
    {
        public static Order CreateOrder(string orderType, int orderID, string customerName, string addressORlocation)
        {
            if (orderType == "Online")
            {
                return new OnlineOrder(orderID, customerName, addressORlocation);
            } 
            else if (orderType == "Instore")
            {
                return new InstoreOrder(orderID, customerName, addressORlocation);
            } 
            else
            {
                throw new ArgumentException("Invalid order Type!");
            }
        }
    }
}
