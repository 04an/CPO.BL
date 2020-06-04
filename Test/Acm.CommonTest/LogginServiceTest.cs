using System;
using System.Collections.Generic;
using Acm.Common;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acm.CommonTest
{
    [TestClass]
    public class LogginServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //Arrange
            var changeItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "monkey@gmail.com",
                FirstName = "Paul",
                LastName = "Laspapos",
                AddressList = null
            };
            changeItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Water",
                Description = "Sparkling water",
                CurrentPrice = 2.20M
            };
            changeItems.Add(product);

            //Act
            LogginService.WriteToFile(changeItems);

            //Asset
            //nothing
        }
    }
}
