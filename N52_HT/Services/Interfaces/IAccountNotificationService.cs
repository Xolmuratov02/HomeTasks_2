using N52_HT.Models;

namespace N52_HT.Services.Interfaces;

public interface IAccountNotificationService
{
    ValueTask CreateUserAsync(User user);
}