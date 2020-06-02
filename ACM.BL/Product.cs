using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        public Product()
        {

        }
        public Product(int productID)
        {
            this.ProductId = productID;
        }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        private string _productName;
        public string ProductName 
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
            }
        }
        public override string ToString() => ProductName;
        
        // Validate the product data
        public override bool Validate()
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
