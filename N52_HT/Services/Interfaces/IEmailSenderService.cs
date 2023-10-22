using N52_HT.Models;

namespace N52_HT.Services.Interfaces;

public interface IEmailSenderService
{
    ValueTask<bool> SendEmailAsync(User user);
}