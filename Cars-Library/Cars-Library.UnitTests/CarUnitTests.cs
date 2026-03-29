using Cars_Library;
using NUnit.Framework;
using System;

namespace CarDealershipLibrary.UnitTests
{
    [TestFixture]
    public class CarUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var car = CreateTestCar();
            Assert.That(car.Brand, Is.EqualTo("Toyota"));
            Assert.That(car.Year, Is.EqualTo(2020));
            Assert.That(car.VIN, Is.EqualTo("JT123456789012345"));
            Assert.That(car.BodyType, Is.EqualTo(CarBodyType.Sedan));
            Assert.That(car.Price, Is.EqualTo(1500000m));
            Assert.That(car.SaleDate.ToShortDateString(), Is.EqualTo("20.03.2026"));
            Assert.That(car.BuyerFullName, Is.EqualTo("Dmitriy Ivanov"));
        }

        [Test]
        public void GetInfoTest()
        {
            var car = CreateTestCar();
            var info = car.GetInfo();
            Assert.That(info.Length, Is.EqualTo(2));
            Assert.That(info[0], Is.EqualTo("Toyota (2020) - VIN: JT123456789012345"));
            Assert.That(info[1], Is.EqualTo($"Тип кузова: Sedan. Цена: {1500000:C}. Дата продажи: 20.03.2026. Покупатель: Dmitriy Ivanov."));
        }

        private Car CreateTestCar()
        {
            return new Car(
                "Toyota",
                2020,
                "JT123456789012345",
                CarBodyType.Sedan,
                1500000m,
                "20.03.2026",
                "Dmitriy Ivanov"
            );
        }
    }
}

