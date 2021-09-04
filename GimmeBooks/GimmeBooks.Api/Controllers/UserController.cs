using GimmeBooks.Application.AppServices;
using GimmeBooks.ViewModels.AppObjects;
using Microsoft.AspNetCore.Mvc;

namespace GimmeBooks.Api.Controllers
{
    public class UserController : BaseController
    {
        private readonly UserAppService _appService;

        public UserController(UserAppService appService)
        {
            this._appService = appService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return ReturnResult(_appService.FindById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] UserApp_vw value)
        {
            return ReturnResult(_appService.Add(value));
        }

        [HttpPut]
        public IActionResult Put([FromBody] UserApp_vw value)
        {
            _appService.Update(value);
            return Ok();
        }
    }
}
