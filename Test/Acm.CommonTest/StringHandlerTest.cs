using System;
using Acm.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acm.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpaceTestValid()
        {
            //Arrange
            var source = "IndianTomachawk";
            var expected = "Indian Tomachawk";
            var handler = new StringHandler();
            //Act
            var actual = handler.InsertSpace(source);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertSpaceTestWithExistingSpace()
        {
            //Arrange
            var source = "Indian Tomachawk";
            var expected = "Indian Tomachawk";
            var handler = new StringHandler();
            //Act
            var actual = handler.InsertSpace(source);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
