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
    public class NewCarUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var car = GetTestNewCar();

            Assert.That(car.Manufacturer, Is.EqualTo("Toyota Factory"));
            Assert.That(car.WarrantyPeriod, Is.EqualTo(36));
        }

        [Test]
        public void GetInfo_NewCar_FourStrings()
        {
            var car = GetTestNewCar();

            var info = car.GetInfo();

            Assert.That(info.Length, Is.EqualTo(4));

            Assert.That(info[0],
                Is.EqualTo("Toyota (2024) - VIN: JT111111111111111"));

            Assert.That(info[2],
                Is.EqualTo("Новое авто. Завод-производитель: Toyota Factory."));

            Assert.That(info[3],
                Is.EqualTo("Гарантийный срок: 36 мес."));
        }

        private NewCar GetTestNewCar()
        {
            return new NewCar(
                "Toyota",
                2024,
                "JT111111111111111",
                CarBodyType.Sedan,
                2500000m,
                new DateTime(2026, 4, 15),
                "Ivan Petrov",
                "Toyota Factory",
                36
            );
        }
    }
}
