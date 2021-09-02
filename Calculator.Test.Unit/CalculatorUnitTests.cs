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
        }
        
        [Test]
        public void Multiply()
        {
            Assert.AreEqual(_calc.Multiply(1, 1), 1);
            Assert.AreEqual(_calc.Multiply(1, 2), 2);
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
        }
    }
}