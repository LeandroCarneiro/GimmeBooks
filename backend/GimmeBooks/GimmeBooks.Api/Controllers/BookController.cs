using GimmeBooks.Application.AppServices;
using GimmeBooks.Common;
using GimmeBooks.ViewModels.AppObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System;
using System.Collections.ObjectModel;
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
        [SwaggerResponse(System.Net.HttpStatusCode.Accepted, typeof(ReadOnlyCollection<Book_vw>))]
        public async Task<IActionResult> Get(ECategoryType category, string keywords)
        {
            return ReturnResult(await _appService.Find(category, keywords));
        }
    }
}
