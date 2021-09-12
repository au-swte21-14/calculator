using System.IO;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    public class CalculatorUnitTests
    {
        private Calculator _calc;

        [SetUp]
        public void Setup()
        {
            _calc = new Calculator();
        }

        [Test]
        public void Add()
        {
            Assert.AreEqual(_calc.Add(1, 1), 2);
            Assert.AreEqual(_calc.Add(1, 2), 3);
            Assert.That(_calc.Add(1.2, 1.2), Is.EqualTo(2.4).Within(0.2));
        }

        [Test]
        public void Multiply()
        {
            Assert.AreEqual(_calc.Multiply(1, 1), 1);
            Assert.AreEqual(_calc.Multiply(1, 2), 2);
            Assert.AreEqual(_calc.Multiply(2, 2), 4);
        }

        [Test]
        public void Subtract()
        {
            Assert.AreEqual(_calc.Subtract(1, 1), 0);
            Assert.AreEqual(_calc.Subtract(1, 2), -1);
            Assert.AreEqual(_calc.Subtract(2, 1.5), 0.5);
        }

        [Test]
        public void Power()
        {
            Assert.AreEqual(_calc.Power(1, 1), 1);
            Assert.AreEqual(_calc.Power(2, 2), 4);
            Assert.Throws<InvalidDataException>(() => _calc.Power(-2, 2.2));
        }

        [Test]
        public void Divide()
        {
            Assert.AreEqual(_calc.Divide(1, 1), 1);
            Assert.AreEqual(_calc.Divide(5.5, 5.5), 1);
            Assert.That(_calc.Divide(100, 3), Is.EqualTo(33.3).Within(0.1));
            Assert.That(_calc.Divide(20.5, 5.5), Is.EqualTo(3.7).Within(0.2));
        }

        [Test]
        public void Accumulator()
        {
            Assert.AreEqual(_calc.Power(2, 2), 4);
            Assert.AreEqual(_calc.Accumulator, 4);
            Assert.AreEqual(_calc.Add(20), 24);
            Assert.AreEqual(_calc.Accumulator, 24);
        }

        [Test]
        public void Clear()
        {
            Assert.AreEqual(_calc.Add(4), 4);
            
            _calc.Clear();
            Assert.AreEqual(_calc.Accumulator, 0);
        }


        [Test]
        public void AddAccumulate()
        {
            Assert.AreEqual(_calc.Add(1), 1);
            Assert.AreEqual(_calc.Add(2), 3);
            Assert.AreEqual(_calc.Add(10), 13);
        }

        [Test]
        public void MultiplyAccumulate()
        {
            Assert.AreEqual(_calc.Multiply(2), 0);
            Assert.AreEqual(_calc.Add(2), 2); // Fix multiply by zero
            Assert.AreEqual(_calc.Multiply(2), 4);
            Assert.AreEqual(_calc.Multiply(4), 16);
        }

        [Test]
        public void SubtractAccumulate()
        {
            Assert.AreEqual(_calc.Subtract(1), -1);
            Assert.AreEqual(_calc.Subtract(5), -6);
            Assert.AreEqual(_calc.Subtract(1.1), -7.1);
        }

        [Test]
        public void PowerAccumulate()
        {
            Assert.AreEqual(_calc.Power(2), 0);
            Assert.AreEqual(_calc.Add(4), 4); // Fix power by zero
            Assert.AreEqual(_calc.Power(4), 256);
        }

        [Test]
        public void DivideAccumulate()
        {
            Assert.AreEqual(_calc.Divide(2), 0);
            Assert.AreEqual(_calc.Add(20), 20); // Fix divide of zero
            Assert.AreEqual(_calc.Divide(2), 10);
            Assert.AreEqual(_calc.Divide(5), 2);
        }
    }
}