using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {

        }

        public Order(int orderID)
        {
            this.OrderID = orderID;
        }

        public int OrderID { get; set; }
        public DateTimeOffset? OrderDate { get; set; }

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
        //Retrice one order
        public Order Retrieve()
        {
            return new Order();
        }
        // Save the current order
        public bool Save()
        {
            return true;
        }
    }
}
