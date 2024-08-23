﻿using Telegram.Bot.Types;
using Telegram.Bot;


namespace Weather.Brokers.TelegramBot
{
    partial class TelegramBotBroker
    {
        public void StartTelegramBot(
            Func<ITelegramBotClient, Update, CancellationToken, Task> handleUpdate,
            Func<ITelegramBotClient, Exception, CancellationToken, Task> handleError)
        {
            this.client.StartReceiving(handleUpdate, handleError);
        }
    }
}
