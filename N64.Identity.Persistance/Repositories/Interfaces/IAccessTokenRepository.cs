using N64.Identity.Domain.Common;
using N64.Identity.Domain.Entities;
using System.Linq.Expressions;

namespace N64.Identity.Persistance.Repositories.Interfaces;

public interface IAccessTokenRepository
{
    ValueTask<AccessToken> CreateAsync(
        AccessToken token,
        bool saveChanges = true,
        CancellationToken cancellationToken = default
    );
}