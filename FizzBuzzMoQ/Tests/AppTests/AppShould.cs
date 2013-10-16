using System;
using System.Linq;
using FizzBuzzMoQ;
using NUnit.Framework;
using Moq;

namespace Tests.AppTests
{
    [TestFixture]
    class AppShould
    {
        [Test]
        public void ReturnBuzzIfRequired()
        {
            var mockedWordGetter = new Mock<IWordGetter>();
            var app = new App(mockedWordGetter.Object);

            mockedWordGetter.Setup(wg => wg.GetBuzzIfRequired(It.IsAny<int>())).Returns("Buzz");
            mockedWordGetter.Setup(wg => wg.GetFizzIfRequired(It.IsAny<int>())).Returns((int x) => x.ToString());

            var result = app.Run(7);

            Assert.True(result.Contains("Buzz"));
        }

        [Test]
        public void ReturnFizzIfRequired()
        {
            var mockedWordGetter = new Mock<IWordGetter>();
            var app = new App(mockedWordGetter.Object);

            mockedWordGetter.Setup(wg => wg.GetFizzIfRequired(It.IsAny<int>())).Returns("Fizz");

            var result = app.Run(7);

            Assert.True(result.Contains("Fizz"));
        }

        [Test]
        public void ReturnFizzBuzzIfRequired()
        {
            var mockedWordGetter = new Mock<IWordGetter>();
            var app = new App(mockedWordGetter.Object);

            mockedWordGetter.Setup(wg => wg.GetFizzIfRequired(It.IsAny<int>())).Returns("Fizz");
            mockedWordGetter.Setup(wg => wg.GetBuzzIfRequired(It.IsAny<int>())).Returns("Buzz");

            var result = app.Run(15);

            Assert.AreEqual("FizzBuzz", result);
        }
    }
}
