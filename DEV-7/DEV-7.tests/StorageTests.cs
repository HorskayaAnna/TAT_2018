using NUnit.Framework;
using DEVTask7;

namespace DEV_7.Tests
{
    [TestFixture]
    class StorageTests
    {
        Storage storage;
        [OneTimeSetUp]
        public void SetUp()
        {
            storage = new Storage(@"storage.json");
        }

        [Test]
        public void StorageMethodsTest()
        {
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
            Assert.IsFalse(storage.IsAvailableProduct(lada));
            storage.AddProductToStorage(lada);
            Assert.IsTrue(storage.IsAvailableProduct(lada));
            storage.RemoveProduct(lada);
            Assert.IsFalse(storage.IsAvailableProduct(lada));
        }
    }
}
