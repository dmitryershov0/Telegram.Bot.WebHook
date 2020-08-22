using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram.Bot.DotNetCoreWebHook.Models.Commands.Helpers
{
    public static class CommandHelper
    {
        public static bool Contains(this Command command, Message message)
        {
            return message.Text.Contains(command.Name);
        }
    }
}
