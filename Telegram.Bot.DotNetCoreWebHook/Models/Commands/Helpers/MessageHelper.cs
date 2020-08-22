using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram.Bot.DotNetCoreWebHook.Models.Commands.Helpers
{
    public static class MessageHelper
    {
        public static bool IsCommand(this Message message)
        {
            if (message.Type != MessageType.Text)
                return false;
            return message.Text.StartsWith('/');
        }
    }
}
