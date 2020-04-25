using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;


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
       
    }
}
