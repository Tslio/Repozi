using Cars_Library;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershipLibrary.UnitTests
{
    [TestFixture]
    public class UsedCarUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var car = GetTestUsedCar();
            Assert.That(car.Mileage, Is.EqualTo(120000));
            Assert.That(car.Condition, Is.EqualTo("Хорошее"));
        }
        [Test]
        public void GetInfo_UsedCar_FourStrings()
        {
            var car = GetTestUsedCar();
            var info = car.GetInfo();

            Assert.That(info.Length, Is.EqualTo(4));
            Assert.That(info[2],
                Is.EqualTo("Подержанное авто. Пробег: 120000 км."));
            Assert.That(info[3],
                Is.EqualTo("Состояние: Хорошее."));
        }

        private UsedCar GetTestUsedCar()
        {
            return new UsedCar(
                "BMW",
                2016,
                "WB222222222222222",
                CarBodyType.Wagon,
                1700000m,
                new DateTime(2026, 2, 10),
                "Sergey Ivanov",
                120000,
                "Хорошее"
            );
        }
    }
}