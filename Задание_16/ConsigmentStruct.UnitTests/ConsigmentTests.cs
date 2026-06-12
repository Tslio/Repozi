using Задание_16;

namespace ConsigmentStruct.UnitTests
{
    [TestFixture]
    public class ConsigmentTests
    {
        [Test]
        public void ConstructorTest()
        {
            var c = new Consigment(10, 25.567);

            Assert.That(c.Quantity, Is.EqualTo(10));
            Assert.That(c.Price, Is.EqualTo(25.57));
        }

        [TestCase(-5)]
        public void Quantity_NegativeValue_ArgumentException(int val)
        {
            var c = new Consigment();
            Assert.That(() => c.Quantity = val, Throws.ArgumentException);
        }

        [TestCase(-1.0)]
        public void Price_NegativeValue_ArgumentException(double val)
        {
            var c = new Consigment();
            Assert.That(() => c.Price = val, Throws.ArgumentException);
        }
        [Test]
        public void CostTest()
        {
            var c = new Consigment(10, 2.55);
            Assert.That(c.Cost, Is.EqualTo(25.50));
        }
        [Test]
        public void ToStringTest()
        {
            var c = new Consigment(100, 250.5);
            Assert.That(c.ToString(), Is.EqualTo("100 шт. по 250.50 руб."));
        }
        [Test]
        public void EqualsTest()
        {
            var a = new Consigment(10, 5.50);
            var b = new Consigment(10, 5.50);

            Assert.That(a == b, Is.True);
        }
        [Test]
        public void NotEqualsTest()
        {
            var a = new Consigment(10, 5.50);
            var b = new Consigment(11, 5.50);

            Assert.That(a != b, Is.True);
        }
        [Test]
        public void AdditionTest()
        {
            var a = new Consigment(10, 5.00);
            var b = new Consigment(5, 5.00);

            var result = a + b;

            Assert.That(result.Quantity, Is.EqualTo(15));
            Assert.That(result.Price, Is.EqualTo(5.00));
        }

        [Test]
        public void Addition_DifferentPrice_Exception()
        {
            var a = new Consigment(10, 5.00);
            var b = new Consigment(5, 6.00);

            Assert.That(() => a + b, Throws.ArgumentException);
        }
        [Test]
        public void SubtractionTest()
        {
            var a = new Consigment(10, 5.00);
            var b = new Consigment(4, 5.00);

            var result = a - b;

            Assert.That(result.Quantity, Is.EqualTo(6));
        }

        [Test]
        public void Subtraction_TooBig_Exception()
        {
            var a = new Consigment(3, 5.00);
            var b = new Consigment(10, 5.00);

            Assert.That(() => a - b, Throws.ArgumentException);
        }
        [Test]
        public void Subtraction_DifferentPrice_Exception()
        {
            var a = new Consigment(10, 5.00);
            var b = new Consigment(1, 6.00);

            Assert.That(() => a - b, Throws.ArgumentException);
        }
    }
}