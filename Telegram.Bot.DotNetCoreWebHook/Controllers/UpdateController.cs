using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.DotNetCoreWebHook.Services;
using Telegram.Bot.Types;

namespace Telegram.Bot.DotNetCoreWebHook.Controllers
{
    public class UpdateController : Controller
    {
        private readonly IUpdateService _updateService;

        public UpdateController(IUpdateService updateService)
        {
            _updateService = updateService;
        }

        [Route("api/update")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Update update)
        {
            await _updateService.ExecuteCommand(update);
            return Ok();
        }

        [Route("api/test")]
        public IActionResult Get()
        {
            return Ok("OK");
        }
    }
}
