using Microsoft.VisualStudio.TestTools.UnitTesting;
using Runner;
using System;
using System.Diagnostics;

namespace Runner_Test
{
    [TestClass]
    public class Division_Test
    {
        [TestMethod]
        public void IsXDivisibleByY_AnyNumber()
        {
            // Arrange
            int a = 201;
            int b = 3;


            //Act
            Division division = new Division();
            int result = division.IsXDivisibleByY(a, b);

            //Assert
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void IsXDivisibleByY_RandomNumber()
        {
            // Arrange
            Random rand = new Random();
            int divisor = rand.Next(1, 9851213);
            int dividend = rand.Next(1, 502);

            //Act
            Division division = new Division();
            int result = division.IsXDivisibleByY(divisor, dividend);

            //Assert
            Assert.AreEqual(result, divisor % dividend == 0 ? 1 : 0);
        }

        [TestMethod]
        public void IsXDivisibleByY_RandomNumberNinMax()
        {
            // Arrange
            Random rand = new Random();
            int divisor = rand.Next(int.MinValue, int.MaxValue);
            int dividend = rand.Next(int.MinValue, int.MaxValue);

            //Act
            Division division = new Division();
            int result = division.IsXDivisibleByY(divisor, dividend);

            //Assert
            Assert.AreEqual(result, divisor % dividend == 0 ? 1 : 0);
        }
    }
}
