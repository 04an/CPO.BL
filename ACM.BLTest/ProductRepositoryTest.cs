using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //--Arrange
            var ProdRepository = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Water",
                Description = "Sparkling water",
                CurrentPrice = 2.20M
            };

            //--Act
            var actual = ProdRepository.Retrieve(2);

            //--Assert
            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }
    }
}
