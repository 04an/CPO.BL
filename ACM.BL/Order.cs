using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order
    {
        public Order(): this(0)
        {

        }
        public Order(int orderID)
        {
            this.OrderID = orderID;
            OrderItems = new List<OrderItem>();
        }
        public int OrderID { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int CustomerID { get; set; }
        public int ShippingAddressID { get; set; }

        public List<OrderItem> OrderItems { get; set; }


        // Validate tthe order data
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null)
            {
                isValid = false;
            }

            return isValid;
        }
        
    }
}
