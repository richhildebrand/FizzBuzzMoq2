using System;
using System.Linq;
using FizzBuzzMoQ;
using NUnit.Framework;

namespace Tests.CalculatorTests
{
    [TestFixture]
    public class IsDivisibleByFiveShould
    {
        [Test]
        public void ReturnTrueIfNumberIsDivisibleByFive()
        {
            var calculator = new Calculator();
            var isDivisibleByFive = calculator.IsDivisibleByFive(10);

            Assert.IsTrue(isDivisibleByFive);
        }

        [Test]
        public void ReturnFalseIfNumberIsNotDivisibleByFive()
        {
            var calculator = new Calculator();
            var isNotDivisibleByFive = calculator.IsDivisibleByFive(7);

            Assert.IsFalse(isNotDivisibleByFive);
        }
    }
}
