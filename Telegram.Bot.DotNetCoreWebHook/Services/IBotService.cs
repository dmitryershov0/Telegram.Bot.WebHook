using System.Collections.Generic;
using Telegram.Bot.DotNetCoreWebHook.Models.Commands;

namespace Telegram.Bot.DotNetCoreWebHook.Services
{
    public interface IBotService
    {
        TelegramBotClient Client { get; }

        IReadOnlyList<Command> Commands { get; }
    }
}
