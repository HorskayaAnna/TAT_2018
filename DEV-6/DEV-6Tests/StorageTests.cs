using NUnit.Framework;
using DEVTask6;

namespace DEV6UnitTests
{
    [TestFixture]
    class StorageTests
    {
        Storage storage = Storage.GetInstance();

        [OneTimeSetUp]
        public void Init()
        {
            storage.AddItems("Milk", new Commodity("Eco", 100, 3));
            storage.AddItems("Butter", new Commodity("White", 100, 4));
        }

        [Test]
        public void CountTypes_AddTwoTypes_Returned2()
        {
            // Arrange           
            int excpected = 2;

            // Act
            int actual = storage.CountTypes();

            // Assert
            Assert.AreEqual(excpected, actual);
        }

        [Test]
        public void CountAll_Add300Commodities_Returned300()
        {
            // Arrange
            int excpected = 200;

            // Act
            int actual = storage.CountAll();

            // Assert
            Assert.AreEqual(excpected, actual);
        }

        [Test]
        public void AveragePrice_Returned3point5()
        {
            // Arrange
            float excpected = (float)3.5;

            // Act
            float actual = storage.AveragePrice();

            // Assert
            Assert.AreEqual(excpected, actual);
        }

        [Test]
        public void AverageTypePrice_Return3point5()
        {
            // Arrange
            float excpected = (float)3;

            // Act
            float actual = storage.AveragePrice("Milk");

            // Assert
            Assert.AreEqual(excpected, actual);
        }
    }
}
