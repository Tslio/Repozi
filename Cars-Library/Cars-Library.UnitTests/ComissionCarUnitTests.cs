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
    public class CommissionCarUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var car = GetTestCommissionCar();

            Assert.That(car.OwnerFullName,
                Is.EqualTo("Petr Sidorov"));

            Assert.That(car.OwnerAddress,
                Is.EqualTo("Moscow"));

            Assert.That(car.ContractNumber,
                Is.EqualTo("A-12345"));
        }

        [Test]
        public void GetInfo_CommissionCar_SevenStrings()
        {
            var car = GetTestCommissionCar();

            var info = car.GetInfo();

            Assert.That(info.Length, Is.EqualTo(7));
            Assert.That(info[4],
                Is.EqualTo("Комиссионное авто."));
            Assert.That(info[5],
                Is.EqualTo("Владелец: Petr Sidorov. Адрес: Moscow."));
            Assert.That(info[6],
                Is.EqualTo("Номер договора: A-12345."));
        }

        private CommissionCar GetTestCommissionCar()
        {
            return new CommissionCar(
                "Audi",
                2018,
                "AU333333333333333",
                CarBodyType.Hatchback,
                2100000m,
                new DateTime(2026, 5, 5),
                "Alex Ivanov",
                80000,
                "Отличное",
                "Petr Sidorov",
                "Moscow",
                "A-12345"
            );
        }
    }
}
