using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace tgbotdembel
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var Client = new TelegramBotClient("8104620140:AAFwDA4UqfRm5sZHplYW-FyZuwNYlXSxIgE");
            Client.StartReceiving(Update, Error);
            Console.ReadLine();
            
            
            
        }

        private static async Task Error(ITelegramBotClient client, Exception exception, HandleErrorSource source, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        async static Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
        {
            DateTime date1 = new DateTime(2025, 7, 1); // год - месяц - день
            string fileURL = "https://sun9-75.userapi.com/impg/0X3STBDXkpMhT59ejXNL7FJKyn7xJhlHn1bsvA/RJYlFqFFU7U.jpg?size=960x1280&quality=95&sign=017e005665794c7a9e2527d30b69f2f5&type=album";
            var message = update.Message;
            if (message.Text != null)
                Console.WriteLine($" от {message.Chat.Id}    ||  Сообщение: {message.Text} ");

                
                if (message.Text.ToLower().Contains("/armu"))
                {
                    
                    await botClient.SendMessage(message.Chat.Id, $"до армии: {(date1.Date - DateTime.Now.Date)}");
                    await botClient.SendLocation(message.Chat.Id, 46.9541, 142.736);
                    await botClient.SendPhoto(message.Chat.Id, fileURL, "");

                }
                if (message.Text.ToLower().Contains("здорова"))
                {
                   await botClient.SendMessage(message.Chat.Id, "Здоровей Видали");
                    return;
                }

            }
        }
      

       
    }

