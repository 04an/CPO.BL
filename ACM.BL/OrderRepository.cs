using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        //Retrice one order
        public Order Retrieve(int orderID)
        {
            Order order = new Order(orderID);
            //Temporary hard-coded value to return
            if (orderID == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year,4,14,10,00,00,
                                                    new TimeSpan(7,0,0));
               
            }

            return  order;
        }
        // Save the current order
        public bool Save(Order order)
        {
            var success = true;

            if (order.HasChanges)
            {
                if (order.IsValid)
                {
                    if (order.IsNew)
                    {
                        // Call an Update Store Procedure
                    }
                    else
                    {
                        // Call an Update Store Procedure 
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
