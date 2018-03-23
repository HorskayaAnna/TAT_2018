using System;
using NUnit.Framework;
using DEVTask6;

namespace DEV6UnitTests
{
    [TestFixture]
    public class CommodityTests
    {
        [TestCase("qwe", -123, (float)1.3)]
        [TestCase("qwe", 13, (float)-1.3)]
        public void CommodityTest(string paramName, int paramAmount, float paramPrice)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Commodity(paramName, paramAmount, paramPrice));
        }

        [TestCase("", 1, 3)]
        public void CommodityTestEmptyString(string paramName, int paramAmount, float paramPrice)
        {
            Assert.Throws<FormatException>(() => new Commodity(paramName, paramAmount, paramPrice));
        }
    }
}
