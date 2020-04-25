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
            if (orderID == 5)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year,4,14,10,00,00,new TimeSpan(7,7,7));
               
            }


            return  order;
        }
        // Save the current order
        public bool Save()
        {
            return true;
        }
    }
}
