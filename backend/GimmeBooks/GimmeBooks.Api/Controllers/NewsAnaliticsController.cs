using GimmeBooks.Application.AppServices;
using GimmeBooks.Common;
using GimmeBooks.ViewModels.AppObject;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System.Collections.ObjectModel;
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
        [SwaggerResponse(System.Net.HttpStatusCode.Accepted, typeof(NewsAnalitics_vw))]
        public async Task<IActionResult> Post(ECategoryType category = ECategoryType.Science)
        {
            return ReturnResult(await _newsAppService.FindAndSave(category));
        }

        [HttpGet]
        [SwaggerResponse(System.Net.HttpStatusCode.Accepted, typeof(ReadOnlyCollection<NewsAnalitics_vw>))]
        public async Task<IActionResult> Get()
        {
            return ReturnResult(await _newsAppService.AllAsync());
        }
    }
}
