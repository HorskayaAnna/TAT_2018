using NUnit.Framework;
using System.Collections.Generic;

namespace DEVTask7.tests
{
    [TestFixture]
    public class CatalogTests
    {
        Catalog catalog;
        [OneTimeSetUp]
        public void SetUp()
        {
            catalog = new Catalog(@"cars.json");
        }

        [Test]
        public void GetSuitableProducts_test()
        {
            // Arrange
            Lada lada = new Lada()
            {
                Brand = "lada",
                BodyType = "Universal",
                ClimateControl = "Opened window",
                EngineType = "Electrical",
                Model = "A",
                Power = 100,
                SalonType = "Fabric",
                TransmissionType = "Manual",
                Volume = 5,
            };

            // Act
            List<Product> list = catalog.GetSuitableProducts(lada);

            //Assert
            Assert.AreEqual(list.Count, 1);
            Assert.AreEqual(list[0],lada);
        }
    }
}
