using N52_HT.Models;
using N52_HT.Services.Interfaces;

namespace N52_HT.Services;

public class AccountNotificationService : IAccountNotificationService
{
    private readonly AccountEventStore _eventStore;
    private readonly IEmailSenderService _emailSenderService;

    public AccountNotificationService(AccountEventStore accountEventStore, IEmailSenderService emailSenderService)
    {
        _eventStore = accountEventStore;

        _emailSenderService = emailSenderService;

        _eventStore.OnUserCreated += CreateUserAsync;
    }

    public async ValueTask CreateUserAsync(User user)
    {
        Console.WriteLine($"Account created for user - {user.FirstName} {user.LastName}");
        await _emailSenderService.SendEmailAsync(user);
    }
}