using GimmeBooks.Application.AppServices;
using GimmeBooks.Common;
using GimmeBooks.ViewModels.AppObjects;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Get()
        {
            return ReturnResult(_appService.FindById(1));
        }
    }
}
