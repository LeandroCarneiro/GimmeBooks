using GimmeBooks.Application.Interfaces.Business;
using GimmeBooks.Application.Interfaces.Services;
using GimmeBooks.ApplicationTests;
using GimmeBooks.ApplicationTests.Mocks;
using GimmeBooks.Common;
using Moq;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace GimmeBooks.Application.AppServices.Tests
{
    [TestFixture()]
    public class NewsAnaliticsAppServiceTests : BaseTest
    {
        private readonly NewsAnaliticsAppService _service;
        private readonly Mock<IBookSearcher> _bookSearcher = new Mock<IBookSearcher>();
        private readonly Mock<ITweetSearcher> _tweetSearcher = new Mock<ITweetSearcher>();
        private readonly Mock<INewsSearcher> _newsSearcher = new Mock<INewsSearcher>();

        private readonly Mock<INewsAnaliticsBusiness> _business = new Mock<INewsAnaliticsBusiness>();

        public NewsAnaliticsAppServiceTests() : base()
        {
            _bookSearcher.Setup(x => (x.SearchAsync(It.IsAny<ECategoryType>(), It.IsAny<string>()).Result))
                .Returns(MockFaker.BooksMock).Verifiable();
            _tweetSearcher.Setup(x => (x.SearchAsync(It.IsAny<string>()).Result))
                .Returns(MockFaker.TweetsMock).Verifiable();
            _newsSearcher.Setup(x => (x.SearchAsync(It.IsAny<ECategoryType>()).Result))
                .Returns(MockFaker.NewsMock).Verifiable();

            _service = new NewsAnaliticsAppService(_business.Object, _bookSearcher.Object, _tweetSearcher.Object, _newsSearcher.Object);
        }

        [TestCase(ECategoryType.Arts)]
        [TestCase(ECategoryType.Home)]
        [TestCase(ECategoryType.Science)]
        [TestCase(ECategoryType.Us)]
        [TestCase(ECategoryType.World)]
        public async Task FindAndSaveTest(ECategoryType type)
        {
            var result = await _service.FindAndSave(type);

            Assert.IsTrue(result.RelatedBooksCount > 0);
            Assert.IsTrue(result.RelatedTweetsCount > 0);
        }

        [TestCase(10)]
        public void FindAndSaveFailTest(ECategoryType type)
        {
            var result = Enum.IsDefined(typeof(ECategoryType), type);
            Assert.IsFalse(result);
        }
    }
}