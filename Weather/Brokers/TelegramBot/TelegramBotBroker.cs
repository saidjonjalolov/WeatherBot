using Telegram.Bot;
using Telegram.Bot.Types;

namespace Weather.Brokers.TelegramBot
{
    partial class TelegramBotBroker : ITelegramBotBroker
    {
        private readonly string token = @"7231628443:AAGDVsGIJMDVGdBEYcBfy_wnM6UwuFw9jcg";
        private readonly ITelegramBotClient client;

        public TelegramBotBroker()
        {
            this.client = new TelegramBotClient(token);
        }
    }
}
