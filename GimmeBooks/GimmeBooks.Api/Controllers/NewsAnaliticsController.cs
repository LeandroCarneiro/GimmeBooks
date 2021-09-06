using GimmeBooks.Application.AppServices;
using GimmeBooks.Common;
using GimmeBooks.ViewModels.AppObject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GimmeBooks.Api.Controllers
{
    public class NewsAnaliticsController : BaseController
    {
        private readonly NewsAnaliticsAppService _newsAppService;

        public NewsAnaliticsController(NewsAnaliticsAppService newsAppService)
        {
            _newsAppService = newsAppService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(ECategoryType category = ECategoryType.Science)
        {
            return ReturnResult(await _newsAppService.FindAndSave(category));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return ReturnResult(await _newsAppService.AllAsync());
        }
    }
}
