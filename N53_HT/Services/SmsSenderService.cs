using N53_HT.Models;
using N53_HT.Services.Interfaces;

namespace N53_HT.Services;

public class SmsSenderService : INotificationService
{
    public ValueTask SendAsync(User user, string message)
    {
        Console.WriteLine($"Sending sms to {user.Id} with content: {message}");

        return new ValueTask();
    }
}