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
    }
}
