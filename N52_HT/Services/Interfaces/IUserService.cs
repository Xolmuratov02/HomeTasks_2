using N52_HT.Models;

namespace N52_HT.Services.Interfaces;

public interface IUserService
{
    ValueTask<User> CreateUserAsync(User user);
}