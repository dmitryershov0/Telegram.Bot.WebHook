using Microsoft.Extensions.Options;
using MihaZupan;
using System.Collections.Generic;
using Telegram.Bot.DotNetCoreWebHook.Models.Commands;

namespace Telegram.Bot.DotNetCoreWebHook.Services
{
    public class BotService : IBotService
    {
        private readonly BotConfiguration _config;
        private List<Command> commandsList;

        public BotService(IOptions<BotConfiguration> config)
        {
            _config = config.Value;
            // use proxy if configured in appsettings.*.json
            Client = string.IsNullOrEmpty(_config.Socks5Host)
                ? new TelegramBotClient(_config.BotToken)
                : new TelegramBotClient(
                    _config.BotToken,
                    new HttpToSocks5Proxy(_config.Socks5Host, _config.Socks5Port));
            SetCommands();
        }

        private void SetCommands()
        {
            commandsList = new List<Command>();
            commandsList.Add(new StartCommand());
        }

        public TelegramBotClient Client { get; }

        public IReadOnlyList<Command> Commands => commandsList.AsReadOnly();
    }
}
