namespace N64.Identity.Application.Common.Identity.Services;

using N64.Identity.Domain.Entities;

public interface IAccountService
{
    List<User> Users { get; }

    ValueTask<bool> VerificateAsync(string token);

    ValueTask<User> CreateUserAsync(User user);
}