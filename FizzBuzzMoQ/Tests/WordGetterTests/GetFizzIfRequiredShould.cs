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

            // Given any int, IsDivisibleByThree will return true.
            // This allows us to test the behavor of GetFizzIfRequired without implenting / relying on IsDivisibleByThree.
            mockedCalculator.Setup(mc => mc.IsDivisibleByThree(It.IsAny<int>())).Returns(true);

            var result = wordGetter.GetFizzIfRequired(7);

            Assert.AreEqual(result, "Fizz");
        }
    }
}
