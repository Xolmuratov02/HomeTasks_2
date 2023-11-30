using Microsoft.EntityFrameworkCore;
using N75.DataContexts;
using N75.Models.Entities;

namespace N75.Services;

public class UserService(IdentityDbContext identityDbContext)
{
    public async ValueTask<User?> GetByIdAsync(Guid userId, bool asNoTracking = false, CancellationToken cancellationToken = default)
    {
        var initialQuery = identityDbContext.Users.Where(user => user.Id == userId);

        if (asNoTracking)
            initialQuery = initialQuery.AsNoTracking();

        return await initialQuery.FirstOrDefaultAsync(cancellationToken);
    }

    public async ValueTask<User> CreateAsync(User user, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        user.Id = Guid.Empty;

        identityDbContext.Add(user);

        if (saveChanges)
            await identityDbContext.SaveChangesAsync(cancellationToken);

        return user;
    }
}