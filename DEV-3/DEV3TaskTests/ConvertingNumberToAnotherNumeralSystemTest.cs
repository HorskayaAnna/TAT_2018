using System;
using NUnit.Framework;
using DevTask3;

namespace DEV3TaskTests
{
    [TestFixture]
    public class ConvertingNumberToAnotherNumeralSystem_tests
    {
        [TestCase("13", "5", "QWERTY")]
        public void ConvertingNumberToAnotherNumeralSystem_MoreThanTwoArgs_WithoutException(params string[] args)
        {
            Assert.DoesNotThrow(() => new ConvertingNumberToAnotherNumeralSystem(args));
        }

        [TestCase("-10", "3")]
        [TestCase("10", "1")]
        [TestCase("10", "21")]
        public void ConvertingNumberToAnotherNumeralSystem_NumbersOutOfValidRange_ExceptionAppears(params string[] args)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new ConvertingNumberToAnotherNumeralSystem(args));
        }

        [TestCase("10")]
        [TestCase()]
        public void ConvertingNumberToAnotherNumeralSystem_NumbersOfParamsOutOfRange_ExceptionAppears(params string[] args)
        {
            Assert.Throws<IndexOutOfRangeException>(() => new ConvertingNumberToAnotherNumeralSystem(args));
        }

        [TestCase("10,5", "3")]
        [TestCase("3", "23B")]
        [TestCase("QWERTY", "YTREWQ")]
        public void ConvertingNumberToAnotherNumeralSystem_NotRightFormatOfArgs_ExceptionAppears(params string[] args)
        {
            Assert.Throws<FormatException>(() => new ConvertingNumberToAnotherNumeralSystem(args));
        }

        [TestCase("13", "3", "111")]
        [TestCase("2748", "16", "ABC")]
        [TestCase("0", "5", "0")]
        public void СonversionToAnotherNumeralSystem_InNewSystem_NewNumber(params string[] args)
        {
            // Arrange 
            ConvertingNumberToAnotherNumeralSystem convertor = new ConvertingNumberToAnotherNumeralSystem(args);
            string expected = args[2];

            // Act
            string actual = convertor.СonvertToAnotherNumeralSystem();

            // Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
