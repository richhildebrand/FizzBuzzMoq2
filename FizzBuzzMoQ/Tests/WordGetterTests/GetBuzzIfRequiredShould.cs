using System;
using System.Linq;
using FizzBuzzMoQ;
using Moq;
using NUnit.Framework;

namespace Tests.WordGetterTests
{
    [TestFixture]
    class GetBuzzIfRequiredShould
    {
        [Test]
        public void ReturnBuzzIfNumberIsDivisibleByThree()
        {
            var mockedCalculator = new Mock<ICalculator>();
            var wordGetter = new WordGetter(mockedCalculator.Object);

            mockedCalculator.Setup(mc => mc.IsDivisibleByFive(It.IsAny<int>())).Returns(true);
            var result = wordGetter.GetBuzzIfRequired(7);

            Assert.AreEqual(result, "Buzz");
        }

        [Test]
        public void ReturnNumberIfNumberIsNotDivisibleByThree()
        {
            var mockedCalculator = new Mock<ICalculator>();
            var wordGetter = new WordGetter(mockedCalculator.Object);

            mockedCalculator.Setup(mc => mc.IsDivisibleByFive(It.IsAny<int>())).Returns(false);

            var result = wordGetter.GetBuzzIfRequired(7);

            Assert.AreNotEqual(result, "Buzz");
        }
    }
}
