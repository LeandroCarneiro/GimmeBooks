using GimmeBooks.Application.AppServices;
using GimmeBooks.Common;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GimmeBooks.Api.Controllers
{
    public class TweetController : BaseController
    {
        private readonly TweetAppService _appService;

        public TweetController(TweetAppService appService)
        {
            _appService = appService;
        }
        [HttpGet]
        public async Task<IActionResult> Get(string keywords)
        {
            return ReturnResult(await _appService.Find(keywords));
        }
    }
}
