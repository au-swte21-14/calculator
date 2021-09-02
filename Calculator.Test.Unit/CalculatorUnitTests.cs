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
        }
        
        [Test]
        public void Power()
        {
            Assert.AreEqual(_calc.Power(1, 1), 1);
            Assert.AreEqual(_calc.Power(2, 2), 4);
            Assert.Throws<InvalidDataException>(()=>_calc.Power(-2, 2.2));
        }

        [Test]
        public void Divide()
        {
            Assert.AreEqual(_calc.Divide(1,1),1);
            Assert.AreEqual(_calc.Divide(5.5,5.5),1);
            Assert.That(_calc.Divide(20.5,5.5),Is.EqualTo(3.7).Within(0.2));
        }
    }
}