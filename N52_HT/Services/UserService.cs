using N52_HT.Models;
using N52_HT.Services.Interfaces;

namespace N52_HT.Services;

public class UserService : IUserService
{
    private readonly AccountEventStore _accountEventStore;

    public UserService(AccountEventStore accountEventStore)
    {
        _accountEventStore = accountEventStore;
    }

    public async ValueTask<User> CreateUserAsync(User user)
    {
        await _accountEventStore.CreateUserAsync(user);

        return user;
    }
}