using N53_HT.Models;
using N53_HT.Services.Interfaces;

namespace N53_HT.Services;

public class TelegramSenderService : INotificationService
{
    public ValueTask SendAsync(User user, string message)
    {
        Console.WriteLine($"Sending telegram to {user.Id} with content: {message}");

        return new ValueTask();
    }
}