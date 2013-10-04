using System;
using System.Linq;
using FizzBuzzMoQ;
using NUnit.Framework;

namespace Tests.CalculatorTests
{
    [TestFixture]
    public class IsDivisibleByThreeShould
    {
        [Test]
        public void ReturnTrueIfNumberIsDivisibleByThree() {
            var calculator = new Calculator();
            var isDivisibleByThree = calculator.IsDivisibleByThree(9);

            Assert.IsTrue(isDivisibleByThree);
        }

        [Test]
        public void ReturnFalseIfNumberIsNotDivisibleByThree()
        { 
            var calculator = new Calculator();
            var isDivisibleByThree = calculator.IsDivisibleByThree(4);

            Assert.IsFalse(isDivisibleByThree);
        }
    }
}
