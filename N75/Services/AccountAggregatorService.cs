using N75.Models.Entities;

namespace N75.Services;

public class AccountAggregatorService(UserService userService, EmailSenderService emailSenderService)
{
    public async ValueTask<User> CreateAsync(User user, CancellationToken cancellationToken = default)
    {
        var createdUser = await userService.CreateAsync(user, true, cancellationToken);

        await emailSenderService.QueueAsync(user.Id,
            user.EmailAddress,
            "Welcome",
            "Welcome John",
            cancellationToken: cancellationToken);

        return createdUser;
    }
}