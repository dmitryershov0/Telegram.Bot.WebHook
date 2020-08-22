using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace Telegram.Bot.DotNetCoreWebHook.Services
{
    public interface IUpdateService
    {
        Task ExecuteCommand(Update update);
    }
}
