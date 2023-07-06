using GimmeBooks.Application.AppServices;
using GimmeBooks.Common;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GimmeBooks.Api.Controllers
{
    public class BookController : BaseController
    {
        private readonly BookAppService _appService;

        public BookController(BookAppService appService)
        {
            _appService = appService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(ECategoryType category, string keywords)
        {
            return ReturnResult(await _appService.Find(category, keywords));
        }
    }
}
