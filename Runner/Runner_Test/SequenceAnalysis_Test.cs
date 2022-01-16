using Microsoft.VisualStudio.TestTools.UnitTesting;
using Runner;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Runner_Test
{
    [TestClass]
    public class SequenceAnalysis_Test
    {
        [TestMethod]
        public void SequenceAnalysis_UppercaseWord()
        {
            //Arrange

            string input = "This IS a STRING";

            //Act
            SequenceAnalysis problem = new SequenceAnalysis();
            var result = problem.GetSequenceAnalysis(input, new CultureInfo("en-US"));

            //Assert
            Assert.AreNotEqual("GIINRSST", result);

        }


        [TestMethod]
        public void SequenceAnalysis_UppercaseWord_With_Culture_Sweden()
        {
            //Arrange

            string input = "ZoE Kommt AUS deR ÖstERreicH";

            IFormatProvider formatProvider = new CultureInfo("sv-SE");
            //Act
            SequenceAnalysis problem = new SequenceAnalysis();
            var result = problem.GetSequenceAnalysis(input, formatProvider);

            //Assert
            Assert.AreNotEqual("AEEHKÖRRSUZ", result);//AEEHKRRSUZÖ Ö is last char in Swedish. 

        }

        [TestMethod]
        public void SequenceAnalysis_UppercaseWord_With_Culture_Deutsch()
        {
            //Arrange

            string input = "ZoE Kommt AUS deR ÖstERreicH";
            CultureInfo cultureInfo = new CultureInfo("de-DE");

            //Act
            SequenceAnalysis problem = new SequenceAnalysis();
            var result = problem.GetSequenceAnalysis(input, cultureInfo);

            //Assert
            Assert.AreEqual("AEEHKÖRRSUZ", result);

        }
    }
}
