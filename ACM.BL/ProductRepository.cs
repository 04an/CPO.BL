using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        //Retrive one product
        public Product Retrieve(int productID)
        {
            Product product = new Product(productID);

            //Temporary hard-coded value to return
            if (productID == 2)
            {
                product.ProductName = "Water";
                product.Description = "Sparkling water";
                product.CurrentPrice = 2.20M;
            }
            return product;
        }
        // Saves the current product
        public bool Save(Product product)
        {
            return true;
        }
    }
}
