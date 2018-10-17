using System;
using NUnit.Framework;
using Task2;

namespace Task2Tests
{
    [TestFixture]
    public class CalculateArea_tests
    {
        [TestCase("13", "5")]
        public void CalculateArea_WithoutException(params double[] args)
        {
            Assert.DoesNotThrow(() => new Rectangle(args[0], args[1]));
        }

        [TestCase("13", "5")]
        [TestCase("0", "5")]
        [TestCase("13", "0")]
        [TestCase("13")]
        [TestCase("13", "-5")]
        [TestCase("-13", "5")]
        [TestCase()]
        public void CalculateArea_WithException(params double[] args)
        {
            Assert.DoesNotThrow(() => new Rectangle(args[0], args[1]));
        }

        [TestCase("1", "3", "3")]
        [TestCase("2", "2", "4")]
        [TestCase("1", "5", "5")]
        public void CalculateArea(params string[] args)
        {
            // Arrange 
            Rectangle rectangle = new Rectangle(double.Parse(args[0]), double.Parse(args[1]));
            double expected = double.Parse(args[2]);

            // Act
            double actual = rectangle.CalculateArea();

            // Assert 
            Assert.AreEqual(expected, actual);
        }
}
}