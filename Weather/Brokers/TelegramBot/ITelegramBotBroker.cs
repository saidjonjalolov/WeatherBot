using Telegram.Bot;
using Telegram.Bot.Types;

namespace Weather.Brokers.TelegramBot
{
    internal interface ITelegramBotBroker
    {
        void StartTelegramBot(
           Func<ITelegramBotClient, Update, CancellationToken, Task> handleUpdate,
           Func<ITelegramBotClient, Exception, CancellationToken, Task> handleError
           );
    }
}
