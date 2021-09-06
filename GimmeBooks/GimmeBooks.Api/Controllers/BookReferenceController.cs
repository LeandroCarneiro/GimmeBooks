using GimmeBooks.Application.AppServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;

namespace GimmeBooks.Api.Controllers
{
    public class BookReferenceController : BaseController
    {
        private readonly BookAppService bookAppService;
        private readonly NewsAppService newsAppService;
        private readonly TweetAppService tweetAppService;

        public BookReferenceController(
            BookAppService bookAppService,
            NewsAppService newsAppService,
            TweetAppService tweetAppService
            )
        {
            this.bookAppService = bookAppService;
            this.newsAppService = newsAppService;
            this.tweetAppService = tweetAppService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var news = await newsAppService.GetAll(Common.ECategoryType.World);
            var books = bookAppService.Find(Common.ECategoryType.World, news.FirstOrDefault().Title);
            var tweets = tweetAppService.Find(news.FirstOrDefault().Title);

            return new ContentResult
            {
                Content = JsonConvert.SerializeObject(
                    new
                    {
                        news = news.FirstOrDefault(),
                        tweetsCount = (await tweets).Count,
                        books = await books
                    }),
                ContentType = "application/json"
            };
        }
    }
}
