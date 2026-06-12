using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Library.UnitTests
{
    [TestFixture]
    public class CarDealershipUnitTests
    {
        CarDealership dealership;

        Car[] cars;
        [SetUp]
        public void Setup()
        {
            var toyota = new Car(
                "Toyota",
                2020,
                "VIN1",
                CarBodyType.Sedan,
                1500000m,
                new DateTime(2026, 3, 20),
                "Ivan Ivanov"
            );

            var bmw = new Car(
                "BMW",
                2019,
                "VIN2",
                CarBodyType.Wagon,
                2000000m,
                new DateTime(2026, 4, 15),
                "Petr Petrov"
            );

            var audi = new Car(
                "Audi",
                2021,
                "VIN3",
                CarBodyType.Hatchback,
                1700000m,
                new DateTime(2026, 5, 10),
                "Sergey Sidorov"
            );

            cars = new Car[]
            {
                toyota,
                bmw,
                audi,
                toyota
            };

            dealership = new CarDealership(
                "Best Cars",
                "Moscow",
                cars
            );
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(dealership.Title,
                Is.EqualTo("Best Cars"));

            Assert.That(dealership.Address,
                Is.EqualTo("Moscow"));
            foreach (var car in cars)
            {
                var count = 0;
                foreach (var item in dealership)
                {
                    if (item == car)
                        count++;
                }
                Assert.That(count, Is.LessThanOrEqualTo(1));
            }
        }

        [Test]
        public void CountTest()
        {
            Assert.That(dealership.Count,
                Is.EqualTo(3));
        }
        [Test]
        public void IEnumerableTest()
        {
            var expectedCars = new Car[]
            {
                cars[0],
                cars[1],
                cars[2]
            };
            var i = 0;
            foreach (var car in dealership)
            {
                Assert.That(car,
                    Is.SameAs(expectedCars[i++]));
            }
        }
    }
}
