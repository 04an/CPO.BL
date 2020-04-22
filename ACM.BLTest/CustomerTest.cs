using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Pokemon",
                LastName = "Pikachu"
            };
            string expected = "Pikachu, Pokemon";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer
            {
                LastName = "Pikachu"
            };
            string expected = "Pikachu";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Pokemon"
            };
            string expected = "Pokemon";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void StatciTest ()
        {
            //--Arrange
            Customer customer = new Customer();
            Customer.InstanceCount += 1;
            Customer customer2 = new Customer();
            Customer.InstanceCount += 1;
            Customer customer3 = new Customer();
            Customer.InstanceCount += 1;

            customer.FirstName = "Ole";
            customer2.FirstName = "Oha";
            customer3.FirstName = "Ala";
     

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(3,Customer.InstanceCount);

        }
    }
}
