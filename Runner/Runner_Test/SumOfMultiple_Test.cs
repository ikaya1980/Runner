using Microsoft.VisualStudio.TestTools.UnitTesting;
using Runner;
using System;
using System.Collections.Generic;
using System.Text;

namespace Runner_Test
{
    [TestClass]
    public class SumOfMultiple_Test
    {
        [TestMethod]
        public void SumOfMultiple_Number18()
        {
            //Arrange
            int number = 18;

            //Act
            SumOfMultiple problem = new SumOfMultiple();
            var result = problem.GetSumOfMultiple(number);

            //Assert
            Assert.AreEqual(78, result);

        }


        [TestMethod]
        public void SumOfMultiple_Number40()
        {
            //Arrange
            int number = 40;

            //Act
            SumOfMultiple problem = new SumOfMultiple();
            var result = problem.GetSumOfMultiple(number);

            //Assert
            Assert.AreEqual(408, result);

        }


        [TestMethod]
        public void SumOfMultiple_MultipleOf15()
        {
            //Arrange
            int number = 150;

            //Act
            SumOfMultiple problem = new SumOfMultiple();
            var result = problem.GetSumOfMultiple(number);

            //Assert
            Assert.AreNotEqual(23421, result);

        }

    }
}
