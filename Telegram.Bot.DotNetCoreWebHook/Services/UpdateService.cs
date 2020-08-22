using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Telegram.Bot.DotNetCoreWebHook.Models.Commands.Helpers;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram.Bot.DotNetCoreWebHook.Services
{
    public class UpdateService : IUpdateService
    {
        private readonly IBotService _botService;
        private readonly ILogger<UpdateService> _logger;

        public UpdateService(IBotService botService, ILogger<UpdateService> logger)
        {
            _botService = botService;
            _logger = logger;
        }

        public async Task ExecuteCommand(Update update)
        {
            if (update.Type != UpdateType.Message)
                return;

            var message = update.Message;

            if (!message.IsCommand())
                return;

            var commands = _botService.Commands;

            foreach (var command in commands)
            {
                if (command.Contains(message))
                {
                    await command.Execute(message, _botService.Client);
                    break;
                }
            }
        }

    }
}
