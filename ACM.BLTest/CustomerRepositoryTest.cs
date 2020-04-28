using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //--Arrange
            var custRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "monkey@gmail.com",
                FirstName = "Paul",
                LastName = "Laspapos"
            };

            //--Act
            var actual = custRepository.Retrieve(1);

            //--Assert
            Assert.AreEqual(expected.CustId, actual.CustId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetrieveExistingAddress()
        {
            //--Arrange
            var custRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "monkey@gmail.com",
                FirstName = "Paul",
                LastName = "Laspapos",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Stinky clowns",
                        StreetLine2 = "5",
                        City = "Ankh-Morpork",
                        State = "The Shades",
                        Country = "Discworld",
                        PostalCode = "444"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Happy tree",
                        StreetLine2 = "1",
                        City = "Ankh-Morpork",
                        State = "Isle of Gods",
                        Country = "Discworld",
                        PostalCode = "333"
                    }
                }                
            };

            //--Act
            var actual = custRepository.Retrieve(1);

            //--Assert
            Assert.AreEqual(expected.CustId, actual.CustId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for(int i = 0; i<1;i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }

    }
}
