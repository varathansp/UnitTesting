using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDivide()
        {
            //Arrange
            int expected = 5;
            int numerator = 20;
            int denominator = 4;

            //Act
            int actual = Calculator.Library.Calculator.Divide(numerator, denominator);

            //Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
