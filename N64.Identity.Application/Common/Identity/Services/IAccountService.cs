namespace N64.Identity.Application.Common.Identity.Services;

using N64.Identity.Domain.Entities;

public interface IAccountService
{
    ValueTask<bool> VerificateAsync(string token, CancellationToken cancellationToken = default);

    ValueTask<bool> CreateUserAsync(User user, CancellationToken cancellationToken = default);