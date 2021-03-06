﻿using System;
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
            
            //Act
            var actual = source.InsertSpace();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertSpaceTestWithExistingSpace()
        {
            //Arrange
            var source = "Indian Tomachawk";
            var expected = "Indian Tomachawk";
           
            //Act
            var actual = source.InsertSpace();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
