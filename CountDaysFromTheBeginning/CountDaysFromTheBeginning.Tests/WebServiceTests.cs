using NUnit.Framework;
using System;

namespace CountDaysFromTheBeginning.Tests
{
    [TestFixture]
    public class WebServiceTests
    {
        [Test]
        public void CountAmountOfDaysFromTheBeginning_RightAnswer()
        {
            string date = "2018.05.13";
            int expected = 736826;
            int actual = (new WebService()).CountAmountOfDaysFromTheBeginning(date);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CountAmountOfDaysFromTheBeginning_NotRightDateFormat_ExceptionRaised()
        {
            string date = "2018.asd.13";
            Assert.Throws<FormatException>(
                () =>
                (new WebService()).CountAmountOfDaysFromTheBeginning(date)
            );
        }

        [Test]
        public void CountAmountOfDaysFromTheBeginning_NotRightDateFormat_ArgumentNullRaised()
        {
            string date = null;
            Assert.Throws<ArgumentNullException>(
                () => (new WebService()).CountAmountOfDaysFromTheBeginning(date)
                );
        }
    }
}
