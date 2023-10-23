using N53_HT.Models;

namespace N53_HT.Services.Interfaces;

public interface INotificationService
{
    ValueTask SendAsync(User user, string message);
}