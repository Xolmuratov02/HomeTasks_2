namespace N52_HT.Models;

public class AccountEventStore
{
    public event Func<User, ValueTask>? OnUserCreated;

    public async ValueTask CreateUserAsync(User user)
    {
        if (user != null)
            await OnUserCreated(user);
    }
}