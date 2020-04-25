using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productID)
        {
            this.ProductId = productID;
        }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        // Validate the product data
        public bool Validate()
        {
            var isValid = true;

            if(string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;
            }
            if(CurrentPrice ==null)
            {
                isValid = false;
            }
            return isValid;

        }

    }
}
