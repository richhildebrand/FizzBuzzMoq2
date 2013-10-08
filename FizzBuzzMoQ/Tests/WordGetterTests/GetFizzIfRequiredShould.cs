using System;
using System.Linq;
using FizzBuzzMoQ;
using Moq;
using NUnit.Framework;

namespace Tests.WordGetterTests
{
    [TestFixture]
    class GetFizzIfRequiredShould
    {
        [Test]
        public void ReturnFizzIfNumberIsDivisibleByThree()
        {
            var mockedCalculator = new Mock<ICalculator>();
            var wordGetter = new WordGetter(mockedCalculator.Object);

            mockedCalculator.Setup(mc => mc.IsDivisibleByThree(It.IsAny<int>())).Returns(true);
            var result = wordGetter.GetFizzIfRequired(7);

            Assert.AreEqual(result, "Fizz");
        }

        [Test]
        public void ReturnNumberIfNumberIsNotDivisibleByThree()
        {
            var mockedCalculator = new Mock<ICalculator>();
            var wordGetter = new WordGetter(mockedCalculator.Object);

            mockedCalculator.Setup(mc => mc.IsDivisibleByThree(It.IsAny<int>())).Returns(false);

            var result = wordGetter.GetFizzIfRequired(7);

            Assert.AreNotEqual(result, "Fizz");
        }
    }
}
