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

            var result = app.Run(7);

            Assert.True(result.Contains("Buzz"));
        }
    }
}
