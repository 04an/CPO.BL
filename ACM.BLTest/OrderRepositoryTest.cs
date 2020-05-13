using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //--Arrange
            var orderReposotiry = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                                                new TimeSpan(7, 0,0))

            };

            //--Act
            var actual = orderReposotiry.Retrieve(10);

            //--Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
           
        }
        [TestMethod]
        public void SaveTestValid()
        {
            //--Arange
            var orderRepository = new OrderRepository();
            var updateOrder = new Order(2)
            {
                OrderID = 2,
                CustomerID = 2,
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                                                new TimeSpan(7, 0, 0)),
                HasChanges = true               

            };

            //--Act
            var actual = orderRepository.Save(updateOrder);
            //--Assert
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void SaveTestMissingDate()
        {
            //--Arange
            var orderRepository = new OrderRepository();
            var order = new Order(2)
            {
                OrderID = 2,
                CustomerID = 2,
                HasChanges = true
            };
            //--Act
            var actual = orderRepository.Save(order);
            //--Assert
            Assert.AreEqual(false, actual);
        }
    }
}
