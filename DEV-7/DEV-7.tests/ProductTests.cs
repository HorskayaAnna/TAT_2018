using DEVTask7;
using NUnit.Framework;
using System.Collections.Generic;

namespace DEV_7.Tests
{
    [TestFixture]
    class ProductTests
    {
        [Test]
        public void Equals_SimilarObjects_ReturnsTrue()
        {
            // Arrange
            Lada ladaFirst = new Lada()
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
            Lada ladaSecond = new Lada()
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
            bool actual = ladaFirst.Equals(ladaSecond);

            //Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void Equals_NonSimilarObjects_ReturnsFalse()
        {
            // Arrange
            Lada ladaFirst = new Lada()
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
            Lada ladaSecond = new Lada()
            {
                Brand = "ladaa",
                BodyType = "Universal",
                ClimateControl = "Opened window",
                EngineType = "Electrical",
                Model = "A",
                Power = 200,
                SalonType = "Fabric",
                TransmissionType = "Manual",
                Volume = 5,
            };

            //Act
            bool actual = ladaFirst.Equals(ladaSecond);

            //Assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void ToString_SimilarObjects_ReturnsSuitaleProduct()
        {
            //Arange
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
            string ladaToString = $"Product: {lada.Brand}, {lada.Model}, {lada.BodyType}, {lada.EngineType}, {lada.ClimateControl}, {lada.SalonType}, V: {lada.Volume}, P: {lada.Power}";

            //Act
            string ToStringActure = lada.ToString();

            //Assert
            Assert.AreEqual(ladaToString, ToStringActure);
        }   
    }
}
