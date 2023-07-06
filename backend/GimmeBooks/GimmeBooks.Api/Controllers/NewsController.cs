using GimmeBooks.Application.AppServices;
using GimmeBooks.Common;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GimmeBooks.Api.Controllers
{
    public class NewsController : BaseController
    {
        private readonly NewsAppService _appService;

        public NewsController(NewsAppService appService)
        {
            this._appService = appService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(ECategoryType category)
        {
            return ReturnResult(await _appService.GetAll(category));
        }
    }
}
