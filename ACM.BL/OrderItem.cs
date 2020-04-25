using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemID)
        {
            this.OrderItemID = orderItemID;
        }

        public int OrderItemID { get; private set; }
        public int ProductID { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        //Retrieve one order item
        public OrderItem Retrieve(int orderItemID)
        {
            return new OrderItem();
        }
        //Save the current order item
        public bool save()
        {
            return true;
        }
        //Validate the order item
        public bool Validate()
        {
            var isValid = true;
            if (Quantity <= 0) isValid = false;
            if (ProductID <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}

